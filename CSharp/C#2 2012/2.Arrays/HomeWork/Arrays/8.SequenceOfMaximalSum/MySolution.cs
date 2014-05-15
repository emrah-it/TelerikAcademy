using System;

//Kadane's algorithm link:http://en.wikipedia.org/wiki/Maximum_subarray_problem
internal class MySolution
{
    private static void Main()
    {
        int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int currentMax = int.MinValue, maxValue = int.MinValue;
        currentMax = array[0];
        int endMax = int.MinValue;
        int currentLength = 0;
        int length;
        int currentStart = 0;
        int endStart;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] + currentMax > array[i])
            {
                currentMax += array[i];
                currentLength++;
            }
            else
            {
                currentMax = array[i];
                currentStart = i;
            }
            if (currentMax > endMax)
            {
                endMax = currentMax;
                endStart = currentStart;
                length = currentLength;
            }
        }
        Console.WriteLine(endMax);
    }
}