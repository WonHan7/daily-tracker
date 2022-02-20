/// Author: Wonseok Han
/// This modal dialog serves as a way to retrieve user input and pass it onto the Goal class
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
    public partial class GoalModalDialog : Form
    {
        public string SetGoalName
        {
            get { return _inputTB.Text; }
        }

        public bool Duration
        {
            get { return _durationCB.Checked; }
        }

        public GoalModalDialog()
        {
            InitializeComponent();

            // Manage UI Properties
            {
                Text = $":)";
                // Set Fixed Form Size
                this.MinimizeBox = false;
                this.MaximizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.SizeGripStyle = SizeGripStyle.Hide;

                // Input Label
                _goalLabel.Text = $"Goal: ";
                _goalLabel.AutoSize = false;
                _goalLabel.TextAlign = ContentAlignment.MiddleCenter;

                _durationCB.Text = $"Duration";
                _durationCB.TextAlign = ContentAlignment.MiddleCenter;

                _submitBtn.Text = $"Create Goal";
                _submitBtn.TextAlign = ContentAlignment.MiddleCenter;
            }

            // Form Event Handlers
            Shown += GoalModalDialog_Shown;
            FormClosing += GoalModalDialog_FormClosing1;

            // UI Event Handlers
            _submitBtn.Click += _submitBtn_Click;
        }

        private void GoalModalDialog_Shown(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void _submitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        private void GoalModalDialog_FormClosing1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;

            Hide();
        }
    }
}
