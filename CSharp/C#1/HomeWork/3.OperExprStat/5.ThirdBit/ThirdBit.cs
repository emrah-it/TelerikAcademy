using System;
class ThirdBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int one = 4;
        number = number & one;
        Console.WriteLine(number == one? "1" : "0");
    }
}
