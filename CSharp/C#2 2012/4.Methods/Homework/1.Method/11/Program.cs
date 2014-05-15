using System;
using System.Text;
class Program
{
    static void Main()
    {
        int[] first = new int[] { 5, 0, 1 };
        int[] second = new int[] { 1, 2, 2, 4 };

        int[] result = Multiplication(first, second);
        Console.WriteLine(Print(result));
    }
    static string Print(int[] array)
    {
        StringBuilder toPrint = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                if (i == 0)
                {
                    toPrint.Append(array[i] + " ");
                }
                else if (array[i] == 1)
                {
                    toPrint.Append(string.Format("{0}^x ", i));
                }
                else
                {
                    toPrint.Append(string.Format("{1}^x{0} ", array[i], i));

                }

            }
            if (i != array.Length - 1 && array[i] != 0)
            {
                toPrint.Append(array[i] > 0 ? "+ " : "- ");
            }
        }
        char[] result = toPrint.ToString().ToCharArray();
        Array.Reverse(result);
        return new string(result);
    }
    static int[] Substraction(int[] first, int[] second)
    {
        int[] result = new int[first.Length > second.Length ? first.Length : second.Length];
        if (first.Length == second.Length)
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = first[i] + second[i];
            }
        }
        else
        {
            int LastPosition = 0;
            for (int i = 0; i < (first.Length < second.Length ? first.Length : second.Length); i++)
            {
                result[i] = first[i] + second[i];
                LastPosition = i;
            }
            for (int i = LastPosition + 1; i < result.Length; i++)
            {
                result[i] = (first.Length > second.Length ? first[i] : second[i]);
            }
        }
        return result;
    }
    static int[] Multiplication(int[] first, int[] second)
    {
        int[] result = new int[first.Length + second.Length];
        int[] current = new int[first.Length + second.Length];
        for (int i = 0; i < result.Length; i++)
        {
            current[i] = result[i] = 0;
        }

        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                current[i + j] = first[i] * second[j];
            }
            result = Substraction(result, current);
            for (int j = 0; j < current.Length; j++)
            {
                current[j] = 0;
            }
        }
        return result;
    }
}