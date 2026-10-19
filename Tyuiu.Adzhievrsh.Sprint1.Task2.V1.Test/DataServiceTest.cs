using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint1.Task2.V1.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void ConvertKilometersToMiles_OneKilometer_ReturnsPoint621()
        {
            // Arrange
            DataService service = new DataService();

            // Act
            double result = service.ConvertKmToM(1);

            // Assert
            Assert.AreEqual(0.621, result);
        }

        [TestMethod]
        public void ConvertKilometersToMiles_TenKilometers_ReturnsPoint215()
        {
            // Arrange
            DataService service = new DataService();

            // Act
            double result = service.ConvertKmToM(10);

            // Assert
            Assert.AreEqual(6.215, result);
        }

        [TestMethod]
        public void ConvertKilometersToMiles_1609Kilometers_Returns1000()
        {
            // Arrange
            DataService service = new DataService();

            // Act
            double result = service.ConvertKmToM(1609);

            // Assert
            Assert.AreEqual(1000.0, result);
        }
    }
}