using System;
class Program
{
    static private int n;
    static private int k;
    static private int[] array = new int[20];
    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());
        Console.WriteLine("C {0} {1}", n, k);
        Comb(1, 0);
    }

    private static void Comb(int i, int after)
    {
        if (i > k)
        {
            return;
        }
        for (int j = after + 1 ; j <= n ; j++)
        {
            array[i - 1] = j;
            if (i == k)
            {
                Print(i);
            }
            Comb(i + 1, j);
        }
    }
    static void Print(int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
