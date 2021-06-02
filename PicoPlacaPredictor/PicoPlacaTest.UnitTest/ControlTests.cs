using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoPlacaPredictor;
using PicoPlacaPredictor.Control;
using System;

namespace PicoPlacaTest.UnitTest
{
    [TestClass]
    public class ControlTests
    {
        //--------day of week validation----------

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

        //--------Time validation----------

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

        //--------plate number allowed validation----------

        //plate numbers 1,2 are not allowed to be in the road in the day 1 
        [TestMethod]
        public void ValidaCarDay_Plate12Day1_ReturnsFalse()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int plateDigit = random.Next(1, 2); 

            //act
            var result = control.ValidCarDay(plateDigit,1);

            //assert
            Assert.IsFalse(result);
        }

        //plate numbers 1,2 are  allowed to be in the road in any day but 1 
        [TestMethod]
        public void ValidaCarDay_Plate12AnyDay_ReturnsTrue()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int plateDigit = random.Next(1, 2);
            int day = random.Next(2, 6);

            //act
            var result = control.ValidCarDay(plateDigit, day);

            //assert
            Assert.IsTrue(result);
        }

        //plate numbers 3,4 are not allowed to be in the road in the day 2 
        [TestMethod]
        public void ValidaCarDay_Plate34Day2_ReturnsFalse()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int plateDigit = random.Next(3, 4);

            //act
            var result = control.ValidCarDay(plateDigit, 2);

            //assert
            Assert.IsFalse(result);
        }

        //plate numbers 3,4 are  allowed to be in the road in any day but 2 
        [TestMethod]
        public void ValidaCarDay_Plate34AnyDay_ReturnsTrue()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int plateDigit = random.Next(3, 4);
            int day = random.Next(3, 6);

            //act
            var result = control.ValidCarDay(plateDigit, day);

            //assert
            Assert.IsTrue(result);
        }


        //plate numbers 5,6 are not allowed to be in the road in the day 3 
        [TestMethod]
        public void ValidaCarDay_Plate56Day3_ReturnsFalse()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int plateDigit = random.Next(5, 6);

            //act
            var result = control.ValidCarDay(plateDigit, 3);

            //assert
            Assert.IsFalse(result);
        }

        //plate numbers 5,6 are  allowed to be in the road in any day but 3 
        [TestMethod]
        public void ValidaCarDay_Plate56AnyDay_ReturnsTrue()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int plateDigit = random.Next(3, 4);
            int day = random.Next(4, 6);

            //act
            var result = control.ValidCarDay(plateDigit, day);

            //assert
            Assert.IsTrue(result);
        }


        //plate numbers 7,8 are not allowed to be in the road in the day 4 
        [TestMethod]
        public void ValidaCarDay_Plate78Day4_ReturnsFalse()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int plateDigit = random.Next(7, 8);

            //act
            var result = control.ValidCarDay(plateDigit, 4);

            //assert
            Assert.IsFalse(result);
        }

        //plate numbers 7,8 are  allowed to be in the road in any day but 4 
        [TestMethod]
        public void ValidaCarDay_Plate78AnyDay_ReturnsTrue()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int plateDigit = random.Next(7, 8);
            int day = random.Next(0, 3);

            //act
            var result = control.ValidCarDay(plateDigit, day);

            //assert
            Assert.IsTrue(result);
        }


        //plate numbers 9 is not allowed to be in the road in the day 5
        [TestMethod]
        public void ValidaCarDay_Plate9Day5_ReturnsFalse()
        {
            //arrange
            var control = new Control();
            Random random = new Random();

            //act
            var result = control.ValidCarDay(9, 5);

            //assert
            Assert.IsFalse(result);
        }

        //plate numbers 9 is  allowed to be in the road in any day but 5 
        [TestMethod]
        public void ValidaCarDay_Plate9AnyDay_ReturnsTrue()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int day = random.Next(0, 4);

            //act
            var result = control.ValidCarDay(9, day);

            //assert
            Assert.IsTrue(result);
        }

        //plate numbers 0 is not allowed to be in the road in the day 5
        [TestMethod]
        public void ValidaCarDay_Plate0Day5_ReturnsFalse()
        {
            //arrange
            var control = new Control();
            Random random = new Random();

            //act
            var result = control.ValidCarDay(9, 5);

            //assert
            Assert.IsFalse(result);
        }

        //plate numbers 0 is  allowed to be in the road in any day but 5 
        [TestMethod]
        public void ValidaCarDay_Plate0AnyDay_ReturnsTrue()
        {
            //arrange
            var control = new Control();
            Random random = new Random();
            int day = random.Next(0, 4);

            //act
            var result = control.ValidCarDay(0, day);

            //assert
            Assert.IsTrue(result);
        }
    }
}
