using System;
using System.Numerics;


class First
{
    static void Main()
    {
        BigInteger one = BigInteger.Parse(Console.ReadLine());
        BigInteger two = BigInteger.Parse(Console.ReadLine());
        BigInteger tree = BigInteger.Parse(Console.ReadLine());
        BigInteger next;
        int length = int.Parse(Console.ReadLine());
        for (int i = 3; i < length; i++)
        {
            next = one + two + tree;
            one = two;
            two = tree;
            tree = next;
        }
        Console.WriteLine(tree);
    }
}

