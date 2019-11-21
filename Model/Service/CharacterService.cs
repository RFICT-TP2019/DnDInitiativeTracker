using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Model.Entity;

namespace Model.Service
{
    public class CharacterService : ICharacterService
    {
        private readonly IRepository<Character> _repository;
        private readonly JsonSerializer _serializer;
        public CharacterService(IRepository<Character> repository)
        {
            _repository = repository;
            _serializer = new JsonSerializer();
        }

        public IEnumerable<string> GetAllCharacters()
        {
            return _repository.GetAll().Select(c => c.Name);
        }

        public void ImportCharacters(StreamReader reader)
        {
            List<Character> characters =  (List<Character>)_serializer.Deserialize(reader, typeof(List<Character>));
            foreach (var c in characters)
            {
                _repository.Add(c);
            }
            _repository.Save();
            CharacterUpdated?.Invoke();
        }

        public void ExportCharacters(StreamWriter writer)
        {
            _serializer.Serialize(writer, _repository.GetAll());
        }

        public void CreateCharacter(string name)
        {
            var character = _repository.GetAll().FirstOrDefault(c => c.Name == name);
            if (character == null)
            {
                _repository.Add(new Character {Name = name});
                _repository.Save();
                CharacterUpdated?.Invoke();
            }
        }

        public void RemoveCharacter(string name)
        {
            var character = _repository.GetAll().FirstOrDefault(c => c.Name == name);
            if (character != null)
            {
                _repository.Remove(character.Id);
                _repository.Save();
                CharacterUpdated?.Invoke();
            }
        }

        private void RenameCharacter(string old_name, string new_name)
        {
            var character = _repository.GetAll().FirstOrDefault(c => c.Name == old_name);
            if (character != null)
            {
                character.Name = new_name;
                _repository.Update(character);
                _repository.Save();
                CharacterUpdated?.Invoke();
            }
        }

        public event Action CharacterUpdated;
    }
}
