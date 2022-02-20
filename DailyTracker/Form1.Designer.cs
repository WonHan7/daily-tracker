
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._categoryToolStrip = new System.Windows.Forms.ToolStrip();
            this._disciplineTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._newCatBtn = new System.Windows.Forms.ToolStripButton();
            this._newGoalBtn = new System.Windows.Forms.Button();
            this._disciplineFLP = new System.Windows.Forms.FlowLayoutPanel();
            this._categoryToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _categoryToolStrip
            // 
            this._categoryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._disciplineTool,
            this.toolStripSeparator1,
            this._newCatBtn});
            this._categoryToolStrip.Location = new System.Drawing.Point(0, 0);
            this._categoryToolStrip.Name = "_categoryToolStrip";
            this._categoryToolStrip.Size = new System.Drawing.Size(874, 25);
            this._categoryToolStrip.TabIndex = 0;
            this._categoryToolStrip.Text = "toolStrip1";
            // 
            // _disciplineTool
            // 
            this._disciplineTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._disciplineTool.Image = ((System.Drawing.Image)(resources.GetObject("_disciplineTool.Image")));
            this._disciplineTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._disciplineTool.Name = "_disciplineTool";
            this._disciplineTool.Size = new System.Drawing.Size(98, 22);
            this._disciplineTool.Text = "toolStripButton1";
            this._disciplineTool.ToolTipText = "Discipline";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _newCatBtn
            // 
            this._newCatBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._newCatBtn.Image = ((System.Drawing.Image)(resources.GetObject("_newCatBtn.Image")));
            this._newCatBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._newCatBtn.Name = "_newCatBtn";
            this._newCatBtn.Size = new System.Drawing.Size(23, 22);
            this._newCatBtn.Text = "toolStripButton1";
            // 
            // _newGoalBtn
            // 
            this._newGoalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._newGoalBtn.Location = new System.Drawing.Point(799, 0);
            this._newGoalBtn.Name = "_newGoalBtn";
            this._newGoalBtn.Size = new System.Drawing.Size(75, 25);
            this._newGoalBtn.TabIndex = 1;
            this._newGoalBtn.Text = "button1";
            this._newGoalBtn.UseVisualStyleBackColor = true;
            // 
            // _disciplineFLP
            // 
            this._disciplineFLP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this._disciplineFLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this._disciplineFLP.Location = new System.Drawing.Point(0, 25);
            this._disciplineFLP.Margin = new System.Windows.Forms.Padding(5);
            this._disciplineFLP.Name = "_disciplineFLP";
            this._disciplineFLP.Size = new System.Drawing.Size(874, 426);
            this._disciplineFLP.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 451);
            this.Controls.Add(this._disciplineFLP);
            this.Controls.Add(this._newGoalBtn);
            this.Controls.Add(this._categoryToolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this._categoryToolStrip.ResumeLayout(false);
            this._categoryToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _categoryToolStrip;
        private System.Windows.Forms.ToolStripButton _disciplineTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _newCatBtn;
        private System.Windows.Forms.Button _newGoalBtn;
        private System.Windows.Forms.FlowLayoutPanel _disciplineFLP;
    }
}

