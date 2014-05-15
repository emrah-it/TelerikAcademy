using System;
using System.Numerics;


class Program
{
    static void SecondMain()
    {
        BigInteger[] firstTree = new BigInteger[3];
        for (int i = 0; i < 3; i++)
        {
            firstTree[i] = BigInteger.Parse(Console.ReadLine());
        }
        int length = int.Parse(Console.ReadLine());

        BigInteger[] numbers = new BigInteger[length];
        for (int i = 0; i < 3; i++)
        {
            numbers[i] = firstTree[i];
        }
        for (int i = 3; i < length; i++)
        {
            numbers[i] = numbers[i - 3] + numbers[i - 2] + numbers[i - 1];
        }
        Console.WriteLine(numbers[length - 1]);
    }
}