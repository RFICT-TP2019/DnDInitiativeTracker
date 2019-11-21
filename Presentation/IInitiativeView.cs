using System;
using System.Collections.Generic;

namespace Presentation
{
    public interface IInitiativeView : IView
    {
        event Action ShowAddInitiative;
        event Action ShowCharacters;

        event Action StartCombat;
        event Action StopCombat;
        event Action NextTurn;
        event Action ClearInitiative;

        string TurnDurationLimit { get; set; }

        void ShowInitiative(IEnumerable<string> initiative);
        void ShowCombatStatus(int round, int turn);
        void ShowTime(TimeSpan combat_duration, TimeSpan round_duration, TimeSpan turn_duration);
        void CombatStarted();
        void CombatStopped();
    }
}