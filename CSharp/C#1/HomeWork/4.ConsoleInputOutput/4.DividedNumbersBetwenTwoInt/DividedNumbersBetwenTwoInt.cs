using System;
class DividedNumbersBetwenTwoInt
{
    static void Main()
    {
        int upNumber = int.Parse(Console.ReadLine());
        int downNumber = int.Parse(Console.ReadLine());
        int current;

        current = Math.Max(upNumber, downNumber);
        downNumber = Math.Min(upNumber, downNumber);
        upNumber = current;
        int result = 0;
        for (int i = downNumber; i <= upNumber; i++)
        {
            if((i % 5) == 0)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}
