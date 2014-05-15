using System;
using System.Numerics;
namespace Factorial
{
    public static class JustForMe
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());

            BigInteger nFact = FoundFactorial(N);
            BigInteger kFact = FoundFactorial(K);
            Console.WriteLine(nFact / kFact);

        }

        public static BigInteger FoundFactorial(BigInteger N)
        {
            BigInteger result = 1;
            for (int i = 1; i <= N; i++)
            {
                result *= i;
            }
            return result;

        }
    }
}