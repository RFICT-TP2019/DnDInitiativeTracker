using System;
using Model;

namespace Presentation
{
    public class AddInitiativePresenter
    {
        private IAddInitiativeView _view;
        private IAddInitiativeService _service;
        public AddInitiativePresenter(IAddInitiativeView view, IAddInitiativeService service)
        {
            _view = view;
            _view.AddInitiative += AddInitiative;

            _service = service;
            _service.InitiativeUpdated += HandleInitiativeUpdated;
        }

        private void AddInitiative()
        {
            if (int.TryParse(_view.Initiative, out int initiative))
            {
                _service.AddInitiative(_view.CharacterName, initiative);
            }
            else
            {
                _view.ShowError("Invalid 'Initiative' value");
            }
        }

        public event Action InitiativeUpdated;

        private void HandleInitiativeUpdated()
        {
            InitiativeUpdated?.Invoke();
            _view.Close();
        }

        public void Run()
        {
            _view.ShowCharacters(_service.GetRemainingCharacters());
            _view.Show();
        }
    }
}