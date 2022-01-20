using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeProject
{
    /// <summary>
    /// dialog class that generates or shows the current random seed to generate a random grid
    /// </summary>
    public partial class SeedDialog : Form
    {
        public SeedDialog()
        {
            InitializeComponent();
            randomNumericUpDown.Maximum = decimal.MaxValue;
            randomNumericUpDown.Minimum = decimal.MinValue;
        }

        public int RandomSeed
        {
            get
            {
                return (int)randomNumericUpDown.Value;
            }

            set
            {
                randomNumericUpDown.Value = value;
            }
        }

        /// <summary>
        /// generates a random seed on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randomizeButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());

            randomNumericUpDown.Value = rand.Next();
        }
    }
}
