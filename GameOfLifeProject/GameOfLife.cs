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
    public partial class GameOfLife : Form
    {
        // The universe array
        bool[,] universe = new bool[30, 30];
        bool[,] scratchPad = new bool[30, 30];

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public GameOfLife()
        {
            InitializeComponent();
            //sets title
            this.Text = "Game Of Life";

            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            int neighborCount;

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    neighborCount = CountNeighborsFinite(x, y);

                    if (universe[x,y])
                    {
                        if (neighborCount < 2) scratchPad[x, y] = false;

                        if (neighborCount > 3) scratchPad[x, y] = false;

                        if (neighborCount == 2 || neighborCount == 3) scratchPad[x, y] = true;
                    }
                    else
                    {
                            if (neighborCount == 3) scratchPad[x, y] = true;
                        
                    }
                }
            }
 
            universe = scratchPad;
            scratchPad = new bool[30, 30];

            // Increment generation count
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();

            graphicsPanel1.Invalidate();
        }

        private int CountNeighborsFinite(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);

            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;

                    // if xOffset and yOffset are both equal to 0 then continue
                    if (xOffset == 0 && yOffset == 0) continue;
                    // if xCheck is less than 0 then continue
                    if (xCheck < 0) continue;
                    // if yCheck is less than 0 then continue
                    if (yCheck < 0) continue;
                    // if xCheck is greater than or equal too xLen then continue
                    if (xCheck >= xLen) continue;
                    // if yCheck is greater than or equal too yLen then continue
                    if (yCheck >= yLen) continue;

                    if (universe[xCheck, yCheck] == true) count++;
                }
            }
            return count;
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            double cellWidth = (double)graphicsPanel1.ClientSize.Width / (double)universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            double cellHeight = (double)graphicsPanel1.ClientSize.Height / (double)universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = x * (float)cellWidth;
                    cellRect.Y = y * (float)cellHeight;
                    cellRect.Width = (float)cellWidth;
                    cellRect.Height = (float)cellHeight;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
                float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);


                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = (int)Math.Floor(e.X / cellWidth);
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = (int)Math.Floor(e.Y / cellHeight);

                // Toggle the cell's state
                try
                {
                    universe[x, y] = !universe[x, y];
                }
                catch
                {
                    //prevent click outside of grid from crashing game
                }


                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        private void toolStripStatusLabelGenerations_Click(object sender, EventArgs e)
        {

        }

        private void playToolStripButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void pauseToolStripButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void nextToolStripButton_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            universe = new bool[30, 30];
            scratchPad = new bool[30, 30];

            graphicsPanel1.Invalidate();
        }
    }
}

