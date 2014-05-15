using System;

class Program
{
    static void Main()
    {
        int[] array = new int[] { 1, 234, 2346, 234, 2, 7, -5, 4, 2, -23, 2, 34, -23, 12, 3, 4, 12, 35, 2346, 2, 3523, 46, 5126, 2, 62, 36, 34, 2, 26, 2346, 246, 246, 34, 23, 346, -23, -2134, 712, 314, 72, 14, };
        bool incressing = false;
        JustSort(array, incressing);
        Print(array);
    }

    private static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    private static void JustSort(int[] array, bool incressing)
    {
        for (int i = 0; i < array.Length; i++)
        {
            GetBest(array, i, incressing);
        }
    }
    private static void GetBest(int[] array, int position, bool incressing)
    {
        for (int i = position + 1; i < array.Length; i++)
        {
            if ( incressing ? (array[position] > array[i]) : (array[position] > array[i]))
            {
                Replease(position, i, array);
            }
        }
    }

    private static void Replease(int position, int i, int[] array)
    {
        int temp = array[i];
        array[i] = array[position];
        array[position] = temp;
    }
}