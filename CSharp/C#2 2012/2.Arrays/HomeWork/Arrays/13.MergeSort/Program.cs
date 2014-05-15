using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        Random random = new Random();
        List<int> arrays = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            arrays.Add(random.Next(0, 10000));
        }
        List<int> sortedList = MargeSort(arrays);

        foreach (int item in sortedList)
        {
            Console.Write(item);
        }
    }
    static List<int> MargeSort(List<int> arrays)
    {
        List<int> low = new List<int>();
        List<int> high = new List<int>();
        List<int> sorted = new List<int>();

        if (arrays.Count > 1)
        {
            foreach (int item in arrays)
            {
                if (low.Count < (arrays.Count / 2))
                {
                    low.Add(item);
                }
                else
                {
                    high.Add(item);
                }
            }
            List<int> firstSorted = MargeSort(low);
            List<int> secondSorted = MargeSort(high);
            sorted = MergeList(firstSorted, secondSorted);
        }
        else
        {
            sorted.Add(arrays[0]);
        }
        return sorted;
    }

    private static List<int> MergeList(List<int> firstSorted, List<int> secondSorted)
    {
        List<int> sorted = new List<int>();
        while ((firstSorted.Count > 0) && (secondSorted.Count > 0))
        {
            if (firstSorted[0] < secondSorted[0])
            {
                sorted.Add(firstSorted[0]);
                firstSorted.RemoveAt(0);
            }
            else
            {
                sorted.Add(secondSorted[0]);
                secondSorted.RemoveAt(0);
            }
        }
        foreach (int item in firstSorted)
        {
            sorted.Add(item);
        }
        foreach (int item in secondSorted)
        {
            sorted.Add(item);
        }
        return sorted;
    }
}