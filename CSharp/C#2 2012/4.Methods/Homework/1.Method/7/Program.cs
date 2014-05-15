using System;
class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine( ReversNumber(number));
    }

    private static string ReversNumber(string current)
    {
        char[] number = current.ToCharArray();
        Array.Reverse(number);
        return new string(number);
    }
}
