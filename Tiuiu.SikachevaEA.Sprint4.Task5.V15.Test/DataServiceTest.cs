using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint4.Task5.V15.Lib;

namespace Tiuiu.SikachevaEA.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 3, 4, -3, 4, -1 },
                                          { -2, 1, 2, 3, -5 },
                                          { -1, -5, 4, 1, 3 },
                                          { 1, -3, -1, 1, 2 },
                                          { 4, 2, -4, -5, 1 } };
            int res = ds.Calculate(mas2);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}
