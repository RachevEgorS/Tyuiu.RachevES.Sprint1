using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint1.Task1.V1.Lib;

namespace Tyuiu.RachevES.Sprint1.Task1.V1.Test



{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double x = 1.0;
            double y = 1.0;
            
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(1, res);
        }
    }
}
