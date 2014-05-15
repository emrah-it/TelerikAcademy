using System;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        StringBuilder current = new StringBuilder();
        int result = 0;
        int[] number = new int[length];

        for (int i = 0; i < length; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
        {
            current.Append(Convert.ToString(number[i], 2));
        }
        string stringToChekZero = new string('0', K);
        string stringToChekOne = new string('1', K);

        if (stringToChekZero == current.ToString() || stringToChekOne == current.ToString())
        {
            result++;
        }

        string machOne = "1" + stringToChekZero + "1";
        string machTwo = "0" + stringToChekOne + "0";
        int j = 0;
        for (int i = 0; i < current.Length - (K + 1); i++)
        {
            string chek = current.ToString().Substring(i, K + 2);
            if (chek == machOne || chek == machTwo)
            {
                result++;
            }
            j = i;
        }
        if (machOne.Length < current.Length)
        {
            string firstOne = machOne.Substring(1, machOne.Length - 1);
            string secondOne = machTwo.Substring(1, machOne.Length - 1);
            string toChek = current.ToString().Substring(0, machOne.Length - 1);
            if (firstOne == toChek || secondOne == toChek)
            {
                result++;
            }
            firstOne = machOne.Substring(0, machOne.Length - 1);
            secondOne = machTwo.Substring(0, machOne.Length - 1);
            toChek = current.ToString().Substring(current.Length - firstOne.Length, firstOne.Length);
            if (firstOne == toChek || secondOne == toChek)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }

}