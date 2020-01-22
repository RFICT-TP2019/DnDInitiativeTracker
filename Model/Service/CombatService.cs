using System;
using System.Collections.Generic;
using System.Linq;
using Model.Entity;

namespace Model.Service
{
    public class CombatService : ICombatService
    {
        private readonly IRepository<InitiativeEntry> _repository;
        private readonly ITimer _timer;
        private DateTime _combat_start;
        private DateTime _round_start;
        private DateTime _turn_start;
        private TimeSpan _turn_duration_limit;
        private string[] _initiative;
        private TimeSpan[] _turn_durations;
        private List<TimeSpan> _round_durations;

        public CombatService(ITimer timer, IRepository<InitiativeEntry> repository)
        {
            _repository = repository;
            _timer = timer;
            _timer.Interval = 1000;
            _timer.Tick += TimerTick;

            _round_durations = new List<TimeSpan>();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (TimeSpan.Zero < _turn_duration_limit && TurnDurationLimit < DateTime.Now - _turn_start)
                NextTurn();
            CombatDurationUpdated?.Invoke();
        }

        public event Action CombatDurationUpdated;
        public event Action TurnFinished;
        public event Action InitiativeUpdated;
        public int Round { private set; get; }
        public int Turn { private set; get; }

        public TimeSpan TurnDurationLimit
        {
            get => _turn_duration_limit;
            set
            {
                if (value >= TimeSpan.Zero)
                    _turn_duration_limit = value;
                else
                    throw new ArgumentException($"{value} is negative", "TurnDurationLimit");
            }
        }

        public TimeSpan CombatDuration => DateTime.Now - _combat_start;
        public TimeSpan RoundDuration => DateTime.Now - _round_start;
        public TimeSpan TurnDuration => DateTime.Now - _turn_start;

        public IEnumerable<TimeSpan> GetRoundDurations() => _round_durations;

        public IEnumerable<Tuple<string, TimeSpan>> GetTurnAverageDurations()
        {
            var average_durations = new Tuple<string, TimeSpan>[_initiative.Length];
            for (var i = 0; i < _initiative.Length; i++)
            {
                var name = _initiative[i];
                int turns = Round + (i < Turn ? 1 : 0);
                var average_turn = turns > 0 ? TimeSpan.FromTicks(_turn_durations[i].Ticks / (turns)) : TimeSpan.Zero;
                average_durations[i] = Tuple.Create(name, average_turn);
            }

            return average_durations;
        }

        public IEnumerable<string> GetInitiative()
        {
            if (_timer.Enabled)
                return _initiative;
            else
                return _repository.GetAll().OrderByDescending(ie => ie.Initiative).Select(ie => ie.Name);
        }

        public void ClearInitiative()
        {
            foreach (var entry in _repository.GetAll())
            {
                _repository.Remove(entry.Id);
            }
            _repository.Save();
            InitiativeUpdated?.Invoke();
        }

        public void StartCombat()
        {
            _initiative = GetInitiative().ToArray();  // copy initiative to avoid state changes during combat
            if (!_initiative.Any())
                throw new Exception("Unable to start combat without participants!");

            _turn_durations = new TimeSpan[_initiative.Length];
            _round_durations.Clear();
            Round = 0;
            Turn = 0;

            _combat_start = _round_start = _turn_start = DateTime.Now;
            _timer.Start();
        }

        public void StopCombat()
        {
            SwitchToNextTurn();
            if (Turn != 0)  // add not completed round in statistics
                _round_durations.Add(_turn_start - _round_start);
            _timer.Stop();
        }

        public void NextTurn()
        {
            if (!_timer.Enabled)
                return;  // nothing to do because combat is not started

            SwitchToNextTurn();
            TurnFinished?.Invoke();
        }

        private void SwitchToNextTurn()
        {
            DateTime turn_end = DateTime.Now;
            _turn_durations[Turn] += turn_end - _turn_start;
            _turn_start = turn_end;
            Turn += 1;
            if (Turn >= _initiative.Length)
            {
                Turn = 0;
                Round += 1;
                _round_durations.Add(_turn_start - _round_start);
                _round_start = _turn_start;
            }
        }
    }
}