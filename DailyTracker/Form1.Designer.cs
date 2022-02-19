
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
            this._categoryPanel = new System.Windows.Forms.Panel();
            this._newCatBtn = new System.Windows.Forms.Button();
            this._logoPanel = new System.Windows.Forms.Panel();
            this._testPanel = new System.Windows.Forms.Panel();
            this._resetBtn = new System.Windows.Forms.Button();
            this._dateLabel = new System.Windows.Forms.Label();
            this._streakLabel = new System.Windows.Forms.Label();
            this._incBtn = new System.Windows.Forms.Button();
            this._goalNamePanel = new System.Windows.Forms.Panel();
            this._goalLabel = new System.Windows.Forms.Label();
            this._headerPanel = new System.Windows.Forms.Panel();
            this._newGoalBtn = new System.Windows.Forms.Button();
            this._logo = new System.Windows.Forms.Label();
            this._categoryPanel.SuspendLayout();
            this._logoPanel.SuspendLayout();
            this._testPanel.SuspendLayout();
            this._goalNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _categoryPanel
            // 
            this._categoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(121)))), ((int)(((byte)(149)))));
            this._categoryPanel.Controls.Add(this._newCatBtn);
            this._categoryPanel.Controls.Add(this._logoPanel);
            this._categoryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._categoryPanel.Location = new System.Drawing.Point(0, 0);
            this._categoryPanel.Name = "_categoryPanel";
            this._categoryPanel.Size = new System.Drawing.Size(200, 611);
            this._categoryPanel.TabIndex = 0;
            // 
            // _newCatBtn
            // 
            this._newCatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this._newCatBtn.FlatAppearance.BorderSize = 0;
            this._newCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._newCatBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this._newCatBtn.Location = new System.Drawing.Point(0, 75);
            this._newCatBtn.Name = "_newCatBtn";
            this._newCatBtn.Size = new System.Drawing.Size(200, 60);
            this._newCatBtn.TabIndex = 1;
            this._newCatBtn.Text = "button1";
            this._newCatBtn.UseVisualStyleBackColor = true;
            // 
            // _logoPanel
            // 
            this._logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this._logoPanel.Controls.Add(this._logo);
            this._logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._logoPanel.Location = new System.Drawing.Point(0, 0);
            this._logoPanel.Name = "_logoPanel";
            this._logoPanel.Size = new System.Drawing.Size(200, 75);
            this._logoPanel.TabIndex = 0;
            // 
            // _testPanel
            // 
            this._testPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(121)))), ((int)(((byte)(149)))));
            this._testPanel.Controls.Add(this._resetBtn);
            this._testPanel.Controls.Add(this._dateLabel);
            this._testPanel.Controls.Add(this._streakLabel);
            this._testPanel.Controls.Add(this._incBtn);
            this._testPanel.Controls.Add(this._goalNamePanel);
            this._testPanel.Location = new System.Drawing.Point(206, 81);
            this._testPanel.Name = "_testPanel";
            this._testPanel.Size = new System.Drawing.Size(200, 100);
            this._testPanel.TabIndex = 1;
            // 
            // _resetBtn
            // 
            this._resetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._resetBtn.FlatAppearance.BorderSize = 0;
            this._resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._resetBtn.ForeColor = System.Drawing.Color.White;
            this._resetBtn.Location = new System.Drawing.Point(75, 77);
            this._resetBtn.Name = "_resetBtn";
            this._resetBtn.Size = new System.Drawing.Size(125, 23);
            this._resetBtn.TabIndex = 4;
            this._resetBtn.Text = "button2";
            this._resetBtn.UseVisualStyleBackColor = true;
            // 
            // _dateLabel
            // 
            this._dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(121)))), ((int)(((byte)(149)))));
            this._dateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._dateLabel.ForeColor = System.Drawing.Color.White;
            this._dateLabel.Location = new System.Drawing.Point(75, 53);
            this._dateLabel.Name = "_dateLabel";
            this._dateLabel.Size = new System.Drawing.Size(125, 23);
            this._dateLabel.TabIndex = 3;
            this._dateLabel.Text = "label2";
            this._dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _streakLabel
            // 
            this._streakLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._streakLabel.ForeColor = System.Drawing.Color.White;
            this._streakLabel.Location = new System.Drawing.Point(75, 30);
            this._streakLabel.Name = "_streakLabel";
            this._streakLabel.Size = new System.Drawing.Size(125, 23);
            this._streakLabel.TabIndex = 2;
            this._streakLabel.Text = "label1";
            this._streakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _incBtn
            // 
            this._incBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this._incBtn.FlatAppearance.BorderSize = 0;
            this._incBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._incBtn.ForeColor = System.Drawing.Color.White;
            this._incBtn.Location = new System.Drawing.Point(0, 30);
            this._incBtn.Name = "_incBtn";
            this._incBtn.Size = new System.Drawing.Size(75, 70);
            this._incBtn.TabIndex = 1;
            this._incBtn.Text = "button1";
            this._incBtn.UseVisualStyleBackColor = true;
            // 
            // _goalNamePanel
            // 
            this._goalNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this._goalNamePanel.Controls.Add(this._goalLabel);
            this._goalNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._goalNamePanel.Location = new System.Drawing.Point(0, 0);
            this._goalNamePanel.Name = "_goalNamePanel";
            this._goalNamePanel.Size = new System.Drawing.Size(200, 30);
            this._goalNamePanel.TabIndex = 0;
            // 
            // _goalLabel
            // 
            this._goalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._goalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._goalLabel.ForeColor = System.Drawing.Color.White;
            this._goalLabel.Location = new System.Drawing.Point(0, 0);
            this._goalLabel.Name = "_goalLabel";
            this._goalLabel.Size = new System.Drawing.Size(200, 30);
            this._goalLabel.TabIndex = 0;
            this._goalLabel.Text = "label1";
            this._goalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _headerPanel
            // 
            this._headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(121)))), ((int)(((byte)(149)))));
            this._headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._headerPanel.Location = new System.Drawing.Point(200, 0);
            this._headerPanel.Name = "_headerPanel";
            this._headerPanel.Size = new System.Drawing.Size(871, 75);
            this._headerPanel.TabIndex = 2;
            // 
            // _newGoalBtn
            // 
            this._newGoalBtn.FlatAppearance.BorderSize = 0;
            this._newGoalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._newGoalBtn.Image = global::DailyTracker.Properties.Resources.button;
            this._newGoalBtn.Location = new System.Drawing.Point(984, 530);
            this._newGoalBtn.Name = "_newGoalBtn";
            this._newGoalBtn.Size = new System.Drawing.Size(75, 69);
            this._newGoalBtn.TabIndex = 3;
            this._newGoalBtn.UseVisualStyleBackColor = true;
            // 
            // _logo
            // 
            this._logo.Dock = System.Windows.Forms.DockStyle.Left;
            this._logo.Image = global::DailyTracker.Properties.Resources._2904898431582960198_128;
            this._logo.Location = new System.Drawing.Point(0, 0);
            this._logo.Name = "_logo";
            this._logo.Size = new System.Drawing.Size(200, 75);
            this._logo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 611);
            this.Controls.Add(this._newGoalBtn);
            this.Controls.Add(this._headerPanel);
            this.Controls.Add(this._testPanel);
            this.Controls.Add(this._categoryPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this._categoryPanel.ResumeLayout(false);
            this._logoPanel.ResumeLayout(false);
            this._testPanel.ResumeLayout(false);
            this._goalNamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _categoryPanel;
        private System.Windows.Forms.Button _newCatBtn;
        private System.Windows.Forms.Panel _logoPanel;
        private System.Windows.Forms.Panel _testPanel;
        private System.Windows.Forms.Panel _goalNamePanel;
        private System.Windows.Forms.Label _goalLabel;
        private System.Windows.Forms.Panel _headerPanel;
        private System.Windows.Forms.Label _logo;
        private System.Windows.Forms.Button _resetBtn;
        private System.Windows.Forms.Label _dateLabel;
        private System.Windows.Forms.Label _streakLabel;
        private System.Windows.Forms.Button _incBtn;
        private System.Windows.Forms.Button _newGoalBtn;
    }
}

