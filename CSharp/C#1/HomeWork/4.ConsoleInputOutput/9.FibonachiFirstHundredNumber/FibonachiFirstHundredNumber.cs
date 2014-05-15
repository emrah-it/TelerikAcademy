using System;
using System.Numerics;
class FibonachiFirstHundredNumber
{
    static void Main()
    {
        BigInteger first = 0;
        BigInteger second = 1;

        Console.Write("{0}, {1}", first, second);
        BigInteger current = 0;
        for (int i = 0; i < 100; i++)
        {
            current = first + second;
            Console.Write(", {0}", current);
            first = second;
            second = current;
        }
    }
}
