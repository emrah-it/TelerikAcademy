using System;

class SubSetSumHarder
{
    static void Main()
    {
        Console.WriteLine("Enter the wanted sum of the subsets:");
        long askedSum = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the subset");
        int lenSub = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of elements:");
        long numberOfElements = long.Parse(Console.ReadLine());

        long[] elemnt = new long[numberOfElements];
        int counter = 0;
        string subset = "";
        for (int i = 0; i < elemnt.Length; i++)
        {
            Console.WriteLine("Enter element № {0}", i + 1);
            elemnt[i] = long.Parse(Console.ReadLine());
        }
        int maxSubsets = (int)Math.Pow(2, numberOfElements);
        for (int i = 1; i < maxSubsets; i++)
        {
            subset = "";
            long chekSum = 0;
            int lenCounter = 0;
            for (int j = 0; j <= numberOfElements; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    chekSum = chekSum + elemnt[j];
                    subset = subset + " " + elemnt[j];
                    lenCounter++;
                }
            }
            if (chekSum == askedSum && lenCounter == lenSub)
            {
                Console.WriteLine("Number of subest that have the sum of {0}", askedSum);
                counter++;
                Console.WriteLine("This subset has a sum of {0} : {1} ", askedSum, subset);
            }
        }
        Console.WriteLine(counter);
    }
}