using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.Model
{
    class Car
    {
        //variables 

        int plateNumber { get; set; }
        string date { get; set; }
        string time { get; set; }

        //constructors
        public Car()
        {
        }

        public Car(int plateNumber, string date, string time)
        {
            this.plateNumber = plateNumber;
            this.date = date;
            this.time = time;
        }
    }
}
