using System;
using Model;
using Ninject;

namespace Presentation
{
    public class InitiativePresenter
    {
        private readonly IKernel _kernel;
        private IInitiativeView _view;
        private ICombatService _combatService;

        public InitiativePresenter(IKernel kernel, IInitiativeView view, ICombatService combatService)
        {
            _kernel = kernel;

            _view = view;
            _view.ShowAddInitiative += ShowAddInitiative;
            _view.ShowCharacters += ShowCharacters;
            _view.StartCombat += StartCombat;
            _view.StopCombat += StopCombat;
            _view.NextTurn += NextTurn;
            _view.ClearInitiative += ClearInitiative;

            _combatService = combatService;
            _combatService.CombatDurationUpdated += CombatTimeUpdated;
            _combatService.TurnFinished += TurnFinished;
            _combatService.InitiativeUpdated += ShowInitiative;
        }

        private void ClearInitiative()
        {
            _combatService.ClearInitiative();
        }

        private void TurnFinished()
        {
            _view.ShowCombatStatus(_combatService.Round, _combatService.Turn);
        }

        private void NextTurn()
        {
          _combatService.NextTurn();
        }

        private void CombatTimeUpdated()
        {
            _view.ShowTime(_combatService.CombatDuration, _combatService.RoundDuration, _combatService.TurnDuration);
        }

        private void StartCombat()
        {
            if (int.TryParse(_view.TurnDurationLimit, out int limit))
                _combatService.TurnDurationLimit = TimeSpan.FromSeconds(limit);
            _view.TurnDurationLimit = _combatService.TurnDurationLimit.Seconds.ToString();

            _combatService.StartCombat();
            _view.CombatStarted();
            _view.ShowCombatStatus(_combatService.Round, _combatService.Turn);
        }

        private void StopCombat()
        {
            _combatService.StopCombat();
            _view.CombatStopped();
            ShowInitiative();

            var statistics_view = _kernel.Get<IStatisticsView>();
            statistics_view.RoundDurations = _combatService.GetRoundDurations();
            statistics_view.TurnAverageDurations = _combatService.GetTurnAverageDurations();
            statistics_view.Show();
        }

        private void ShowAddInitiative()
        {
            var presenter = _kernel.Get<AddInitiativePresenter>();
            presenter.InitiativeUpdated += ShowInitiative;
            presenter.Run();
        }

        private void ShowInitiative()
        {
            _view.ShowInitiative(_combatService.GetInitiative());
        }

        private void ShowCharacters()
        {
            _kernel.Get<CharacterPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            ShowInitiative();
            _view.Show();
        }
    }
}