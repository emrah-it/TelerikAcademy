using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        int count = 0;
        int maxSubsets = (int)(Math.Pow(2, n) - 1);

        for (int i = 1; i <= maxSubsets; i++)
        {
            long subsetsSum = 0;
            for (int f = 0; f < n; f++)
            {
                if (((i >> f) & 1) == 1)
                {
                    subsetsSum += numbers[f];
                }
            }
            if (subsetsSum == s)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}