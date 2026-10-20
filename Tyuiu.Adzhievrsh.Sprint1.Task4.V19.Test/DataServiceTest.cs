using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint1.Task4.V19.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void Calculate_X3Y5_Returns8()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(3, 5);

            Assert.AreEqual(8.0, result, 0.000001);
        }

        [TestMethod]
        public void Calculate_X4Y2_Returns3()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(4, 2);

            Assert.AreEqual(3.0, result, 0.000001);
        }

        [TestMethod]
        public void Calculate_X0Y4_Returns2()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(0, 4);

            Assert.AreEqual(2.0, result, 0.000001);
        }

        [TestMethod]
        public void Calculate_X2_ThrowsException()
        {
            DataService ds = new DataService();

            Assert.ThrowsException<System.ArgumentException>(
                () => ds.Calculate(2, 5));
        }
    }
}