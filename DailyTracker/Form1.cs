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
        GoalModalDialog dlg = new GoalModalDialog();

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
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Do something in the event the user inputs correct information
            }
        }
    }
}
