namespace HomeWorkUI
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HomeWork.CalcSurface_1;
    [TestClass]
    public class CircleUI
    {
        [TestMethod]
        public void CirecleHeightUI()
        {
            Shape circ = new Circle(12, 12);
            Assert.AreEqual(12, circ.Width);

        }
        
        [TestMethod]
        public void CirecleWidthUI()
        {
            Shape circ = new Circle(12, 12);
            circ.Height = 21;
            Assert.AreEqual(21, circ.Width);

        }
    }
}
