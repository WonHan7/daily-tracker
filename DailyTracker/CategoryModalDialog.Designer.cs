
namespace DailyTracker
{
    partial class CategoryModalDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._catLabel = new System.Windows.Forms.Label();
            this._inputTB = new System.Windows.Forms.RichTextBox();
            this._submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _catLabel
            // 
            this._catLabel.Location = new System.Drawing.Point(12, 9);
            this._catLabel.Name = "_catLabel";
            this._catLabel.Size = new System.Drawing.Size(87, 13);
            this._catLabel.TabIndex = 0;
            this._catLabel.Text = "label1";
            // 
            // _inputTB
            // 
            this._inputTB.Location = new System.Drawing.Point(105, 6);
            this._inputTB.Name = "_inputTB";
            this._inputTB.Size = new System.Drawing.Size(112, 21);
            this._inputTB.TabIndex = 1;
            this._inputTB.Text = "";
            // 
            // _submitBtn
            // 
            this._submitBtn.Location = new System.Drawing.Point(57, 33);
            this._submitBtn.Name = "_submitBtn";
            this._submitBtn.Size = new System.Drawing.Size(117, 23);
            this._submitBtn.TabIndex = 3;
            this._submitBtn.Text = "button1";
            this._submitBtn.UseVisualStyleBackColor = true;
            // 
            // CategoryModalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 62);
            this.Controls.Add(this._submitBtn);
            this.Controls.Add(this._inputTB);
            this.Controls.Add(this._catLabel);
            this.Name = "CategoryModalDialog";
            this.Text = "GoalModalDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _catLabel;
        private System.Windows.Forms.RichTextBox _inputTB;
        private System.Windows.Forms.Button _submitBtn;
    }
}