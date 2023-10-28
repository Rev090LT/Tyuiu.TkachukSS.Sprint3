using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint3.Task4.V23.Lib;

namespace Tyuiu.TkachukSS.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataSerivceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(-5, 5);
            double wait = 6.05011274651759;
            Assert.AreEqual(wait, res);
        }
    }
}
