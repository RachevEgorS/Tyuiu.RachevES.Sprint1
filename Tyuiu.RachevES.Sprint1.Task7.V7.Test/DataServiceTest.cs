using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint1.Task7.V7.Lib;

namespace Tyuiu.RachevES.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 2;
            double p = 3.14;
            double wait = -1.123;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
