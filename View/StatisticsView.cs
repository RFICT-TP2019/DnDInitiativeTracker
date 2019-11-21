using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Presentation;

namespace View
{
    public partial class StatisticsView : Form, IStatisticsView
    {
        private IEnumerable<TimeSpan> _roundDurations;
        private IEnumerable<Tuple<string, TimeSpan>> _turnAverageDurations;

        public StatisticsView()
        {
            InitializeComponent();

            lv_Rounds.Columns.Add("Round");
            lv_Rounds.Columns.Add("Duration");

            lv_Characters.Columns.Add("Name");
            lv_Characters.Columns.Add("Average Turn Duration");
        }

        public IEnumerable<TimeSpan> RoundDurations
        {
            get => _roundDurations;
            set
            {
                _roundDurations = value;
                lv_Rounds.Items.Clear();
                int i = 1;
                foreach (var round in _roundDurations)
                {
                    ListViewItem item = new ListViewItem($"{i}");
                    item.SubItems.Add($@"{round:h\:mm\:ss}");
                    lv_Rounds.Items.Add(item);
                    ++i;
                }
            }
        }

        public IEnumerable<Tuple<string, TimeSpan>> TurnAverageDurations
        {
            get => _turnAverageDurations;
            set
            {
                _turnAverageDurations = value;
                lv_Characters.Items.Clear();
                int i = 1;
                foreach (var character in _turnAverageDurations)
                {
                    ListViewItem item = new ListViewItem(character.Item1);
                    item.SubItems.Add($@"{character.Item2:h\:mm\:ss}");
                    lv_Characters.Items.Add(item);
                    ++i;
                }
            }
        }
    }
}
