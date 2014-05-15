using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger secont = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        BigInteger fourth = BigInteger.Parse(Console.ReadLine());

        int R = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        bool firstCycle = true;
        Console.Write("{0} {1} {2} {3}", first, secont, third, fourth);
        if (C != 4)
        {
            Console.Write(" ");
        }
        for (int i = 0; i < R; i++)
        {
            if (firstCycle)
            {
                for (int j = 0; j < C - 4; j++)
                {
                    BigInteger next = first + secont + third + fourth;
                    Console.Write("{0} ", next);
                    first = secont;
                    secont = third;
                    third = fourth;
                    fourth = next;
                }
                firstCycle = false;
                Console.WriteLine();
                continue;
            }
            else
            {
                for (int j = 0; j < C; j++)
                {
                    BigInteger next = first + secont + third + fourth;
                    Console.Write("{0} ", next);
                    first = secont;
                    secont = third;
                    third = fourth;
                    fourth = next;
                }
            }
            Console.WriteLine();
        }
    }
}
