using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint4.Task3.V1.Lib;

namespace Tiuiu.SikachevaEA.Sprint4.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 3, 4, 3, 4, 1 },
                                          { 8, 1, 6, 6, 9 },
                                          { 9, 8, 5, 1, 3 },
                                          { 1, 8, 7, 1, 2 },
                                          { 9, 9, 7, 5, 6 } };
            int res = ds.Calculate(mas2);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}
