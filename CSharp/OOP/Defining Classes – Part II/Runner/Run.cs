using System;
using HomeWork.Attribute;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
namespace Runner
{

    [VersionAttribute("1.0")]
    class Run
    {
        static void Main(string[] args)
        {
            Type type = typeof(Run);
            
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in allAttributes)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
