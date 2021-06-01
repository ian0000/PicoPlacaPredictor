using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicoPlacaPredictor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            //when button is clicked it should check for the last digit // must the plate number be of 4 numbers? ive seen 3 right?
            //date should determine if its mon-fri //check date if its ordered as its suppissed to be// can i add a calendar? should be possible
            //check for time boundaries // 7:00 to 9:30//16:00 to 19:30// should i add an option for am/pm?
            //message box for the output

        }

        //if it changes verify the key typed is only a number not a letter
  
        private void txtPlateNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verify if key is a char = !true  //verify if key is a digit = !true // key cant be = .
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
