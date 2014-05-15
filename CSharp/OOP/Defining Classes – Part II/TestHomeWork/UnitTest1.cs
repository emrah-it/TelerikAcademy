using HomeWork.Attribute;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestHomeWork
{
    [TestClass]
    [VersionAttribute("1.0")]
    public class UnitTest1
    {
        [TestMethod]
        public void VersionAttributeTest()
        {
            Type type = typeof(UnitTest1);

            object[] all = type.GetCustomAttributes(false);
            Assert.AreEqual("1.0", all[0].ToString());
        }
    }
}