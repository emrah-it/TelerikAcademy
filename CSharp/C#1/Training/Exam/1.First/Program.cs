using System;
using System.Numerics;
class Program
{
    static void Main()
    {
         BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 0 ;
        if (second == 2)
        {
            result = first % third;
        }
        else if (second == 4)
        {
            result = first + third;
        }
        else if (second == 8)
        {
            result = first * third;
        }

        if ((result % 4) == 0)
        {
            Console.WriteLine(result / 4);
        }
        else
        {
            Console.WriteLine(result % 4);
        }
        Console.WriteLine(result);

    }
}
