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
    public partial class OptionsDialog : Form
    {
        public OptionsDialog()
        {
            InitializeComponent();
        }

        public int TimerInterval
        {
            get
            {
                return (int) timerIntervalNumericUpDown.Value;
            }

            set
            {
                timerIntervalNumericUpDown.Value = value;
            }
        }

        public int ArrayWidth
        {
            get
            {
                return (int) universeWidthNumericUpDown.Value;
            }

            set
            {
                universeWidthNumericUpDown.Value = value;
            }
        }

        public int ArrayHeight
        {
            get
            {
                return (int) universeHeightNumericUpDown.Value;
            }

            set
            {
                universeHeightNumericUpDown.Value = value;
            }
        }
    }
}
