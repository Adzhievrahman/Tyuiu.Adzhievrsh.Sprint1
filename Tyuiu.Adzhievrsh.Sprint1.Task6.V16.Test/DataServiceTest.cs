using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint1.Task6.V16.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSpecSymbols_BothSymbols_ReturnsTrue()
        {
            DataService ds = new DataService();

            bool result = ds.CheckSpecSymbols("Привет! Как дела?");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckSpecSymbols_OnlyExclamation_ReturnsFalse()
        {
            DataService ds = new DataService();

            bool result = ds.CheckSpecSymbols("Привет!");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSpecSymbols_OnlyQuestion_ReturnsFalse()
        {
            DataService ds = new DataService();

            bool result = ds.CheckSpecSymbols("Как дела?");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSpecSymbols_NoSymbols_ReturnsFalse()
        {
            DataService ds = new DataService();

            bool result = ds.CheckSpecSymbols("Привет");

            Assert.IsFalse(result);
        }
    }
}