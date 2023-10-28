using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint3.Task5.V3.Lib;

namespace Tyuiu.TkachukSS.Sprint3.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService data = new DataService();

            int x = 3;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 11;

            double res = data.GetSumSumSeries(x, start1, start2, stop1, stop2);

            double wait = 33.4111981646673;
            Assert.AreEqual(wait, res);
        }
    }
}
