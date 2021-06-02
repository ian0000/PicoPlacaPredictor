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
    }
}
