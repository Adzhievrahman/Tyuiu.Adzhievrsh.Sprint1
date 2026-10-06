using Assert = NUnit.Framework.Assert;
using System;
using Tyuiu.Adzhievrsh.Sprint1.Task0.V27.Lib;
namespace Tyuiu.Adzhievrsh.Sprint1.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(22, res);
        }
    }
}