using System;
using System.IO;
using Model;
using Ninject;

namespace Presentation
{
    public class CharacterPresenter
    {
        private readonly IKernel _kernel;
        private readonly ICharacterView _view;
        private readonly ICharacterService _service;
        public CharacterPresenter(IKernel kernel, ICharacterView view, ICharacterService service)
        {
            _kernel = kernel;

            _view = view;
            _view.ImportCharacters += ImportCharacters;
            _view.ExportCharacters += ExportCharacters;
            _view.AddCharacter += AddCharacter;
            _view.RemoveCharacter += RemoveCharacter;
            _view.GoBack += ShowInitiativeView;

            _service = service;
            _service.CharacterUpdated += ShowCharacters;
        }

        private void AddCharacter(string name)
        {
            _service.CreateCharacter(name);
        }

        private void RemoveCharacter(string name)
        {
            _service.RemoveCharacter(name);
        }

        private void ShowCharacters()
        {
            _view.ShowCharacters(_service.GetAllCharacters());
        }

        private void ImportCharacters(string path)
        {
            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    _service.ImportCharacters(reader);
                }
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void ExportCharacters(string path)
        {
            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    _service.ExportCharacters(writer);
                }
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void ShowInitiativeView()
        {
            _kernel.Get<InitiativePresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            ShowCharacters();
            _view.Show();
        }
    }
}