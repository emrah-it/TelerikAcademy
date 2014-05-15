using System;
using System.IO;
using System.Linq;

namespace Infestation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StreamWriter current = new StreamWriter(@"C:\Users\Emrah\Desktop\test.txt");
            using (current)
            {
                Console.SetOut(current);

                HoldingPen pen = InitializePen();
                StartOperations(pen);
            }
        }

        private static void StartOperations(HoldingPen pen)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                pen.ParseCommand(input);
                input = Console.ReadLine();
            }
        }

        private static HoldingPen InitializePen()
        {
            return new CustumHoldingPen();
        }
    }
}