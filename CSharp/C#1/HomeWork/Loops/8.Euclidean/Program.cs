using System;
class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(GSD(a, b));
    }

    private static int GSD(int a, int b)
    {
        return (0 == b) ? a : GSD(b, a % b);
    }
}
