using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.Control
{
    public class Control
    {
        public Control()
        {

        }
        //when button is clicked it should check for the last digit // must the plate number be of 4 numbers? ive seen 3 right?

        //date should determine if its mon-fri //check date if its ordered as its suppossed to be// can i add a calendar? should be possible
        


        //check for time boundaries // 7:00 to 9:30//16:00 to 19:30// should i add an option for am/pm?//verify if its in the time range, like 23:59 cant be 24:61
        public bool TimeValidation(string time)
        {
            //splits the time string in : so i can verify both hour and min individually  
            string[] split = time.Split(':');

            //verifies the hour ranges 7 to 9 //16 to 19
            if ((int.Parse(split[0]) <= 9 && int.Parse(split[0]) >= 7) || (int.Parse(split[0]) <= 19 && int.Parse(split[0]) >= 16))
            {

                //verifies if the time is 9 or 19 if the minute its lower than 30
                if ((int.Parse(split[0]) == 9 || int.Parse(split[0]) == 19) && int.Parse(split[1]) <= 30)
                {
                    return true;
                }
                else if ((int.Parse(split[0]) == 9 || int.Parse(split[0]) <= 19) && int.Parse(split[1]) > 30)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
