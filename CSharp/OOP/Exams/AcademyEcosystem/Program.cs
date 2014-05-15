using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    class Program
    {
        static Engine GetEngineInstance()
        {
            return new AdvanceEngine();
        }

        static void Main(string[] args)
        {
            StreamWriter current;
            using (current = new StreamWriter(@"C:\Users\Administrator\Desktop\text1.txt"))
            {
                Console.SetOut(current);
                Engine engine = GetEngineInstance();

                string command = Console.ReadLine();
                while (command != "end")
                {
                    engine.ExecuteCommand(command);
                    command = Console.ReadLine();
                }
            }
        }
    }
}
