using PhoneLibrary;
using System;

namespace Phones
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GSM.iPhone4s.ToString());

            Console.WriteLine(GSM.iPhone4s.Battery.ToString());
            GSM newphone = new GSM(null, null);
        }
    }
}
