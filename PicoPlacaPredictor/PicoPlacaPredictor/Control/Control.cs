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
            int[] dateNum = { int.Parse(splitedDate[0]), int.Parse(splitedDate[1]), int.Parse(splitedDate[2]) };
            // verifies if the day and month are correct 
            if (dateNum[0] >= 1 && dateNum[0] <= 31 && dateNum[1] >= 1 && dateNum[1] <= 12 )
            {

                //converts the array into a datetime to get a datetime and see which date of the week it is//formate for datetime AAAA,mm,dd
                DateTime dateTime = new DateTime(dateNum[2], dateNum[1], dateNum[0]);

                //gets the day of the week//sun = 0,mon=1, tues = 2, wed = 3, thurs = 4, fri = 5, sat = 6
                int dayOfWeek = (int)dateTime.DayOfWeek;
                return dayOfWeek;
            }
            else
            {
                return 7;
            }
        }
        
        //as there are 5  option i should control with a switch the different options
        public bool ValidCarDay(int plate, int dayOfWeek)
        {

            //gets the last digit of the int 
            int lastDigit = plate%(10);

            //if the car can circulate its true//else false?
            bool resultado = true;
            switch (dayOfWeek)
            {

                //0 and 6 aren't necessary but i will let them just to control

                //the license plate number not allowed this days are 1 ^ 2
                case 1:
                    if(lastDigit == 1 || lastDigit == 2)
                    {
                        resultado = false;
                    }
                    break;

                //the license plate number not allowed this days are 3 ^ 4
                case 2:
                    if (lastDigit == 3 || lastDigit == 4)
                    {
                        resultado = false;
                    }
                    break;


                //the license plate number not allowed this days are 5 ^ 6
                case 3:
                    if (lastDigit == 5 || lastDigit == 6)
                    {
                        resultado = false;
                    }
                    break;


                //the license plate number not allowed this days are 7 ^ 8
                case 4:
                    if (lastDigit == 7 || lastDigit == 8)
                    {
                        resultado = false;
                    }
                    break;


                //the license plate number not allowed this days are 9 ^ 0 
                case 5:
                    if (lastDigit == 9 || lastDigit == 0)
                    {
                        resultado = false;
                    }
                    break;

                //default case..i guess this is where 0 and 6 should go?
                default:
                    resultado = true;
                    break;
            }
            return resultado;
        }

        //check for time boundaries // 7:00 to 9:30//16:00 to 19:30// should i add an option for am/pm?//verify if its in the time range, like 23:59 cant be 24:61
        public int TimeValidation(string time)
        {
            //ill return 3 cases, 1 = is in range for the pico y placa, 2 = is not, 3 = is not in the time range
            //splits the time string in : so i can verify both hour and min individually  
            string[] split = time.Split(':');
            int[] timeNum = { int.Parse(split[0]), int.Parse(split[1])};

            //verifies if its in the right range
            if(timeNum[0] <= 23 && timeNum[0] >= 0 && timeNum[1] <= 59 && timeNum[1] >= 0)
            {

                //verifies the hour ranges 7 to 9 //16 to 19
                if ((timeNum[0] <= 9 && timeNum[0] >= 7) || (timeNum[0] <= 19 && timeNum[0] >= 16))
                {
                    //verifies if the time is 9 or 19 if the minute its lower than 30
                    if ((timeNum[0] == 9 || timeNum[0] == 19) && timeNum[1] <= 30)
                    {
                        return 1;
                    }
                    else if ((timeNum[0] == 9 || timeNum[0] == 19) && timeNum[1] > 30)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
            
        }
    }
}
