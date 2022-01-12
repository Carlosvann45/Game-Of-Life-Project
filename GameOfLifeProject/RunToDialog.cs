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
    public partial class RunToDialog : Form
    {
        public RunToDialog()
        {
            InitializeComponent();
        }

        public int RunToNum
        {
            get
            {
                return (int) runToNumericUpDown.Value;
            }
        }
    }
}
