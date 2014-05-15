using System;
class ExchangeValues
{
    static void Main()
    {
        int five = 5;
        int ten = 10;
        int current = five;
        five = ten;
        ten = current;
        Console.WriteLine(five.ToString() + " " + ten.ToString());
    }
}
