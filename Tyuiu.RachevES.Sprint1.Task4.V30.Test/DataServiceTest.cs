using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint1.Task4.V30.Lib;

namespace Tyuiu.RachevES.Sprint1.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 2;
            double e = 2.718;
            double wait = 9;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
