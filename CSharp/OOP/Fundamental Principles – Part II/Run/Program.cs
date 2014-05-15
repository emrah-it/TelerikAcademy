using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.CalcSurface_1;
using HomeWork.Exception;
using HomeWork.Bank;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer currentCustumer = new PrivateClient();
            currentCustumer.TakeLoan(100, 12, 10);
            currentCustumer.TakeMortageLoan(100, 12, 10);
            currentCustumer.MakeDepositeAcocunt(100, 12, 10);

            currentCustumer.MakeDepositeToLoanAccount();
        }
    }
}
