using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeProject
{
    /// <summary>
    /// graphics panel to display cell universe
    /// </summary>
    class GraphicsPanel : Panel
    {
        public GraphicsPanel()
        {
            this.DoubleBuffered = true;

            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }
}
