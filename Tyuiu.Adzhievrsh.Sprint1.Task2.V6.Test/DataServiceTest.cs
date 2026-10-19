using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint1.Task2.V6.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void Calculate_ExampleValues_Returns74035()
        {
            // Arrange
            DataService ds = new DataService();

            // Act
            double result = ds.Calculate(67, 8.5, 6.5);

            // Assert
            Assert.AreEqual(74.035, result, 0.000001);
        }

        [TestMethod]
        public void Calculate_ZeroDistance_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();

            // Act
            double result = ds.Calculate(0, 8.5, 6.5);

            // Assert
            Assert.AreEqual(0.0, result, 0.000001);
        }

        [TestMethod]
        public void Calculate_OneHundredKilometers_ReturnsCost()
        {
            // Arrange
            DataService ds = new DataService();

            // Act
            double result = ds.Calculate(100, 10, 6);

            // Assert
            Assert.AreEqual(120.0, result, 0.000001);
        }
    }
}