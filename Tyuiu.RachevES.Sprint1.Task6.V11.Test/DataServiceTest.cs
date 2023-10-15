using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint1.Task6.V11.Lib;

namespace Tyuiu.RachevES.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string povtor = "Мы люди честные ... Мы используем ПО, украденное до нас...";
            DataService ds = new DataService();
            bool res = ds.CheckeFirstLetterRepetition(povtor);
            Assert.AreEqual(true, res);
        }
    }
}
