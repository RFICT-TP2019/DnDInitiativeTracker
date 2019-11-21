using System;
using System.Collections.Generic;

namespace Model
{
    public interface IAddInitiativeService
    {
        event Action InitiativeUpdated;

        IEnumerable<string> GetRemainingCharacters();
        void AddInitiative(string name, int initiative);
    }
}