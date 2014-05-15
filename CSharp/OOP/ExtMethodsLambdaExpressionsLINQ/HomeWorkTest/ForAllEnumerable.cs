using HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HomeWorkTest
{
    [TestClass]
    public class ForAllEnumerable
    {
        [TestMethod]
        public void MinValue()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            int results = numbers.Min();

            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void MinValueFaindNegativeNumber()
        {
            List<int> numbers = new List<int>() { 1, 2, -3, 4, 5 };

            int results = numbers.Min();

            Assert.AreEqual(-3, results);
        }

        [TestMethod]
        public void MaxValueFromNumbers()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            int results = numbers.Max();

            Assert.AreEqual(5, results);
        }

        [TestMethod]
        public void Averge()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };

            int results = numbers.Averge();

            Assert.AreEqual(2, results);
        }

        [TestMethod]
        public void AvergeAreEqualWithOtherNumbers()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            int results = numbers.Averge();

            Assert.AreEqual(3, results);
        }

        [TestMethod]
        public void Product()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };

            int results = numbers.Product();

            Assert.AreEqual(6, results);
        }

        [TestMethod]
        public void Sum()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };

            int results = numbers.Sum();

            Assert.AreEqual(6, results);
        }
    }
}