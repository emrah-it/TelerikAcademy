using HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace HomeWorkTest
{
    [TestClass]
    public class SubstringForStringBuilderUI
    {
        [TestMethod]
        public void SubstringUI()
        {
            StringBuilder currentText = new StringBuilder();
            currentText.Append("123456789");
            StringBuilder result = currentText.Substring(3, 3);
            Assert.AreEqual("456", result.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void OutOfRange()
        {
            StringBuilder currentText = new StringBuilder();
            currentText.Append("123456789");
            StringBuilder result = currentText.Substring(3, 20);
        }

        [TestMethod]
        public void HaveToBeDiffrent()
        {
            StringBuilder currentText = new StringBuilder();
            currentText.Append("123456789");
            StringBuilder result = currentText.Substring(0, 3);
            Assert.AreNotEqual("456", result.ToString());
        }
    }
}