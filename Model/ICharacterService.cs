using System;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    public interface ICharacterService
    {
        event Action CharacterUpdated;

        IEnumerable<string> GetAllCharacters();
        void ImportCharacters(StreamReader reader);
        void ExportCharacters(StreamWriter writer);
        void CreateCharacter(string name);
        void RemoveCharacter(string name);
    }
}