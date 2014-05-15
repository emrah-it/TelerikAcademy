using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());

        Fibonachi(0, 1, 1, N);
    }

    private static void Fibonachi(BigInteger a, BigInteger b, BigInteger counter, BigInteger N)
    {
        Console.WriteLine(a);
        if (counter < N)
        {
            Fibonachi(b, a + b, counter + 1, N);
        }
    }
}
