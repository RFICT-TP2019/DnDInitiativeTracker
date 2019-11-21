using System;
using System.Collections.Generic;

namespace Presentation
{
    public interface IAddInitiativeView : IView
    {
        string CharacterName { get; }
        string Initiative { get; }

        event Action AddInitiative;

        void ShowCharacters(IEnumerable<string> characters);
        void ShowError(string message);
    }
}