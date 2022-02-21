/// Author: Wonseok Han
/// This class manages the functionalities of the individual category tabs
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
    class Category
    {
        private ToolStrip _ts = null;           // New ToolStrip to display all categories
        private FlowLayoutPanel _catFLP = null; // New FlowLayoutPanel for each category

        public Category(List<Category> catList)
        {
            _ts = new ToolStrip();
            _catFLP = new FlowLayoutPanel();
            SetTS(catList);
            SetFLP();
        }

        /// <summary>
        /// Helper method to set properties of the ToolStrip
        /// </summary>
        private void SetTS(List<Category> catList)
        {
            _ts.Dock = DockStyle.Top;
            //_ts.Items.Add(new ToolStripItem());
            //_disciplineTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            //_disciplineTool.Text = $"Discipline";
        }

        /// <summary>
        /// Helper method to set properties of the Category FLP
        /// </summary>
        private void SetFLP()
        {
            _catFLP.Dock = DockStyle.Fill;
            _catFLP.FlowDirection = FlowDirection.LeftToRight;
            _catFLP.AutoScroll = true;
        }

        /// <summary>
        /// Load all Goal objects inside the category
        /// </summary>
        /// <param name="goalList"></param>
        public static void LoadCategory(List<Goal> goalList)
        {
            // Load all Goals inside the category

        }
    }
}
