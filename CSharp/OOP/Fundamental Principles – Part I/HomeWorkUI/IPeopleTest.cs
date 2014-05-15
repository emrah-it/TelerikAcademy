using System;
using System.Collections.Generic;
using System.Collections;
using HomeWork.First;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWorkUI
{
    [TestClass]
    public class IPeopleTest
    {
        [TestMethod]
        public void TestInterface()
        {
            List<IPeople> allPeople = new List<IPeople>();
            allPeople.Add(new Teachers("Pesho"));
            allPeople.Add(new Student("ivan"));

            Assert.AreEqual(allPeople[0].Name, "Pesho");
            Assert.AreEqual(allPeople[1].Name, "ivan");
        }
    }
}
