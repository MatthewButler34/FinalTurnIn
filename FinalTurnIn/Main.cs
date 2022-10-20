using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalTurnIn
{
    public partial class Main : Form
    {
        private static int myX, myY, timerIntervals = 1000, cells = 0, generations = 0; //myX and myY are the dimensions, timerIntervals controls the time between each generation, cells and generations are the # of active cells and generations in the universe
        bool numbersOn = true, gridOn = true, isTor = false;//numbersOn controls the numbers displayed, gridOn controls the lines on the grid, and isTor controls whether the universe is played in Toroidal or Finite
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
                    if (isTor == true)
                    {
                        int count = CountNeighborsToroidal(x, y);

                        if (universe[x, y])
                        {
                            if (count == 2 || count == 3)
                            {
                                newUniverse[x, y] = true;
                            }
                            else if (count < 2 || count > 3)
                            {
                                newUniverse[x, y] = false;
                            }
                        }
                        else if (universe[x, y] == false)
                        {
                            if (count == 3)
                            {
                                newUniverse[x, y] = true;
                            }
                        }
                        else
                        {
                            if (count == 3)
                            {
                                newUniverse[x, y] = true;
                            }
                        }
                    }
                    if (isTor == false)
                    {

                        int count = CountNeighborsFinite(x, y);

                        if (universe[x, y])
                        {
                            if (count == 2 || count == 3)
                            {
                                newUniverse[x, y] = true;
                            }
                            else if (count < 2 || count > 3)
                            {
                                newUniverse[x, y] = false;
                            }
                        }
                        else if (!universe[x, y])
                        {
                            if (count == 3)
                            {
                                newUniverse[x, y] = true;
                            }
                        }
                        else
                        {
                            if (count == 3)
                            {
                                newUniverse[x, y] = true;
                            }
                        }
                    }

                }
            }
            //Swapping the universe
            bool[,] temp = universe;
            universe = newUniverse;
            newUniverse = temp;
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
                CellAlive.Text = "Alive: 0";// For *all* of the lines that contain ".Text" This changes the amount of the text of the cells, generations, and HUD
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

        }//Empty

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
                    if (isTor == true)
                    {
                        if (CountNeighborsToroidal(x, y) != 0 && numbersOn == true)
                        {
                            int neighbors = CountNeighborsToroidal(x, y);
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
                            if (CountNeighborsToroidal(x, y) > 0 && numbersOn == true)
                            {
                                e.Graphics.DrawString(CountNeighborsToroidal(x, y).ToString(), font, Brushes.Black, cellRect, stringFormat);
                            }
                        }
                    }
                    else if (isTor == false)//Switches between Finite and Toroidal
                    {
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
        }//Controls paint of the grid
        public bool[,] GetGrid()//returns newUniverse
        {
            return newUniverse;
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                timer.Enabled = true;
                PlayButton.Enabled = false;
                PauseButton.Enabled = true;
            }
        }//Plays the grid

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                timer.Enabled = false;
                PlayButton.Enabled = true;
                PauseButton.Enabled = false;
            }
        }//Pauses the grid

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
        }//Unused

        private void GenerationCount_Click(object sender, EventArgs e)
        {

        }//Empty

        private void GridLineButton_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = ColorPicker.Color;
                gridColor = color;
                graphicsPanel1.Invalidate();
            }
        }//Changes color of Gridline

        private void GridCellButton_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = ColorPicker.Color;
                cellColor = color;
                graphicsPanel1.Invalidate();
            }
        }//Changes color of Grid Cell

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = ColorPicker.Color;
                this.graphicsPanel1.BackColor = color;
                graphicsPanel1.Invalidate();
            }
        }//Changes the color of the background

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            Randomize();
        }//Randomizes the universe

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
        }//Turns the number display on and off

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
        }//Turns the grid display on and off

        private void NextButton_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }//Displays the next generation

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }//Clears the grid

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
            HUDButton.Checked = true;
            GenerationLabelHUD.Visible = true;
            CellLabelHUD.Visible = true;
            BoundaryTypeHUD.Visible = true;
            UniverseSizeLabelHUD.Visible = true;
            //gridOn = true;
            graphicsPanel1.Invalidate();
        }//Resets the grid back to its base level

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            OptionsMenu om = new OptionsMenu();
            om.ShowDialog();//Shows options dialog
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
            //timer.Interval = OptionsMenu.timec;//Not finished
            cells = 0;
            CellAlive.Text = "Alive: 0";
            CellLabelHUD.Text = "Cell Count: 0";
            graphicsPanel1.Invalidate();

            timer.Interval = OptionsMenu.timec;
        }//Controls what happens after the "done" button is pressed on the options dialog

        private void GenerationLabelHUD_Click(object sender, EventArgs e)
        {
            
        }//Empty

        private void HUDButton_Click(object sender, EventArgs e)
        {
            if (HUDButton.Checked == true)
            {
                HUDButton.Checked = false;
                GenerationLabelHUD.Visible = false;
                CellLabelHUD.Visible = false;
                BoundaryTypeHUD.Visible = false;
                UniverseSizeLabelHUD.Visible = false;
                GenHUDToggle.Checked = false;
                CellCountHUDToggle.Checked = false;
                BoundaryTypeHUDToggle.Checked = false;
                UniverseSizeHUDToggle.Checked = false;
            }
            else if (HUDButton.Checked == false)
            {
                HUDButton.Checked = true;
                GenerationLabelHUD.Visible = true;
                CellLabelHUD.Visible = true;
                BoundaryTypeHUD.Visible = true;
                UniverseSizeLabelHUD.Visible = true;
                GenHUDToggle.Checked = true;
                CellCountHUDToggle.Checked = true;
                BoundaryTypeHUDToggle.Checked = true;
                UniverseSizeHUDToggle.Checked = true;
            }
        }//Turns HUD on and off

        private void CellLabelHUD_Click(object sender, EventArgs e)
        {

        }//Empty

        private void ToroidalButton_Click(object sender, EventArgs e)
        {
            if (ToroidalButton.Checked == false)
            {
                ToroidalButton.Checked = true;
                FiniteButton.Checked = false;
                isTor = true;
                BoundaryTypeHUD.Text = "Boundary Type: Toroidal";
                graphicsPanel1.Invalidate();
            }
            
        }//Sets grid to Toroidal

        private void FiniteButton_Click(object sender, EventArgs e)//Sets grid to Finite
        {
            if (FiniteButton.Checked == false)
            {
                FiniteButton.Checked = true;
                ToroidalButton.Checked = false;
                isTor = false;
                BoundaryTypeHUD.Text = "Boundary Type: Finite";
                graphicsPanel1.Invalidate();
            }
            
        }//Sets grid to Finite

        private void GenHUDToggle_Click(object sender, EventArgs e)
        {
            if (GenHUDToggle.Checked == true)
            {
                GenHUDToggle.Checked = false;
                GenerationLabelHUD.Visible = false;
            }
            else if (GenHUDToggle.Checked == false)
            {
                GenHUDToggle.Checked = true;
                GenerationLabelHUD.Visible = true;
            }
        }//Turns Generation HUD on and off

        private void CellCountHUDToggle_Click(object sender, EventArgs e)
        {
            if (CellCountHUDToggle.Checked == true)
            {
                CellCountHUDToggle.Checked = false;
                CellLabelHUD.Visible = false;
            }
            else if (CellCountHUDToggle.Checked == false)
            {
                CellCountHUDToggle.Checked = true;
                CellLabelHUD.Visible = true;
            }
        }//Turns cell count HUD on and off

        private void BoundaryTypeHUDToggle_Click(object sender, EventArgs e)
        {
            if (BoundaryTypeHUDToggle.Checked == true)
            {
                BoundaryTypeHUDToggle.Checked = false;
                BoundaryTypeHUD.Visible = false;
            }
            else if (BoundaryTypeHUDToggle.Checked == false)
            {
                BoundaryTypeHUDToggle.Checked = true;
                BoundaryTypeHUD.Visible = true;
            }
        }//Turns Boundary Type on and off

        private void SaveFile()
        {
            int x = 0;
            int y = 0;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.DefaultExt = "cells";

            saveFileDialog1.Title = "Saving The Universe.";

            saveFileDialog1.Filter = "Cells and texts Files (*.txt),(*.cells)|*.txt,*.cells|All files (*.*)|*.*";



            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                sw.WriteLine("!Name: " + Path.GetFileNameWithoutExtension(saveFileDialog1.FileName));
                sw.WriteLine("!");


                for (y = 0; y < universe.GetLength(1); y++)
                {

                    if (y > 0)
                    {
                        sw.WriteLine();
                    }



                    for (x = 0; x < universe.GetLength(0); x++)
                    {



                        if (universe[x, y] == false)
                        {
                            sw.Write(".");
                        }

                        else
                        {
                            sw.Write("O");
                        }
                    }

                }


                sw.Close();

            }
        }//Saves grid to .txt file

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }//Saves grid
        private void OpenFile()
        {
            string line = "";
            int counterY = 0;
            int lineX = 0;

            OpenFileDialog openfile = new OpenFileDialog();

            openfile.DefaultExt = "cells";

            openfile.Title = "Opening the Universe.";

            openfile.Filter = "cells files (*.cells)|*.cells|Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            openfile.CheckPathExists = true;


            if (openfile.ShowDialog() == DialogResult.OK)
            {
                Stream s = new MemoryStream();
                StreamReader sr = new StreamReader(openfile.FileName);


                while ((line = sr.ReadLine()) != null)
                {
                    if (line[0] == '!')
                    {
                        continue;
                    }

                    else if (line[1] == '!')
                    {
                        continue;
                    }

                    lineX = line.Length;


                    counterY++;
                }


                sr.Close();


                universe = new bool[lineX, counterY];
                newUniverse = new bool[lineX, counterY];


                lineX--;
                counterY = 0;


                StreamReader st = new StreamReader(openfile.FileName);

                while ((line = st.ReadLine()) != null)
                {
                    if (line[0] == '!')
                    {
                        continue;
                    }


                    for (int x = 0; x < lineX; x++)
                    {

                        if (line[x] == '.')
                        {
                            universe[x, counterY] = false;
                        }

                        else if (line[x] == 'O')
                        {
                            universe[x, counterY] = true;
                        }

                    }

                    counterY++;



                }
                st.Close();

            }


            graphicsPanel1.Invalidate();
        }//Opens .txt file
        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }//Opens File

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }//Opens File

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }//Saves File

        private void RandomizeGrid_Click(object sender, EventArgs e)
        {
            int actual_state;
            Random rand = new Random();
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {

                    actual_state = rand.Next(0, 2);

                    if (actual_state == 0)
                    {
                        universe[x, y] = false;
                    }
                    else
                    {
                        universe[x, y] = true;
                    }
                }
            }
            graphicsPanel1.Invalidate();
        }//Randomizes the entire grid

        private void RandomizeCell_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(0, universe.GetLength(0));
            int y = rand.Next(0, universe.GetLength(1));
            universe[x, y] = !universe[x, y];
            graphicsPanel1.Invalidate();
        }//Randomizes one cell
        private void UniverseSizeHUDToggle_Click(object sender, EventArgs e)
        {
            if (UniverseSizeHUDToggle.Checked == true)
            {
                UniverseSizeHUDToggle.Checked = false;
                UniverseSizeLabelHUD.Visible = false;
            }
            else if (UniverseSizeHUDToggle.Checked == false)
            {
                UniverseSizeHUDToggle.Checked = true;
                UniverseSizeLabelHUD.Visible = true;
            }
        }//Turns Universe Size HUD on and off

        
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
        }//Mouse click actions on each cell
        private int CountNeighborsToroidal(int x, int y)
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
                    if (xCheck < 0)
                    {
                        xCheck = xLen - 1;
                    }
                    if (yCheck < 0)
                    {
                        yCheck = yLen - 1;
                    }
                    if (xCheck >= xLen)
                    {
                        xCheck = 0;
                    }
                    if (yCheck >= yLen)
                    {
                        yCheck = 0;
                    }
                    if (universe[xCheck, yCheck] == true)
                    {
                        count++;
                    }

                }
            }
            return count;
        }//Behavior of grid (Toroidal)
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

                    if (xCheck < 0)
                    {
                        continue;
                    }
                    if (yCheck < 0)
                    {
                        continue;
                    }
                    if (xCheck >= xLen)
                    {
                        continue;
                    }
                    if (yCheck >= yLen)
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
        }//Behavior of grid (Finite)
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
        }//Clears the entire grid
        private void Randomize()
        {
            
        }//Empty
        
    }
}
