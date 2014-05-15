//12. Write a class GSMCallHistoryTest to test the 
//call history functionality of the GSM class.
//      Create an instance of the GSM class.
//      Add few calls.
//      Display the information about the calls.
//      Assuming that the price per minute is 
//0.37 calculate and print the total price of the calls in the history.
//      Remove the longest call from the history 
//and calculate the total price again.
//      Finally clear the call history and print it.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneLibrary;

[TestClass]
public class GSMCallHistoryTest
{
    static GSM phone;

    [TestMethod]
    public  void AddCallsAndChekIsCorret()
    {
        ClassInitalize();
        phone.AddCalls(10, "088870887", DateTime.Now);
        phone.AddCalls(123, "08888888", DateTime.Now);
        int testPropery = phone.TotalCallHistory;
        Assert.AreEqual(2, testPropery);
    }

    [TestMethod]
    public void CalculationOfCalls()
    {
        ClassInitalize();
        phone.AddCalls(10, "088870887", DateTime.Now);
        phone.AddCalls(10, "088870887", DateTime.Now);
        phone.AddCalls(10, "088870887", DateTime.Now);
        phone.AddCalls(10, "088870887", DateTime.Now);
        phone.AddCalls(10, "088870887", DateTime.Now);
        phone.AddCalls(10, "088870887", DateTime.Now);

        decimal totalPirce = phone.CallculateTotalCost(0.6M);
        decimal result = 0.6M;
        Assert.AreEqual(result, totalPirce);
    }

    public static void ClassInitalize()
    {
        phone = new GSM("Lumia 800", "Nokia");
    }
}