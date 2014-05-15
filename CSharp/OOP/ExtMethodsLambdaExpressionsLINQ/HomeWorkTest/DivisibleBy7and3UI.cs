using HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HomeWorkTest
{
    [TestClass]
    public class DivisibleBy7and3UI
    {
        [TestMethod]
        public void AllDivisibleNumbersLambdaUI()
        {
            List<int> value = GetListFromNumbers();
            List<int> result = DivisibleBy7and3.AllDivisibleNumbersBuildInExpression(value);
            Assert.AreEqual(true, result.Contains(21));
        }

        [TestMethod]
        public void AllDivisibleNumbersBuildInExpressionUI()
        {
            List<int> value = GetListFromNumbers();
            List<int> result = DivisibleBy7and3.AllDivisibleNumbersBuildInExpression(value);
            Assert.AreEqual(true, result.Contains(21));
        }

        [TestMethod]
        public void AllDivisibleNumbersLinqUI()
        {
            List<int> value = GetListFromNumbers();
            var result = DivisibleBy7and3.AllDivisibleNumbersLinq(value);

            Assert.AreEqual(true, result.MyContain(21));
        }

        private static List<int> GetListFromNumbers()
        {
            List<int> value = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 21, 35 };
            return value;
        }
    }
}