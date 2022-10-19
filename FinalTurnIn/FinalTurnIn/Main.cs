using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTurnIn
{
    public partial class Main : Form
    {
        private static int myX, myY, timerIntervals = 1000, cells = 0, generations = 0;
        bool numbersOn = true, gridOn = true;
        // The universe array
        bool[,] universe = new bool[myX = 20, myY = 20];
        bool[,] newUniverse = new bool[myX, myY];
        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // Generation count

        public Main()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = timerIntervals; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    int count = CountNeighborsFinite(x, y);
                    if (universe[x, y])
                    {
                        if (count == 2 || count == 3)
                        {
                            newUniverse[x, y] = true;
                            break;
                        }
                        else if (count < 2 || count > 3)
                        {
                            newUniverse[x, y] = false;
                            break;
                        }
                    }
                    else
                    {
                        if (count == 3)
                        {
                            newUniverse[x, y] = true;
                            break;
                        }
                    }
                }
            }
            //bool[,] temp = universe;
            universe = newUniverse;
            //newUniverse = temp;
            graphicsPanel1.Invalidate();
            // Increment generation count
            generations++;
            cells = 0;
            int tr = 0;
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    if (universe[x, y] == true)
                    {
                        tr++;
                        cells++;

                        CellAlive.Text = "Alive: " + cells.ToString();
                        CellLabelHUD.Text = "Cell Count: " + cells.ToString();
                    }
                }
            }
            if (tr == 0)
            {
                CellAlive.Text = "Alive: 0";
                CellLabelHUD.Text = "Cell Count: " + cells.ToString();
            }



            // Update status strip generations
            GenerationCount.Text = "Generations: " + generations.ToString();
            GenerationLabelHUD.Text = "Generations: " + generations.ToString();
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void CellAlive_Click(object sender, EventArgs e)
        {

        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

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
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    Font font = new Font("Arial", 10f);
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    // Fill the cell with a brush if alive
                    if (CountNeighborsFinite(x, y) != 0 && numbersOn == true)
                    {
                        int neighbors = CountNeighborsFinite(x, y);
                        Rectangle rect = new Rectangle(cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                        if (neighbors < 2 || neighbors > 3)
                        {
                            e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Black, cellRect, stringFormat);
                        }
                        else if (neighbors == 2 || neighbors == 3)
                        {
                            e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Black, rect, stringFormat);
                        }

                    }
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                        if (CountNeighborsFinite(x, y) > 0 && numbersOn == true)
                        {
                            e.Graphics.DrawString(CountNeighborsFinite(x, y).ToString(), font, Brushes.Black, cellRect, stringFormat);
                        }
                    }

                    if (gridOn == true)
                    {
                        // Outline the cell with a pen
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                    }
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                timer.Enabled = true;
                PlayButton.Enabled = false;
                PauseButton.Enabled = true;
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                timer.Enabled = false;
                PlayButton.Enabled = true;
                PauseButton.Enabled = false;
            }
        }

        private int Check(int x, int y)
        {

            int count = 0;
            int w = graphicsPanel1.ClientSize.Width / universe.GetLength(0);// rows
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int h = graphicsPanel1.ClientSize.Height / universe.GetLength(1);// columns

            if ((x - 1 >= 0 && y - 1 > 0) && universe[x - 1, y - 1] == true)
                count++;
            if ((x - 1 >= 0) && universe[x - 1, y] == true)
                count++;
            if ((x - 1 >= 0 && y + 1 < h) && universe[x - 1, y + 1] == true)
                count++;
            if ((y - 1 >= 0) && universe[x, y - 1] == true)
                count++;
            if ((y + 1 < h) && universe[x, y + 1] == true)
                count++;
            if ((x + 1 < w && y - 1 >= 0) && universe[x + 1, y - 1] == true)
                count++;
            if ((x + 1 < w) && universe[x + 1, y] == true)
                count++;
            if ((x + 1 < w && y + 1 < h) && universe[x + 1, y + 1] == true)
                count++;

            return count;
        }

        private void GenerationCount_Click(object sender, EventArgs e)
        {

        }

        private void GridLineButton_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = ColorPicker.Color;
                gridColor = color;
                graphicsPanel1.Invalidate();
            }
        }

        private void GridCellButton_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = ColorPicker.Color;
                cellColor = color;
                graphicsPanel1.Invalidate();
            }
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = ColorPicker.Color;
                this.graphicsPanel1.BackColor = color;
                graphicsPanel1.Invalidate();
            }
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            Randomize();
        }

        private void NeighborCountShow_Click(object sender, EventArgs e)
        {
            if (numbersOn == true)
            {
                NeighborCountShow.Checked = false;
                numbersOn = false;
            }
            else if (numbersOn == false)
            {
                NeighborCountShow.Checked = true;
                numbersOn = true;
            }
            graphicsPanel1.Invalidate();
        }

        private void GridShow_Click(object sender, EventArgs e)
        {
            if (gridOn == true)
            {
                GridShow.Checked = false;
                gridOn = false;
                graphicsPanel1.Invalidate();
            }
            else if (gridOn == false)
            {
                GridShow.Checked = true;
                gridOn = true;
                graphicsPanel1.Invalidate();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            generations = 0;
            GenerationCount.Text = "Generations: " + generations.ToString();
            GenerationLabelHUD.Text = "Generations: " + generations.ToString();
            Clear();
            gridColor = Color.Black;
            cellColor = Color.Gray;
            this.graphicsPanel1.BackColor = Color.White;
            numbersOn = true;
            bool[,] editedUniverse = new bool[20, 20];
            bool[,] temp = universe;
            universe = editedUniverse;
            newUniverse = editedUniverse;
            editedUniverse = temp;
            UniverseSizeLabelHUD.Text = "Universe Size: {20, 20}";
            timer.Interval = timerIntervals;
            generations = 0;
            GenerationCount.Text = "Generations: 0";
            GenerationLabelHUD.Text = "Generations: 0";

            //gridOn = true;
            graphicsPanel1.Invalidate();
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            OptionsMenu om = new OptionsMenu();
            om.ShowDialog();
            bool[,] editedUniverse = new bool[OptionsMenu.xf2, OptionsMenu.yf2];
            bool[,] temp = universe;
            universe = editedUniverse;
            newUniverse = editedUniverse;
            editedUniverse = temp;
            UniverseSizeLabelHUD.Text = "Universe Size: {" + OptionsMenu.xf2.ToString() + "," + OptionsMenu.yf2.ToString() + "}";
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    universe[x, y] = false;
                    graphicsPanel1.Invalidate();
                }
            }
            cells = 0;
            CellAlive.Text = "Alive: 0";
            CellLabelHUD.Text = "Cell Count: 0";
            graphicsPanel1.Invalidate();

            //timerIntervals = OptionsMenu.timec;
            //graphicsPanel1.Invalidate();
        }

        private void GenerationLabelHUD_Click(object sender, EventArgs e)
        {
            
        }

        public bool[,] GetGrid()
        {
            return newUniverse;
        }
        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;

                if (universe[x, y] == false)
                {
                    cells++;
                    CellAlive.Text = "Alive: " + cells.ToString();
                    CellLabelHUD.Text = "Cell Count: " + cells.ToString();
                }
                else
                {
                    cells--;
                    CellAlive.Text = "Alive: " + cells.ToString();
                    CellLabelHUD.Text = "Cell Count: " + cells.ToString();
                }
                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
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

                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }

                    else if (xCheck < 0)
                    {
                        continue;
                    }
                    else if (yCheck < 0)
                    {
                        continue;
                    }
                    else if (xCheck >= xLen)
                    {
                        continue;
                    }
                    else if (yCheck >= yLen)
                    {
                        continue;
                    }
                    if (universe[xCheck, yCheck] == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private void Clear()
        {
            string message = "Are you sure you want to clear the grid?";
            string title = "Clear grid";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    for (int y = 0; y < universe.GetLength(1); y++)
                    {
                        universe[x, y] = false;
                        graphicsPanel1.Invalidate();
                    }
                }
                cells = 0;
                CellAlive.Text = "Alive: 0";
                CellLabelHUD.Text = "Cell Count: 0";
            }
            else
            {

            }
        }
        private void Randomize()
        {
            Random rand = new Random();
            int x = rand.Next(0, universe.GetLength(0));
            int y = rand.Next(0, universe.GetLength(1));
            universe[x, y] = !universe[x, y];
            graphicsPanel1.Invalidate();
        }
        
    }
}
