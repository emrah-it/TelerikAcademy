using System;
using System.Text;
using System.Numerics;
class Program
{
    static void Main()
    {
        long length = long.Parse(Console.ReadLine());
        long[] numbers = new long[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        StringBuilder my = new StringBuilder();
        long result;

        for (int i = 0; i < length; i++)
        {
            long current, changed, reversed, k;
            changed = reversed = k = 0;
            current = numbers[i];
            my.Append(Convert.ToString(current, 2));
            for (int j = my.Length - 1; j >= 0; j--)
            {
                if (my[j] == '0')
                {
                    changed += (long)Math.Pow(2, k);
                }
                k++;
            }
            for (int j = 0; j < my.Length; j++)
            {
                if (my[j] == '1')
                {
                    reversed += (long)Math.Pow(2, j);
                }
            }
            result = (current ^ changed) & reversed;
            Console.WriteLine(result);
            my.Clear();

        }

    }
}
