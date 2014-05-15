using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork.CalcSurface_1;
using HomeWork.Exception;
using HomeWork.Bank;
namespace HomeWorkUI
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void TestLoan()
        {
            Customer currentCustumer = new PrivateClient();
            currentCustumer.TakeLoan(100, 12, 10);

            Assert.AreEqual(190, currentCustumer.AllLoans());
        }

        [TestMethod]
        public void TestLoanMakeDeposite()
        {
            Customer currentCustumer = new PrivateClient();
            currentCustumer.TakeLoan(100, 12, 10);
            Assert.AreEqual(190, currentCustumer.AllLoans());
        }
    }
}
