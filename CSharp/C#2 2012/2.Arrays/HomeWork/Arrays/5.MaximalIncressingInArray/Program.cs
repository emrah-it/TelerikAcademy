using System;

internal class Program
{
    private static void Main()
    {
        int[] array = new int[] { 3, 2, 3, 4, 2, 2, 4 };
        int firstNumber;
        int maxLength = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            int current = array[i];
            int length = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if ((current + 1) == array[j])
                {
                    length++;
                    current = array[j];
                }
            }
            if (maxLength < length)
            {
                firstNumber = array[i];
                maxLength = length;
            }
        }
        Console.WriteLine();
    }
}