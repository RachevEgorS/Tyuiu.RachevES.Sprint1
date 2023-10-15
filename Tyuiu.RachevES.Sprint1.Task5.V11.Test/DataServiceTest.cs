using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint1.Task5.V11.Lib;
namespace Tyuiu.RachevES.Sprint1.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 130985;
            int wait = 9;
            var res = ds.Calculate(k);
            Assert.AreEqual(wait, res);

        }
    }
}
