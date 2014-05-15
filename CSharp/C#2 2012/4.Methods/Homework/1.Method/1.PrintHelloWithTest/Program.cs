using System;
class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        string test = "Hello " + name;
        if (test != PrintName(name))
        {
            Console.WriteLine("Error");
        }
    }

    private static string PrintName(string name)
    {
        string toPrint = "Hello " + name;
        Console.WriteLine(toPrint);
        return toPrint;
    }
}
