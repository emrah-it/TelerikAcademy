//Write a program that, for a given two integer numbers N and X,
//calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN



using System;

using System.Numerics;
using Factorial;
class Program
{
    static void Main()
    {
        BigInteger N = int.Parse(Console.ReadLine());
        int X = int.Parse(Console.ReadLine());
        BigInteger s = 1;
        for (int i = 1; i < N; i++)
        {
            s += JustForMe.FoundFactorial(N) / (BigInteger) Math.Pow(X, i);
        }
        Console.WriteLine(s);
    }
}
