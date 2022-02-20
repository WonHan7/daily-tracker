/// Author: Wonseok Han
/// This class manages the functionalities of the individual goal panels
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
    class Goal
    {
        private DateTime _currDate;                     // Current DateTime to be displayed

        public int _currStreak { get; private set; }    // Current longest streak to be displayed
        public string _goalName { get; private set; }   // Goal name of the chosen panel

        public Goal(string goalName, Form form)
        {
            _goalName = goalName;
            _currStreak = 0;
            _currDate = DateTime.Now;
            CreateGoalPanel(form);
        }

        /// <summary>
        /// Increments the streak of the goal by 1.
        /// </summary>
        public void IncreaseStreak()
        {
            _currStreak++;
            _currDate = DateTime.Now;
        }

        /// <summary>
        /// Resets the streak counter to 0.
        /// </summary>
        public void Reset()
        {
            _currStreak = 0;
            _currDate = DateTime.Now;
        }

        /// <summary>
        /// Create goal panel.
        /// </summary>
        private void CreateGoalPanel(Form form)
        {
            const int WIDTH = 200;
            const int HEIGHT_LAB = 50;
            Color mainBack = Color.Black;
            Color font = Color.White;

            // Create initial panel
            Panel newPanel = new Panel();
            newPanel.Name = $"_{_goalName}Panel";
            newPanel.Size = new Size(WIDTH, 200);
            newPanel.Location = new Point(15, 35);
            newPanel.BackColor = mainBack;
            newPanel.BorderStyle = BorderStyle.FixedSingle;

            // Create streak label
            Label streakLabel = new Label();
            streakLabel.Text = $"{_currStreak}";
            streakLabel.Name = $"_{_goalName}StreakLabel";
            streakLabel.ForeColor = font;
            streakLabel.TextAlign = ContentAlignment.MiddleCenter;
            streakLabel.BackColor = mainBack;
            streakLabel.BorderStyle = BorderStyle.None;
            streakLabel.AutoSize = false;
            streakLabel.Dock = DockStyle.Left;
            newPanel.Controls.Add(streakLabel);

            // Create increment button
            Button incBtn = new Button();
            incBtn.Text = $"Log";
            incBtn.Name = $"_{_goalName}LogBtn";
            incBtn.BackColor = mainBack;
            incBtn.FlatStyle = FlatStyle.Flat;
            incBtn.FlatAppearance.BorderSize = 0;
            incBtn.ForeColor = font;
            incBtn.TextAlign = ContentAlignment.MiddleCenter;
            incBtn.Dock = DockStyle.Right;
            newPanel.Controls.Add(incBtn);

            // Create header label
            Label headerLabel = new Label();
            headerLabel.Text = $"{_goalName}";
            headerLabel.Name = $"_{_goalName}Label";
            headerLabel.ForeColor = font;
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            headerLabel.BorderStyle = BorderStyle.None;
            headerLabel.AutoSize = false;
            headerLabel.Dock = DockStyle.Top;
            headerLabel.Size = new Size(WIDTH, 30);
            newPanel.Controls.Add(headerLabel);

            // Create datetime label
            Label dateLabel = new Label();
            dateLabel.Text = $"{_currDate}";
            dateLabel.Name = $"_{_goalName}DateLabel";
            dateLabel.ForeColor = font;
            dateLabel.TextAlign = ContentAlignment.MiddleCenter;
            dateLabel.BackColor = mainBack;
            dateLabel.BorderStyle = BorderStyle.None;
            dateLabel.AutoSize = false;
            dateLabel.Dock = DockStyle.Bottom;
            dateLabel.Size = new Size(WIDTH, HEIGHT_LAB);
            newPanel.Controls.Add(dateLabel);

            // Create reset button
            Button resBtn = new Button();
            resBtn.Text = $"Reset";
            resBtn.Name = $"_{_goalName}ResetBtn";
            resBtn.BackColor = mainBack;
            resBtn.FlatStyle = FlatStyle.Flat;
            resBtn.FlatAppearance.BorderSize = 0;
            resBtn.ForeColor = font;
            resBtn.TextAlign = ContentAlignment.MiddleCenter;
            resBtn.Dock = DockStyle.Bottom;
            resBtn.Size = new Size(WIDTH, 30);
            newPanel.Controls.Add(resBtn);

            form.Controls.Add(newPanel);
        }
    }
}
