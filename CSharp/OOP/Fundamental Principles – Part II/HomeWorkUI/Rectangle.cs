namespace HomeWorkUI
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HomeWork.CalcSurface_1;

    [TestClass]
    public class RectangleUI
    {
        [TestMethod]
        public void RectangleAreaTest()
        {
            Shape newRectangle = new Rectangle(5, 5);
            Assert.AreEqual(25, newRectangle.CalculateSurface());
        }
    }
}
