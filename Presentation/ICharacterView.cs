using System;
using System.Collections.Generic;

namespace Presentation
{
    public interface ICharacterView : IView
    {
        event Action GoBack;
        event Action<string> ImportCharacters;
        event Action<string> ExportCharacters;
        event Action<string> AddCharacter;
        event Action<string> RemoveCharacter;

        void ShowCharacters(IEnumerable<string> characters);
        void ShowError(string message);
    }
}