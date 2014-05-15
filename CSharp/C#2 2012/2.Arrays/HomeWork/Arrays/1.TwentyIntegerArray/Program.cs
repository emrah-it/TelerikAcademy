using System;
class Program
{
    static void Main()
    {
        int[] integerNumber = new int[20];
        for (int i = 0; i < 20; i++)
        {
            integerNumber[i] = i * 5;
        }
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(integerNumber[i]);
        }
    }
}
