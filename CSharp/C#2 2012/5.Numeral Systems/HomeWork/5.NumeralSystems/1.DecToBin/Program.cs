using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Decimal Number");
        decimal number = decimal.Parse(Console.ReadLine());
        int[] bits = decimal.GetBits(number);
        for (int i = bits.Length -1; i >= 0 ; i--)
        {
            Console.Write(Convert.ToString(bits[i], 2));
        }
        Console.WriteLine();
    }
}
