using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.Adzhievrsh.Sprint1.Task7.V29.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_X0Y0_Returns0333()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(0, 0);

            Assert.AreEqual(0.333, result, 0.001);
        }

        [TestMethod]
        public void Calculate_X1Y1_Returns1410()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(1, 1);

            Assert.AreEqual(1.410, result, 0.001);
        }

        [TestMethod]
        public void Calculate_DenominatorZero_ThrowsException()
        {
            DataService ds = new DataService();

            bool exceptionThrown = false;

            try
            {
                ds.Calculate(1, 3);
            }
            catch (ArgumentException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);
        }
    }
}