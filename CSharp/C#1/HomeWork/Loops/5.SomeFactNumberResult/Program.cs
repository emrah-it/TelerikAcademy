using System;
using System.Numerics;
using Factorial;

namespace _5.SomeFactNumberResult
{
    class Program
    {

        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());
            BigInteger nFact = JustForMe.FoundFactorial(N);
            BigInteger kFact = JustForMe.FoundFactorial(K);
            Console.WriteLine(((nFact * kFact) / JustForMe.FoundFactorial(K - N)));
        }
    }
}
