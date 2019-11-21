using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Presentation;

namespace View
{
    public partial class InitiativeView : Form, IInitiativeView
    {
        private bool _combat;
        private readonly ApplicationContext _context;
        private string[] _initiative;
        public InitiativeView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            ResetView();
        }

        public new void Show()
        {
            ResetView();
            _context.MainForm = this;
            base.Show();
        }

        public event Action ShowAddInitiative;
        public event Action ShowCharacters;
        public event Action StartCombat;
        public event Action StopCombat;
        public event Action NextTurn;
        public event Action ClearInitiative;
        public string TurnDurationLimit {
            get => tb_TurnDurationLimit.Text;
            set => tb_TurnDurationLimit.Text = value;
        }


        public void ShowInitiative(IEnumerable<string> initiative)
        {
            _initiative = initiative.ToArray();
            lv_Initiative.Items.Clear();
            foreach (var item in _initiative)
            {
                lv_Initiative.Items.Add(item);
            }

            btn_Left.Enabled = _combat || _initiative.Any();
        }

        public void ShowCombatStatus(int round, int turn)
        {
            lv_Initiative.Items.Clear();

            // Draw Round number
            lv_Initiative.Items.Add(new ListViewItem { Text = $"Round {round + 1}", ForeColor = Color.Red});

            // Current character is marked as Bold
            lv_Initiative.Items.Add(new ListViewItem { Text = _initiative[turn], Font = new Font(lv_Initiative.Font, FontStyle.Bold) });

            // Draw remaining characters
            for (int i = turn + 1; i < _initiative.Length; ++i)
                lv_Initiative.Items.Add(_initiative[i]);
        }

        public void ShowTime(TimeSpan battle_duration, TimeSpan round_duration, TimeSpan turn_duration)
        {
            tb_BattleDuration.Text = $@"{battle_duration:h\:mm\:ss}";
            tb_RoundDuration.Text = $@"{round_duration:h\:mm\:ss}";
            tb_TurnDuration.Text = $@"{turn_duration:h\:mm\:ss}";
        }

        public void CombatStarted()
        {
            _combat = true;
            btn_Left.Text = @"Next turn";
            btn_Right.Text = @"Stop battle";
            btn_Add.Enabled = false;
            btn_ShowCharacters.Enabled = false;
            tb_TurnDurationLimit.Enabled = false;
        }

        private void ResetView()
        {
            _combat = false;
            btn_Left.Text = @"Start battle";
            btn_Right.Text = @"Clear";
            btn_Add.Enabled = true;
            btn_ShowCharacters.Enabled = true;
            tb_TurnDurationLimit.Enabled = true;
            ShowTime(TimeSpan.Zero, TimeSpan.Zero, TimeSpan.Zero);
        }

        public void CombatStopped()
        {
            ResetView();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ShowAddInitiative?.Invoke();
        }

        private void btn_ShowCharacters_Click(object sender, System.EventArgs e)
        {
            ShowCharacters?.Invoke();
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            if (_combat) 
                NextTurn?.Invoke();
            else
                StartCombat?.Invoke();
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            if (_combat)
                StopCombat?.Invoke();
            else
                ClearInitiative?.Invoke();
        }
    }
}
