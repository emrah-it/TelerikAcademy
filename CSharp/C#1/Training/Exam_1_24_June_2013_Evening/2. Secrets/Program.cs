using System;
using System.Numerics;



class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        BigInteger sum = 0;
        BigInteger num = BigInteger.Abs( BigInteger.Parse(number));
        BigInteger current = num;
        for (int i = 1; i <= number.Length; i++)
        {
            current = current % 10;
            if (i % 2 == 1)
            {
                sum += current * (i * i);
            }
            else
            {
                sum += (current * current) * i;
            }
            current = num /= 10;
        }
        Console.WriteLine(sum);
        //Console.WriteLine(48 % 26);
        BigInteger length = sum % 10;
        if (length == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", number);
        }
        if(length > 0)
        {
            BigInteger currentAlpha = sum % 26;
            for (int i = 0; i < sum%10; i++)
            {
                Console.Write((char)(65 + ((currentAlpha + i)%26)));
            }
            Console.WriteLine();
        }
    }
}
