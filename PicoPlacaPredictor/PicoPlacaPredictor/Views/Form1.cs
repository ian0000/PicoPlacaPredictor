
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
        Control.Control control = new Control.Control();
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
            
            //1. verifies if time is in "pico y placa" range
            string time = mtxtTime.Text;

            int timeValidation = control.TimeValidation(time);
            //2. gets the day of the week//need to check if its in the right order and the right spliter
            int dayofWeek = control.DayOfWeek(mtxtDate.Text);

            if (timeValidation == 1 && dayofWeek != 7)
            {

                //3. check the plate numbers
                bool result = control.ValidCarDay(int.Parse(txtPlateNumber.Text), dayofWeek);
                if (result == true)
                {
                    MessageBox.Show("You can be in the road with that plate number");
                }
                else
                {
                    MessageBox.Show("You should wait a bit more to be in the road with that plate number");
                }                
            }else if (timeValidation == 3)
            {
                MessageBox.Show("The Time is not valid");
            }
            else
            {
                if (dayofWeek == 7)
                {
                        MessageBox.Show("The date is out of the right range");
                }
                if (timeValidation == 2)
                {
                    MessageBox.Show("You can go out the PICO&PLACA is not up yet");
                }
            }


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

        //This is the "catch" for the masktextbox it already prevents some things like in case the imput is bigger than it should be or if it has some unauthorized caracters
        private void mtxtDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtxtDate.MaskFull)
            {
                MessageBox.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.");
            }
            else if (e.Position == mtxtDate.Mask.Length)
            {
                MessageBox.Show("You cannot add extra characters to the end of this date field.");
            }
            else
            {
                MessageBox.Show("You can only add numeric characters (0-9) into this date field.");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            mtxtDate.Text = dateTimePicker1.Text;
        }
    }
}
