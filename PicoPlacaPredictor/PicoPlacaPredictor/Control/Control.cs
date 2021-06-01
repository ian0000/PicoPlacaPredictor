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

        //when btn is clicked it should check for the last digit 
        // must the plate number be of 4 numbers? ive seen 3 right?
        public int DayOfWeek(string date)
        {
            //splits the date when it finds '/'
            string[] splitedDate = date.Split('/');

            //converts the array into a datetime to get a datetime and see which date of the week it is
            DateTime dateTime = new DateTime(int.Parse(splitedDate[2]), int.Parse(splitedDate[1]), int.Parse(splitedDate[0]));
           
            //gets the day of the week//sun = 0,mon=1, tues = 2, wed = 3, thurs = 4, fri = 5, sat = 6
            int s = (int)dateTime.DayOfWeek;
            return s;
        }
        

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
