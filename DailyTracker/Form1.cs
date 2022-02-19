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
        public Form1()
        {
            InitializeComponent();

            // Manage UI Properties
            {
                _newCatBtn.Text = $"Add New Goal";
                _goalLabel.Text = $"Test Goal";
                _incBtn.Text = $"Increment";
                _resetBtn.Text = $"Reset";
                _streakLabel.Text = $"1";
                _dateLabel.Text = $"--/--/--";                
            }

            _newGoalBtn.Click += _newGoalBtn_Click;
        }

        private void _newGoalBtn_Click(object sender, EventArgs e)
        {
            // Display pop-up for user to enter name of the goal
            InputModalDialog inputDialog = new InputModalDialog();
            inputDialog.ShowModal();
        }
    }
}
