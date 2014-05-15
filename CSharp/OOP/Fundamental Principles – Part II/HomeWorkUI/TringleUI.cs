using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork.CalcSurface_1;
using HomeWork.Exception;
using HomeWork.Bank;
namespace HomeWorkUI
{
    [TestClass]
    public class TringleUI
    {
        [TestMethod]
        public void TringleAreaTest()
        {
            Shape tringleArea = new Triangle(2, 2);
            Assert.AreEqual(2, tringleArea.CalculateSurface());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TringleExeptionsNegativeWidth()
        {
            Shape tringleArea = new Triangle(-2, 2);
            Assert.AreEqual(2, tringleArea.CalculateSurface());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TringleExeptionsNegativeHeight()
        {
            Shape tringleArea = new Triangle(2, -2);
            Assert.AreEqual(2, tringleArea.CalculateSurface());
        }

    }
}
