using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint3.Task6.V18.Lib;

namespace Tyuiu.TkachukSS.Sprint3.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 9;
            int stopValue = 18;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 221;

            Assert.AreEqual(wait, result);
        }
    }
}
