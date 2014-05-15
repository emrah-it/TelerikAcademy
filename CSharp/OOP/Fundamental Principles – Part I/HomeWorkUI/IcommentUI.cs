using System;
using HomeWork.First;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWorkUI
{
    [TestClass]
    public class IcommentUI
    {
        [TestMethod]
        public void ICommentFirstTest()
        {
            List<IComment> allComment = new List<IComment>()
            {
                new Teachers(), new Student(), new Classes()
            };
            
            
        }
    }
}
