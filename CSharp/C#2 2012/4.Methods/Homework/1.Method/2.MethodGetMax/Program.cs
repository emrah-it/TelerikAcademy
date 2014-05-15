using System;
class Program
{
    static void Main()
    {
        int[] hello = new int[3];
        for (int i = 0; i < hello.Length; i++)
        {
            hello[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(GetMax(hello[0], GetMax(hello[1], hello[2])));
    }
    static int GetMax(int a, int b)
    {
        return (a > b ? a : b);
    }
}
