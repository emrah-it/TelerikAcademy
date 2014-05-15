using System;
class SelectionSort
{
    static void Main()
    {
        int[] arrayToSort = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            for (int j = i + 1; j < arrayToSort.Length; j++)
            {
                if (arrayToSort[i] > arrayToSort[j])
                {
                    int current = arrayToSort[i];
                    arrayToSort[i] = arrayToSort[j];
                    arrayToSort[j] = current;
                }
            }
        }
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            Console.WriteLine(arrayToSort[i]);
        }
    }
}
