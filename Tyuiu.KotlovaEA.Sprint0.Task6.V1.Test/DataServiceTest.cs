using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KotlovaEA.Sprint0.Task6.V1.Lib;
namespace Tyuiu.KotlovaEA.Sprint0.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbrs = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbrs);
            Assert.AreEqual(15, res);
        }
        public void CheckASubtractionArrayValid()
        {
            var numbrs = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbrs);
            Assert.AreEqual(-14, res);
        }
        public void CheckMultiplicationArrayValid()
        {
            var numbrs = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbrs);
            Assert.AreEqual(120, res);
        }
    }
}