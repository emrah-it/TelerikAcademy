using System;
class Program
{
    static void Main()
    {
        int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        int S = 11;
        int first = 0;
        int length = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum == S)
                {
                    first = i;
                    length = j - i + 1;
                    break;
                }
                else if (currentSum > S)
                {
                    break;
                }
            }
            if (S == currentSum)
            {
                break;
            }
        }
        Console.WriteLine(first.ToString() + " " + length.ToString());
    }
}
