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

        public Goal(string goalName)
        {
            _goalName = goalName;
            _currStreak = 0;
            _currDate = DateTime.Now;
            CreateGoalPanel();
        }

        /// <summary>
        /// Increments the streak of the goal by 1.
        /// </summary>
        public void IncreaseStreak()
        {
            _currStreak++;
        }

        /// <summary>
        /// Resets the streak counter to 0.
        /// </summary>
        public void Reset()
        {
            _currStreak = 0;
        }

        /// <summary>
        /// Create goal panel.
        /// </summary>
        private void CreateGoalPanel()
        {
            Color back1 = Color.FromArgb(39, 121, 149);
            Color textCol = Color.White;
            Size innerLabel = new Size(125, 23);

            // Create initial panel
            Panel newPanel = new Panel();
            newPanel.Name = $"_{_goalName}Panel";
            newPanel.Size = new Size(200, 100);
            newPanel.Location = new Point(210, 81);
            newPanel.BackColor = back1;
            newPanel.BorderStyle = BorderStyle.None;

            // Create header label
            Label headerLabel = new Label();
            headerLabel.Text = $"{_goalName}";
            headerLabel.Name = $"_{_goalName}Label";
            headerLabel.ForeColor = textCol;
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            headerLabel.BackColor = Color.FromArgb(28, 88, 108);
            headerLabel.BorderStyle = BorderStyle.None;
            headerLabel.AutoSize = false;
            headerLabel.Dock = DockStyle.Top;
            headerLabel.Size = new Size(200, 30);

            // Create increment button
            Button incBtn = new Button();
            incBtn.Text = $"Increment";
            incBtn.Name = $"_{_goalName}IncBtn";
            incBtn.BackColor = back1;
            incBtn.FlatStyle = FlatStyle.Flat;
            incBtn.FlatAppearance.BorderSize = 0;
            incBtn.ForeColor = textCol;
            incBtn.TextAlign = ContentAlignment.MiddleCenter;
            incBtn.Dock = DockStyle.Left;
            incBtn.Size = new Size(75, 70);

            // Create streak label
            Label streakLabel = new Label();
            streakLabel.Text = $"{_currStreak}";
            streakLabel.Name = $"_{_goalName}StreakLabel";
            streakLabel.ForeColor = textCol;
            streakLabel.TextAlign = ContentAlignment.MiddleCenter;
            streakLabel.BackColor = back1;
            streakLabel.BorderStyle = BorderStyle.None;
            streakLabel.AutoSize = false;
            streakLabel.Dock = DockStyle.Top;
            streakLabel.Size = innerLabel;

            // Create reset button
            Button resBtn = new Button();
            resBtn.Text = $"Reset";
            resBtn.Name = $"_{_goalName}ResetBtn";
            resBtn.BackColor = back1;
            resBtn.FlatStyle = FlatStyle.Flat;
            resBtn.FlatAppearance.BorderSize = 0;
            resBtn.ForeColor = textCol;
            resBtn.TextAlign = ContentAlignment.MiddleCenter;
            resBtn.Dock = DockStyle.Bottom;
            resBtn.Size = innerLabel;

            // Create datetime label
            Label dateLabel = new Label();
            dateLabel.Text = $"{_currDate}";
            dateLabel.Name = $"_{_goalName}DateLabel";
            dateLabel.ForeColor = textCol;
            dateLabel.TextAlign = ContentAlignment.MiddleCenter;
            dateLabel.BackColor = back1;
            dateLabel.BorderStyle = BorderStyle.None;
            dateLabel.AutoSize = false;
            dateLabel.Dock = DockStyle.Fill;
            dateLabel.Size = innerLabel;
        }
    }
}
