//7.Write a class GSMTest to test the GSM class:
//      Create an array of few instances of the GSM class.
//      Display the information about the GSMs in the array.
//      Display the information about the static property IPhone4S.

namespace GSMTest
{
    using System;
    using PhoneLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GSMTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TryToAddNullNameAndManufacturer()
        {
            GSM newPhone = new GSM(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TryToAddEmptyString()
        {
            GSM newPhone = new GSM("   ", "    ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TryToAddNegativePrice()
        {
            GSM newPhone = new GSM("John", "Smith");
            newPhone.Price = -1;
        }

        [TestMethod]
        public void DisplayInformationIphone()
        {
            Console.WriteLine(GSM.iPhone4s.ToString());
        }



        

    }
}
