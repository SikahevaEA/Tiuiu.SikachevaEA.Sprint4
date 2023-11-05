using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint4.V12.Lib;

namespace Tiuiu.SikachevaEA.Sprint4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int res = ds.Calculate(array);
            int wait = 4725;
            Assert.AreEqual(wait, res);
        }
    }
}
