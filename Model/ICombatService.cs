using System;
using System.Collections.Generic;

namespace Model
{
    public interface ICombatService
    {
        event Action CombatDurationUpdated;
        event Action TurnFinished;
        event Action InitiativeUpdated;

        int Round { get; }
        int Turn { get; }

        TimeSpan TurnDurationLimit { get; set; }
        TimeSpan CombatDuration { get; }
        TimeSpan RoundDuration { get; }
        TimeSpan TurnDuration { get; }

        IEnumerable<TimeSpan> GetRoundDurations();
        IEnumerable<Tuple<string, TimeSpan>> GetTurnAverageDurations();

        IEnumerable<string> GetInitiative();
        void ClearInitiative();

        void StartCombat();
        void StopCombat();
        void NextTurn();
    }
}