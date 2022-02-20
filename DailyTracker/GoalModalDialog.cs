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
        public GoalModalDialog()
        {
            InitializeComponent();

            // Manage UI Properties
            {
                Text = $"Create a new goal :)";
            }

            // Event Handlers
            FormClosing += GoalModalDialog_FormClosing1;
        }

        private void GoalModalDialog_FormClosing1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;

            Hide();
        }
    }
}
