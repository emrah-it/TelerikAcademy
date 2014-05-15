using System;
class Program
{
    static public int max = 1000;
    static public int n;
    static public int[] array;
    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        array = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            array[i] = 0;
        }
        Erastoten(n);
    }

    private static void Erastoten(int n)
    {
        int i = 2, j;
        while (i <= n)
        {
            if (array[i] == 0)
            {
                Console.Write(i + " ");
                j = i * i;
                while (j <= n)
                {
                    array[j] = 1;
                    j += i;
                }
            }
            i++;
        }
    }

}
