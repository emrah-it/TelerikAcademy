using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork.CalcSurface_1;
using HomeWork.Exception;
using HomeWork.Bank;
namespace HomeWorkUI
{
    [TestClass]
    public class ExceptionUI
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidRangeException<int>))]
        public void TestMethod1()
        {
            InvalidRangeException<int> numbers = new InvalidRangeException<int>("Invalid Range", 0, 10);
            int curr = 101;
           if( curr>numbers.Start || numbers.End<curr)
           {
               throw numbers;
           }
        }
    }
}
