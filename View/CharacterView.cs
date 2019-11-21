using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Presentation;

namespace View
{
    public partial class CharacterView : Form, ICharacterView
    {
        private readonly ApplicationContext _context;
        public CharacterView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            ShowError(string.Empty);
            base.Show();
        }

        public event Action GoBack;
        public event Action<string> ImportCharacters;
        public event Action<string> ExportCharacters;
        public event Action<string> AddCharacter;
        public event Action<string> RemoveCharacter;

        public void ShowCharacters(IEnumerable<string> characters)
        {
            lv_Characters.Items.Clear();
            foreach (var name in characters)
            {
                lv_Characters.Items.Add(name);
            }
        }

        public void ShowError(string message)
        {
            lbl_Error.Text = message;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            GoBack?.Invoke();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportCharacters?.Invoke(openFileDialog.FileName);
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportCharacters?.Invoke(saveFileDialog.FileName);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddCharacter?.Invoke(tb_Name.Text);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            foreach (var item in lv_Characters.SelectedItems)
            {
                var lvItem = item as ListViewItem;
                RemoveCharacter?.Invoke(lvItem?.Text);
            }
        }
    }
}
