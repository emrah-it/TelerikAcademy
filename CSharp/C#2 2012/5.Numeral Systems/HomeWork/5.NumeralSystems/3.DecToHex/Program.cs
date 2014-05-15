using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string num = Convert.ToString(number, 16);
        Console.WriteLine(num);
    }
}