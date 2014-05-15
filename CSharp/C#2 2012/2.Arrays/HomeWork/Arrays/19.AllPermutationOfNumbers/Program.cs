using System;
class Program
{
    static int max = 100;
    static int n;
    static private int[] a = new int[max];
    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            a[i] = i;
        }
        Permute(n);
    }

    private static void Permute(int k)
    {
        
        if (k == 0)
        {
            Print();
            return;
        }
        else
        {
            int swap;
            Permute(k - 1);
            for (int i = 0; i < k -1; i++)
            {
                swap = a[i];
                a[i] = a[k - 1];
                a[k - 1] = swap;
                Permute(k - 1);
                swap = a[i];
                a[i] = a[k - 1];
                a[k - 1] = swap;
            }
        }
    }

    private static void Print()
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + 1 + " "); 
        }
        Console.WriteLine();
    }
}
