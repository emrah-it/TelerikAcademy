using System;
class Program
{
    static void Main()
    {
        string hex = Console.ReadLine();
        Int64 number = Convert.ToInt64(hex, 16);
        Console.WriteLine(number);
    }
}
