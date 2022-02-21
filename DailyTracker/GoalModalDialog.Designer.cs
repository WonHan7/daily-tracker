
namespace DailyTracker
{
    partial class GoalModalDialog
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
            this._goalLabel = new System.Windows.Forms.Label();
            this._inputTB = new System.Windows.Forms.RichTextBox();
            this._submitBtn = new System.Windows.Forms.Button();
            this._noteCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _goalLabel
            // 
            this._goalLabel.AutoSize = true;
            this._goalLabel.Location = new System.Drawing.Point(12, 9);
            this._goalLabel.Name = "_goalLabel";
            this._goalLabel.Size = new System.Drawing.Size(35, 13);
            this._goalLabel.TabIndex = 0;
            this._goalLabel.Text = "label1";
            // 
            // _inputTB
            // 
            this._inputTB.Location = new System.Drawing.Point(56, 6);
            this._inputTB.Name = "_inputTB";
            this._inputTB.Size = new System.Drawing.Size(99, 21);
            this._inputTB.TabIndex = 1;
            this._inputTB.Text = "";
            // 
            // _submitBtn
            // 
            this._submitBtn.Location = new System.Drawing.Point(40, 62);
            this._submitBtn.Name = "_submitBtn";
            this._submitBtn.Size = new System.Drawing.Size(85, 23);
            this._submitBtn.TabIndex = 3;
            this._submitBtn.Text = "button1";
            this._submitBtn.UseVisualStyleBackColor = true;
            // 
            // _noteCB
            // 
            this._noteCB.AutoSize = true;
            this._noteCB.Location = new System.Drawing.Point(15, 33);
            this._noteCB.Name = "_noteCB";
            this._noteCB.Size = new System.Drawing.Size(80, 17);
            this._noteCB.TabIndex = 4;
            this._noteCB.Text = "checkBox1";
            this._noteCB.UseVisualStyleBackColor = true;
            // 
            // GoalModalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 97);
            this.Controls.Add(this._noteCB);
            this.Controls.Add(this._submitBtn);
            this.Controls.Add(this._inputTB);
            this.Controls.Add(this._goalLabel);
            this.Name = "GoalModalDialog";
            this.Text = "GoalModalDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _goalLabel;
        private System.Windows.Forms.RichTextBox _inputTB;
        private System.Windows.Forms.Button _submitBtn;
        private System.Windows.Forms.CheckBox _noteCB;
    }
}