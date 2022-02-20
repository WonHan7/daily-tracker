/// Author: Wonseok Han
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTracker
{
    public partial class Form1 : Form
    {
        GoalModalDialog _dlg = new GoalModalDialog();
        List<Goal> _goalList = new List<Goal>();

        public Form1()
        {
            InitializeComponent();

            // Manage UI Properties
            {
                Text = $"Daily Tracker App";

                // Default Category
                _disciplineTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
                _disciplineTool.Text = $"Discipline";

                // Add New Category
                _newCatBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
                _newCatBtn.Text = $"Add New Category";

                // Add New Goal
                _newGoalBtn.Text = $"Add New Goal";

                // FlowLayoutPanel
                _disciplineFLP.Dock = DockStyle.Fill;
                _disciplineFLP.FlowDirection = FlowDirection.LeftToRight;
                _disciplineFLP.AutoScroll = true;
            }

            // Form Event Handlers
            Shown += Form1_Shown;

            // UI Event Handlers
            _newGoalBtn.Click += _newGoalBtn_Click;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        // Display modal dialog to create new goal panel
        private void _newGoalBtn_Click(object sender, EventArgs e)
        {
            if (_dlg.ShowDialog() == DialogResult.OK)
            {
                if (_dlg.Duration)
                {
                    // Do something
                }
                else
                {
                    Goal tempG = new Goal(_dlg.SetGoalName);
                    if (!(_goalList.Any((g) => tempG._goalName.Equals(g._goalName))))
                    {
                        _goalList.Add(tempG);
                        _disciplineFLP.Controls.Add(Goal.CreateGoalPanel(tempG));
                        Text = $"Daily Tracker App - Successfully added {tempG._goalName}!";
                    }
                    else
                        Text = $"Daily Tracker App - Goal already exists!";
                }
            }
        }
    }
}
