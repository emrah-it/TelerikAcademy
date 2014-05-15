using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger[] elements = new BigInteger[101];
        elements[0] = 1;
        for (int i = 1; i < elements.Length; i++)
        {
            elements[i] = elements[-1 + i] * i;
        }

        for (int i = 1; i < elements.Length; i++)
        {
            Console.WriteLine();
        }
    }
}
