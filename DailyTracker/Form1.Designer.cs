
namespace DailyTracker
{
    partial class Form1
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
            this._goalCategory = new System.Windows.Forms.Panel();
            this._logo = new System.Windows.Forms.Panel();
            this._addNewGoal = new System.Windows.Forms.Button();
            this._goalCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // _goalCategory
            // 
            this._goalCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this._goalCategory.Controls.Add(this._addNewGoal);
            this._goalCategory.Controls.Add(this._logo);
            this._goalCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this._goalCategory.Location = new System.Drawing.Point(0, 0);
            this._goalCategory.Name = "_goalCategory";
            this._goalCategory.Size = new System.Drawing.Size(200, 521);
            this._goalCategory.TabIndex = 0;
            // 
            // _logo
            // 
            this._logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this._logo.Dock = System.Windows.Forms.DockStyle.Top;
            this._logo.Location = new System.Drawing.Point(0, 0);
            this._logo.Name = "_logo";
            this._logo.Size = new System.Drawing.Size(200, 75);
            this._logo.TabIndex = 0;
            // 
            // _addNewGoal
            // 
            this._addNewGoal.Dock = System.Windows.Forms.DockStyle.Top;
            this._addNewGoal.FlatAppearance.BorderSize = 0;
            this._addNewGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addNewGoal.ForeColor = System.Drawing.Color.Gainsboro;
            this._addNewGoal.Location = new System.Drawing.Point(0, 75);
            this._addNewGoal.Name = "_addNewGoal";
            this._addNewGoal.Size = new System.Drawing.Size(200, 60);
            this._addNewGoal.TabIndex = 1;
            this._addNewGoal.Text = "button1";
            this._addNewGoal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 521);
            this.Controls.Add(this._goalCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this._goalCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _goalCategory;
        private System.Windows.Forms.Button _addNewGoal;
        private System.Windows.Forms.Panel _logo;
    }
}

