using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint1.Task3.V10.Lib;

namespace Tyuiu.RachevES.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 23.600;
            double wait = 23600;
            var res = ds.NumberToMoney(x);
            Assert.AreEqual(wait, res);

        }
    }
}
