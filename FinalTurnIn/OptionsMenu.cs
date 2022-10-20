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
    public partial class OptionsMenu : Form
    {
        public static int xf2, yf2, timec;
        public OptionsMenu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }//Empty

        public void DoneButton_Click(object sender, EventArgs e)
        {
            decimal hdec = HeightVal.Value;
            int hint = Convert.ToInt32(hdec);//converts Height value to int

            decimal wdec = WidthVal.Value;
            int wint = Convert.ToInt32(wdec);//converts Width value to int

            decimal timeDec = TimerVal.Value;
            int timeint = Convert.ToInt32(timeDec);//converts Timer value to int

            if (DoneButton.Enabled == true)
            {
                if (hint > 0 && wint > 0 && timeint > 0)
                {
                    xf2 = hint;
                    yf2 = wint;
                    timec = timeint;
                    Close();
                }
                else
                {
                    
                }
                //MessageBox.Show("testing");

                
            }
            else
            {
                Close();
            }
        }
    }
}
