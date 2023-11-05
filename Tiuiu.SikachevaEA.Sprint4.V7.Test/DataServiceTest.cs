using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint4.V7.Lib;

namespace Tiuiu.SikachevaEA.Sprint4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7, 5 };
            
            int res = ds.Calculate(array);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}
