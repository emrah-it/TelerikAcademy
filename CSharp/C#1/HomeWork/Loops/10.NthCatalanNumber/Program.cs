using System;
using System.Numerics;
using Factorial;
class Program
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());

        BigInteger c = Factorial.JustForMe.FoundFactorial(2 * N) / (Factorial.JustForMe.FoundFactorial(1 + N) * Factorial.JustForMe.FoundFactorial(N));
        Console.WriteLine(c);
    }
}
