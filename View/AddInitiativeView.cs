using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Presentation;

namespace View
{
    public partial class AddInitiativeView : Form, IAddInitiativeView
    {
        public AddInitiativeView()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            ShowError(string.Empty);
            base.Show();
        }

        public string Initiative => tb_Initiative.Text;
        public string CharacterName => tb_CharacterName.Text;

        public event Action AddInitiative;
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddInitiative?.Invoke();
        }

        private void lv_Characters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Characters.SelectedItems.Count > 0)
            {
                tb_CharacterName.Text = lv_Characters.SelectedItems[0].Text;
            }
        }
    }
}
