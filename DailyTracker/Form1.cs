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
        CategoryModalDialog _dlgC = new CategoryModalDialog();
        GoalModalDialog _dlg = new GoalModalDialog();

        List<Category> _catList = new List<Category>();
        List<Goal> _goalList = new List<Goal>();

        public Form1()
        {
            InitializeComponent();

            // Manage UI Properties
            {
                Text = $"Daily Tracker App";

                /*
                // Default Category
                _disciplineTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
                _disciplineTool.Text = $"Discipline";
                */

                /*
                // Add New Category
                _newCatBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
                _newCatBtn.Text = $"Add New Category";
                */

                // Add New Goal
                _newGoalBtn.Text = $"Add New Goal";
                _newGoalBtn.TabIndex = 99;

                /*
                // FlowLayoutPanel
                _disciplineFLP.Dock = DockStyle.Fill;
                _disciplineFLP.FlowDirection = FlowDirection.LeftToRight;
                _disciplineFLP.AutoScroll = true;
                */
            }

            // Form Event Handlers
            Shown += Form1_Shown;

            // UI Event Handlers
            _newGoalBtn.Click += _newGoalBtn_Click;
            _newCatBtn.Click += _newCatBtn_Click;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        // Display modal dialog to create new goal panel
        private void _newGoalBtn_Click(object sender, EventArgs e)
        {
            if (_dlg.ShowDialog().Equals(DialogResult.OK))
            {
                Goal tempG = new Goal(_dlg.SetGoalName);

                // Enable notes
                if (_dlg.Notes)
                {
                    tempG._note = true;
                }

                // Check for duplicates
                if (!(_goalList.Any((g) => tempG._goalName.Equals(g._goalName))))
                {
                    _goalList.Add(tempG);
                    _disciplineFLP.Controls.Add(Goal.CreateGoalPanel(tempG, _goalList, _disciplineFLP));
                    Text = $"Daily Tracker App - Successfully added {tempG._goalName}!";
                }
                else
                    Text = $"Daily Tracker App - Goal already exists!";
            }
        }

        private void _newCatBtn_Click(object sender, EventArgs e)
        {
            if (_dlgC.ShowDialog().Equals(DialogResult.OK))
            {
                Category tempC = new Category(_catList);

                // Check for duplicates
                if (!(_catList.Any((c) => tempC.Equals(c))))
                {
                    // Do something
                }
                else
                    Text = $"Daily Tracker App - Category already exists!";
            }
        }
    }
}
