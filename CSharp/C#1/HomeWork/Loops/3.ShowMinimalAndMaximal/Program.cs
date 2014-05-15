using System;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int minimal = int.MaxValue;
        int maximal = int.MinValue;
        for (int i = 0; i < N; i++)
        {
            int current = int.Parse(Console.ReadLine());
            minimal = Math.Min(minimal, current);
            maximal = Math.Max(maximal, current);
        }
        Console.WriteLine(minimal);
        Console.WriteLine(maximal);
    }
}
