using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint1.Task3.V6.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void TravelCost_ExampleValues_Returns74035()
        {
            // Arrange
            DataService ds = new DataService();

            // Act
            double result = ds.TravelCost(67, 8.5, 6.5);

            // Assert
            Assert.AreEqual(74.035, result, 0.000001);
        }

        [TestMethod]
        public void TravelCost_ZeroDistance_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();

            // Act
            double result = ds.TravelCost(0, 8.5, 6.5);

            // Assert
            Assert.AreEqual(0.0, result, 0.000001);
        }

        [TestMethod]
        public void TravelCost_OneHundredKilometers_ReturnsCost()
        {
            // Arrange
            DataService ds = new DataService();

            // Act
            double result = ds.TravelCost(100, 10, 6);

            // Assert
            Assert.AreEqual(120.0, result, 0.000001);
        }
    }
}