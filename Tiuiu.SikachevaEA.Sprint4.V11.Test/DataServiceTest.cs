using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint4.V11.Lib;

namespace Tiuiu.SikachevaEA.Sprint4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsarray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int res = ds.GetMultOddArrEl(numsarray);
            int wait = 4725;
            Assert.AreEqual(wait, res);

        }
    }
}
