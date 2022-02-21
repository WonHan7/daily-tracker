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
        private Panel _goalPanel;                       // Panel that contains all UI elements of a Goal instance
        private Label _streakLabel;                     // Label that displays current streak
        private Label _dateLabel;                       // Label that displays current date
        private DateTime _currDate;                     // Current DateTime to be displayed
        public bool _note { get; set; }                 // Determines whether the goal has a note component
        public int _currStreak { get; private set; }    // Current longest streak to be displayed
        public string _goalName { get; private set; }   // Goal name of the chosen panel

        public Goal(string goalName)
        {
            _goalName = goalName;
            _currStreak = 0;
            _note = false;
            _currDate = DateTime.Now;

            // UI Properties
            SetPanel();
            SetStreak();
            SetDate();
        }

        /// <summary>
        /// Sets the properties for Panel of the Goal instance
        /// </summary>
        private void SetPanel()
        {
            // Create initial panel
            _goalPanel = new Panel();
            _goalPanel.Name = $"_{_goalName}Panel";
            _goalPanel.Size = new Size(200, 200);
            _goalPanel.BackColor = Color.Black;
            _goalPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Sets the properties for streak Label
        /// </summary>
        private void SetStreak()
        {
            _streakLabel = new Label();
            _streakLabel.Text = $"{_currStreak}";
            _streakLabel.Name = $"_{_goalName}StreakLabel";
            _streakLabel.ForeColor = Color.White;
            _streakLabel.BackColor = Color.Black;
            _streakLabel.AutoSize = false;
            _streakLabel.Size = new Size(200 / 2, 200 / 6);
            _streakLabel.TextAlign = ContentAlignment.MiddleCenter;
            _streakLabel.BorderStyle = BorderStyle.None;
            _streakLabel.Dock = DockStyle.Left;
        }

        /// <summary>
        /// Sets the properties for date Label
        /// </summary>
        private void SetDate()
        {
            _dateLabel = new Label();
            _dateLabel.Text = $"{_currDate}";
            _dateLabel.Name = $"_{_goalName}DateLabel";
            _dateLabel.ForeColor = Color.White;
            _dateLabel.BackColor = Color.Black;
            _dateLabel.AutoSize = false;
            _dateLabel.TextAlign = ContentAlignment.MiddleCenter;
            _dateLabel.BorderStyle = BorderStyle.None;
            _dateLabel.Dock = DockStyle.Bottom;
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
        public static Panel CreateGoalPanel(Object arg, List<Goal> goalList, FlowLayoutPanel flp)
        {
            const int WIDTH = 200;
            const int HEIGHT = 200;
            Color mainBack = Color.Black;
            Color font = Color.White;

            if (!(arg is Goal g))
                throw new ArgumentException($"Goal:CreateGoalPanel:{nameof(arg)} - Not a valid Goal!");

            // Create increment button
            Button incBtn = new Button();
            incBtn.Text = $"Log";
            //incBtn.Name = $"_{g._goalName}LogBtn";
            incBtn.Name = $"{g._goalName}";
            incBtn.ForeColor = font;
            incBtn.BackColor = Color.Green;
            incBtn.Size = new Size(WIDTH / 2, HEIGHT / 6);
            incBtn.FlatStyle = FlatStyle.Flat;
            incBtn.FlatAppearance.BorderSize = 0;
            incBtn.TextAlign = ContentAlignment.MiddleCenter;
            incBtn.Dock = DockStyle.Right;
            incBtn.Click += (s, e) => {
                Button button = s as Button;
                goalList.Find((tg) => button.Name == tg._goalName)._currStreak++;
                g._streakLabel.Text = $"{g._currStreak}";
            };
            g._goalPanel.Controls.Add(incBtn);

            // Add streak label to Panel
            g._goalPanel.Controls.Add(g._streakLabel);

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
            g._goalPanel.Controls.Add(headerLabel);

            // Create note textbox
            if (g._note)
            {
                RichTextBox noteTB = new RichTextBox();
                noteTB.Text = $"Enter your best time!";
                noteTB.Name = $"_{g._goalName}noteTB";
                noteTB.ForeColor = font;
                noteTB.BackColor = Color.Gray;
                noteTB.AutoSize = false;
                noteTB.Size = new Size(WIDTH / 2, HEIGHT / 6);
                noteTB.BorderStyle = BorderStyle.None;
                noteTB.Dock = DockStyle.Bottom;
                g._goalPanel.Controls.Add(noteTB);
            }

            // Create datetime label
            g._goalPanel.Controls.Add(g._dateLabel);

            // Create reset button
            Button resBtn = new Button();
            resBtn.Text = $"Reset";
            //resBtn.Name = $"_{g._goalName}ResetBtn";
            resBtn.Name = $"{g._goalName}";
            resBtn.ForeColor = font;
            resBtn.BackColor = Color.Orange;
            resBtn.FlatStyle = FlatStyle.Flat;
            resBtn.FlatAppearance.BorderSize = 0;
            resBtn.TextAlign = ContentAlignment.MiddleCenter;
            resBtn.Dock = DockStyle.Bottom;
            resBtn.Click += (s, e) => {
                Button button = s as Button;
                goalList.Find((tg) => button.Name == tg._goalName)._currStreak = 0;
                g._streakLabel.Text = $"{g._currStreak}";
            };
            g._goalPanel.Controls.Add(resBtn);

            // Create remove button
            Button delBtn = new Button();
            delBtn.Text = $"Remove";
            //delBtn.Name = $"_{g._goalName}RemoveBtn";
            delBtn.Name = $"{g._goalName}";
            delBtn.ForeColor = font;
            delBtn.BackColor = Color.Red;
            delBtn.FlatStyle = FlatStyle.Flat;
            delBtn.FlatAppearance.BorderSize = 0;
            delBtn.TextAlign = ContentAlignment.MiddleCenter;
            delBtn.Dock = DockStyle.Bottom;
            delBtn.Click += (s, e) => {
                Button button = s as Button;
                flp.Controls.Remove(g._goalPanel);
                goalList.Remove(g);
            };
            g._goalPanel.Controls.Add(delBtn);

            return g._goalPanel;
        }
    }
}
