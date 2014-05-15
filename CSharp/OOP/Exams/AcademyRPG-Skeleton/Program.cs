using System;
using System.IO;
using System.Linq;

namespace AcademyRPG
{
    internal class Program
    {
        private static Engine GetEngineInstance()
        {
            return new AdvanceEngine();
        }

        private static void Main(string[] args)
        {
            StreamWriter current;

            using (current = new StreamWriter(@"C:\Users\Administrator\Desktop\text.txt"))
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