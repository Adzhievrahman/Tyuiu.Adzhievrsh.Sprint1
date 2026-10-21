using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.Adzhievrsh.Sprint1.Task5.V3.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void Calculate_130985_Returns9()
        {
            DataService ds = new DataService();

            int result = ds.Calculate(130985);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Calculate_12345_Returns3()
        {
            DataService ds = new DataService();

            int result = ds.Calculate(12345);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Calculate_100_Returns1()
        {
            DataService ds = new DataService();

            int result = ds.Calculate(100);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Calculate_99_Returns0()
        {
            DataService ds = new DataService();

            int result = ds.Calculate(99);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calculate_Zero_ThrowsException()
        {
            DataService ds = new DataService();

            Assert.ThrowsException<System.ArgumentException>(
                () => ds.Calculate(0));
        }
    }
}