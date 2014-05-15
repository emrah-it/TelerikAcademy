using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int length = 8;
        int[] figure = new int[length];
        for (int i = 0; i < length; i++)
        {
            figure[i] = int.Parse(Console.ReadLine());
        }
        int one = 1;
        Array.Sort(figure);
        for (int i = length - 2; i >= 0; i--)
        {
            for (int j = 0; j < length; j++)
            {
                int current = figure[i] & (one << j);
                if (current != 0)
                {
                    for (int k = i + 1; k < length; k++)
                    {
                        if ((figure[k] & (one << j)) == 0)
                        {
                            figure[k] = figure[k] | (one << (int)j);
                            figure[k - 1] = (int)figure[k - 1] & (int)(255 ^ (int)(one << j));
                        }
                    }
                }
            }
        }
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(figure[i]);
        }
    }
}
