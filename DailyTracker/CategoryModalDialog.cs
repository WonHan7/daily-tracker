/// Author: Wonseok Han
/// This modal dialog is used to add new categories to the main form
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
    public partial class CategoryModalDialog : Form
    {
        public string SetCategoryName
        {
            get { return _inputTB.Text.ToString(); }
        }

        public CategoryModalDialog()
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
                _catLabel.Text = $"Category Name: ";
                _catLabel.AutoSize = false;
                _catLabel.TextAlign = ContentAlignment.MiddleLeft;

                // Input textbox
                _inputTB.ScrollBars = RichTextBoxScrollBars.None;

                // Confirm button
                _submitBtn.Text = $"Create Category";
                _submitBtn.TextAlign = ContentAlignment.MiddleCenter;
            }

            // Form Event Handlers
            Shown += CategoryModalDialog_Shown;
            FormClosing += CategoryModalDialog_FormClosing;

            // UI Event Handlers
            _submitBtn.Click += _submitBtn_Click;
        }

        private void CategoryModalDialog_Shown(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void _submitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        private void CategoryModalDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing))
                e.Cancel = true;

            Hide();
        }
    }
}
