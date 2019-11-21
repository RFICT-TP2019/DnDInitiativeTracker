using System;
using System.Collections.Generic;
using System.Linq;
using Model.Entity;

namespace Model.Service
{
    public class AddInitiativeService : IAddInitiativeService
    {
        private IRepository<Character> _character_repository;
        private IRepository<InitiativeEntry> _initiative_repository;
        public AddInitiativeService(IRepository<Character> character_repository, IRepository<InitiativeEntry> initiative_repository)
        {
            _character_repository = character_repository;
            _initiative_repository = initiative_repository;
        }

        public event Action InitiativeUpdated;
        public IEnumerable<string> GetRemainingCharacters()
        {
            var characters = _character_repository.GetAll();
            var initiatives = _initiative_repository.GetAll();

            return characters.Select(c => c.Name).Except(initiatives.Select(i => i.Name));
        }

        public void AddInitiative(string name, int initiative)
        {
            var entry = _initiative_repository.GetAll().FirstOrDefault(c => c.Name == name);
            if (entry == null)
            {
                _initiative_repository.Add(new InitiativeEntry { Name = name, Initiative = initiative});
            }
            else
            {
                entry.Initiative = initiative;
                _initiative_repository.Update(entry);
            }
            _initiative_repository.Save();
            InitiativeUpdated?.Invoke();
        }
    }
}