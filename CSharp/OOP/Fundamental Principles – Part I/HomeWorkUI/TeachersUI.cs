using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork.First;

namespace HomeWorkUI
{
    [TestClass]
    public class TeachersUI
    {
        [TestMethod]
        public void AddNewTeacherName()

        {
            Teachers newTeacher = new Teachers();
            newTeacher.Name = "Pesho";
            Assert.AreEqual("Pesho", newTeacher.Name);
        }

        [TestMethod]
        public void AddNewTeacherOpptionalComment()
        {
            Teachers newTeacher = new Teachers();
            newTeacher.OptionalComments = "HelloWorld";
            Assert.AreEqual("HelloWorld", newTeacher.OptionalComments);
        }

        [TestMethod]
        public void IPeopleTest()
        {
            IPeople newTeacher = new Teachers();
            newTeacher.Name = "Pesho";
            Assert.AreEqual("Pesho", newTeacher.Name);
        }
        [TestMethod]
        public void ICommentTest()
        {
            IComment newTeacher = new Teachers();
            newTeacher.OptionalComments = "HelloWorld";
            Assert.AreEqual("HelloWorld", newTeacher.OptionalComments);
        }
    }
}
