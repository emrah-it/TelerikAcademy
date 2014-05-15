namespace TestHomeWork
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HomeWork.MyGenericList;

    [TestClass]
    public class GenericListUI
    {
        [TestMethod]
        public void Initioalization()
        {
            GenericList<int> value = new GenericList<int>(4);
            Assert.AreEqual(4, value.Capacity);
        }

        [TestMethod]
        public void InitioalizationTestForCount()
        {
            GenericList<int> value = new GenericList<int>(4);
            Assert.AreEqual(0, value.Count);
        }

        [TestMethod]
        public void AddItemsAndChekCounter()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(1);
            value.Add(2);
            Assert.AreEqual(2, value.Count);
        }

        [TestMethod]
        public void AutoRiseze()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(1);
            value.Add(2);
            value.Add(3);
            value.Add(4);
            value.Add(5);
            Assert.AreEqual(5, value.Count);
        }
        [TestMethod]
        public void CheckLength()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(1);
            value.Add(2);
            value.Add(3);
            value.Add(4);
            value.Add(5);
            Assert.AreEqual(8, value.Capacity);
        }

        [TestMethod]
        public void MinValue()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(-1);
            value.Add(2);
            value.Add(33);
            value.Add(45);
            value.Add(15);
            Assert.AreEqual(-1, value.Min());
        }

        [TestMethod]
        public void MaxValue()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(-1);
            value.Add(2);
            value.Add(33);
            value.Add(45);
            value.Add(15);
            Assert.AreEqual(45, value.Max());
        }

        [TestMethod]
        public void CountainsIsContain()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(-1);
            value.Add(2);
            value.Add(33);
            value.Add(45);
            value.Add(15);
            Assert.AreEqual(true, value.Contains(2));
        }

        [TestMethod]
        public void CountainsIsntContain()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(-1);
            value.Add(2);
            value.Add(33);
            value.Add(45);
            value.Add(15);
            Assert.AreEqual(false, value.Contains(11));
        }

        
        [TestMethod]
        public void IdnexOfContaindedElement()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(-1);
            value.Add(2);
            value.Add(33);
            value.Add(45);
            value.Add(15);
            Assert.AreEqual(2, value.IndexOf(33));
        }

        [TestMethod]
        public void IdnexOfNotContainedElement()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(-1);
            value.Add(2);
            value.Add(33);
            value.Add(45);
            value.Add(15);
            Assert.AreEqual(-1, value.IndexOf(111));
        }

        [TestMethod]
        public void RemoveGivenElement()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(-1);
            value.Add(2);
            value.Add(33);
            value.Add(45);
            value.Add(15);
            value.Remove(33);
            Assert.AreNotEqual(33,value.Contains(33));
        }

        [TestMethod]
        public void IsertInGivenPositon()
        {
            GenericList<int> value = new GenericList<int>();
            value.Add(-1);
            value.Add(2);
            value.Add(33);
            value.Add(45);
            value.Add(15);
            value.Insert(2, 123);
            Assert.AreEqual(123, value[2]);
        }
       
    }
}
