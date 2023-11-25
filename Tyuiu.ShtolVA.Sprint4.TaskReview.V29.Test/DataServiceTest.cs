using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint4.TaskReview.V29.Lib;

namespace Tyuiu.ShtolVA.Sprint4.TaskReview.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string str = "983157642891";
            int rows = 4;
            int columns = 3;
            int wait = 28;
            int res = ds.Calculate(rows, columns, str);
            Assert.AreEqual(wait, res);
        }
    }
}
