using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint1.Task5.V3.Lib;

namespace Tyuiu.Adzhievrsh.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReturnsThirdDigitFromEnd()
        {
            DataService service = new DataService();

            Assert.AreEqual(9, service.Calculate(130985));
            Assert.AreEqual(3, service.Calculate(12345));
            Assert.AreEqual(1, service.Calculate(100));
            Assert.AreEqual(0, service.Calculate(1000));
        }
    }
}