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
        /// 
        /// </summary>
        /// <param name="form">The form for the Goal object to be created on.</param>
        /// <param name="g">The Goal object to be created.</param>
        public static Panel CreateGoalPanel(Object arg)
        {
            const int WIDTH = 200;
            const int HEIGHT = 200;
            Color mainBack = Color.Black;
            Color font = Color.White;

            if (!(arg is Goal g))
                throw new ArgumentException($"Goal:CreateGoalPanel:{nameof(arg)} - Not a valid Goal!");

            // Create initial panel
            Panel newPanel = new Panel();
            newPanel.Name = $"_{g._goalName}Panel";
            newPanel.Size = new Size(WIDTH, HEIGHT);
            newPanel.BackColor = mainBack;
            newPanel.BorderStyle = BorderStyle.FixedSingle;

            // Create increment button
            Button incBtn = new Button();
            incBtn.Text = $"Log";
            incBtn.Name = $"_{g._goalName}LogBtn";
            incBtn.ForeColor = font;
            incBtn.BackColor = Color.Green;
            incBtn.Size = new Size(WIDTH / 2, HEIGHT / 3);
            incBtn.FlatStyle = FlatStyle.Flat;
            incBtn.FlatAppearance.BorderSize = 0;
            incBtn.TextAlign = ContentAlignment.MiddleCenter;
            incBtn.Dock = DockStyle.Right;
            newPanel.Controls.Add(incBtn);

            // Create streak label
            Label streakLabel = new Label();
            streakLabel.Text = $"{g._currStreak}";
            streakLabel.Name = $"_{g._goalName}StreakLabel";
            streakLabel.ForeColor = font;
            streakLabel.BackColor = mainBack;
            streakLabel.AutoSize = false;
            streakLabel.Size = new Size(WIDTH / 2, HEIGHT / 3);
            streakLabel.TextAlign = ContentAlignment.MiddleCenter;
            streakLabel.BorderStyle = BorderStyle.None;
            streakLabel.Dock = DockStyle.Left;
            newPanel.Controls.Add(streakLabel);

            // Create header label
            Label headerLabel = new Label();
            headerLabel.Text = $"{g._goalName}";
            headerLabel.Name = $"_{g._goalName}Label";
            headerLabel.ForeColor = font;
            headerLabel.BackColor = mainBack;
            headerLabel.AutoSize = false;
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            headerLabel.BorderStyle = BorderStyle.None;
            headerLabel.Dock = DockStyle.Top;
            newPanel.Controls.Add(headerLabel);

            // Create datetime label
            Label dateLabel = new Label();
            dateLabel.Text = $"{g._currDate}";
            dateLabel.Name = $"_{g._goalName}DateLabel";
            dateLabel.ForeColor = font;
            dateLabel.BackColor = mainBack;
            dateLabel.AutoSize = false;
            dateLabel.TextAlign = ContentAlignment.MiddleCenter;
            dateLabel.BorderStyle = BorderStyle.None;
            dateLabel.Dock = DockStyle.Bottom;
            newPanel.Controls.Add(dateLabel);

            // Create reset button
            Button resBtn = new Button();
            resBtn.Text = $"Reset";
            resBtn.Name = $"_{g._goalName}ResetBtn";
            resBtn.ForeColor = font;
            resBtn.BackColor = Color.Red;
            resBtn.FlatStyle = FlatStyle.Flat;
            resBtn.FlatAppearance.BorderSize = 0;
            resBtn.TextAlign = ContentAlignment.MiddleCenter;
            resBtn.Dock = DockStyle.Bottom;
            newPanel.Controls.Add(resBtn);

            return newPanel;
        }
    }
}
