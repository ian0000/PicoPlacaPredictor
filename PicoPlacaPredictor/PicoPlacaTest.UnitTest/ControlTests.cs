using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoPlacaPredictor;
using PicoPlacaPredictor.Control;
using System;

namespace PicoPlacaTest.UnitTest
{
    [TestClass]
    public class ControlTests
    {
        //test in case the values of date is out of a normal date range
        [TestMethod]
        public void DayOfWeek_DateOffRange_Returns7()
        {
            //arrange
            var control = new Control();

            //act
            var result = control.DayOfWeek("35/13/2021");

            //assert
            Assert.AreEqual(result, 7);
        }

        //when the date given is right
        [TestMethod]
        public void DayOfWeek_DateCorrect_ReturnsLessThan7()
        {

            //arrange
            var control = new Control();

            //act
            var result = control.DayOfWeek("24/01/2021");

            //assert
            bool solution = false;
            if (result < 7)
            {
                solution = true;
            }
            Assert.IsTrue(solution);
        }

        //in case the time is out of a normal time range
        [TestMethod]
        public void TimeValidation_OutOfTimeRange_Returns3()
        {

            //arrange
            var control = new Control();
            Random random = new Random();
            int hour = random.Next(24, 40);
            int minute = random.Next(60, 100);
            string time = hour.ToString()+ ":" + minute.ToString();

            //act
            var result = control.TimeValidation(time);

            //assert
            Assert.AreEqual(result, 3);
        }

        //in case the time is out of the pico y placa schedule >9 && <16
        [TestMethod]
        public void TimeValidation_TimeBetween9and16_Returns2()
        {

            //arrange
            var control = new Control();
            Random random = new Random();
            int hour = random.Next(10, 15);
            string time = hour.ToString() + ":00" ;

            //act
            var result = control.TimeValidation(time);

            //assert
            Assert.AreEqual(result, 2);
        }

        //in case the time is out of the pico y placa schedule if hour = 9 then  minute<=30
        [TestMethod]
        public void TimeValidation_Timeless930_Returns1()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int minute = random.Next(0, 30);
            string time = "09:" + minute.ToString();

            //act
            var result = control.TimeValidation(time);

            //assert
            Assert.AreEqual(result, 1);
        }
        //in case the time is out of the pico y placa schedule if hour = 19 then  minute<=30
        [TestMethod]
        public void TimeValidation_Timeless1930_Returns1()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int minute = random.Next(0, 30);
            string time = "19:" + minute.ToString();

            //act
            var result = control.TimeValidation(time);

            //assert
            Assert.AreEqual(result, 1);
        }

        //in case the time is out of the pico y placa schedule if hour = 9 then  minute >30
        [TestMethod]
        public void TimeValidation_Timemore930_Returns2()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int minute = random.Next(30, 59);
            string time = "09:" + minute.ToString();

            //act
            var result = control.TimeValidation(time);

            //assert
            Assert.AreEqual(result, 2);
        }

        //in case the time is out of the pico y placa schedule if hour = 19 then  minute >30
        [TestMethod]
        public void TimeValidation_Timemore1630_Returns2()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int minute = random.Next(30, 59);
            string time = "19:" + minute.ToString();

            //act
            var result = control.TimeValidation(time);

            //assert
            Assert.AreEqual(result, 2);
        }


        //in case the time is out of the pico y placa schedule 7 =< hour < 9 
        [TestMethod]
        public void TimeValidation_TimeBetween79_Returns1()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int hour = random.Next(7, 8);
            int minute = random.Next(0, 59);
            string time = hour.ToString() + ":" + minute.ToString();

            //act
            var result = control.TimeValidation(time);

            //assert
            Assert.AreEqual(result, 1);
        }

        //in case the time is out of the pico y placa schedule 16 =< hour < 19 
        [TestMethod]
        public void TimeValidation_TimeBetween1619_Returns1()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int hour = random.Next(16, 18);
            int minute = random.Next(0, 59);
            string time = hour.ToString() + ":" + minute.ToString();

            //act
            var result = control.TimeValidation(time);

            //assert
            Assert.AreEqual(result, 1);
        }
    }
}
