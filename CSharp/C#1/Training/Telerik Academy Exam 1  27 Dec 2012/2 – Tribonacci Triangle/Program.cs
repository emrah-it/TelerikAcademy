using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        BigInteger lines = BigInteger.Parse(Console.ReadLine());

        if (lines == 2)
        {
            Console.WriteLine(first);
            Console.WriteLine(second + " " + third);
        }
        else
        {
            Console.WriteLine(first);
            Console.WriteLine(second + " " + third);
            for (BigInteger i = 3; i <= lines; i++)
            {
                for (BigInteger k = 0; k < i; k++)
                {
                    BigInteger next = first + second + third;
                    Console.Write(next);
                    first = second;
                    second = third;
                    third = next;
                    if (k != i - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
