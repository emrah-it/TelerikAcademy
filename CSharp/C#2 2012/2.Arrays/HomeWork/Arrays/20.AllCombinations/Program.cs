using System;
class Program
{
    static private int max = 100;
    static private int n;
    static private int k;
    static private int[] array = new int[max];
    static void Main()
    {
        n = int.Parse(Console.ReadLine());

        k = int.Parse(Console.ReadLine());
        Variate(0);
    }

    private static void Variate(int i)
    {
        if (i >= k)
        {
            Print(i);
            return;
        }
        for (int j = 0; j < n; j++)
        {
            array[i] = j;
            Variate(i + 1);
        }
    }
    static void Print(int i)
    {
        for (int l = 0; l <= i -1; l++)
        {
            Console.Write( array[l] + 1 + " ");
        }
        Console.WriteLine();
    }
}
