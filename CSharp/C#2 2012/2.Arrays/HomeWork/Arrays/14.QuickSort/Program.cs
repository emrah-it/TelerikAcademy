using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> array = new List<int>() { 3, 8, 7, 5, 2, 1, 9, 6, 4 }; ;
        Quicksort(array, 0, array.Count - 1);
        Console.WriteLine(string.Join(", ", array));
    }
    static public void Quicksort(List<int> array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right);
            if (pivot > 1)
            {
                Quicksort(array, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Quicksort(array, pivot + 1, right);
            }
        }
    }
    static public int Partition(List<int> array, int left, int right)
    {
        int pivot = array[left];
        while (true)
        {
            while (array[left] < pivot)
            {
                left++;
            }
            while (array[right] > pivot)
            {
                right--;
            }
            if (left < right)
            {
                int temp = array[right];
                array[right] = array[left];
                array[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

}
