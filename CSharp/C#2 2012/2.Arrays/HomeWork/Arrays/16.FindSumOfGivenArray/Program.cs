using System;
class SubSetSum
{
    static void Main()///hello
    {
        Console.WriteLine("Enter the wanted sum of the subsets:");
        long searchedSum = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of elements:");
        long numberOfElements = long.Parse(Console.ReadLine());
        long[] allElements = new long[numberOfElements];
        int counter = 0;
        string subset = "";
        for (int i = 0; i < allElements.Length; i++)
        {
            Console.WriteLine("Enter element № {0}", i + 1);
            allElements[i] = long.Parse(Console.ReadLine());
        }
        int maxSubsets = (int)Math.Pow(2, numberOfElements) - 1;
        for (int i = 1; i <= maxSubsets; i++)
        {
            subset = "";
            long chekSum = 0;
            for (int j = 0; j <= numberOfElements; j++)
            {
                int mask = 1 << j;
                int numberAndMask = i & mask;
                int bit = numberAndMask >> j;
                if (bit == 1)
                {
                    chekSum = chekSum + allElements[j];
                    subset = subset + " " + allElements[j];
                }
            }
            if (chekSum == searchedSum)
            {
                Console.WriteLine("Number of subest that have the sum of {0}", searchedSum);
                counter++;
                Console.WriteLine("This subset has a sum of {0} : {1} ", searchedSum, subset);
            }
        }
        Console.WriteLine(counter);
    }
}