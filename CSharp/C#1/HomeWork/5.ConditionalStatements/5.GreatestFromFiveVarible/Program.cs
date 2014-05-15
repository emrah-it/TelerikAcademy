using System;
class GreatestFromFiveVarible
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int max = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            if(max < numbers[i])
            {
                max = numbers[i];
            }
        }
        Console.WriteLine(max);
    }
}
