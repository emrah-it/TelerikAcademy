using System;
using System.Text;
class Program
{
    static void Main()
    {
        string first = ConvertToReversedString(Console.ReadLine());
        string second = ConvertToReversedString(Console.ReadLine());


        Console.WriteLine(SumTwoString(first, second));
    }

    private static string SumTwoString(string first, string second)
    {
        int length = first.Length > second.Length ? first.Length : second.Length;
        string currentFirst = first.PadRight(length, '0');
        string currentSecond = second.PadRight(length, '0');
        StringBuilder result = new StringBuilder();
        int forNextNumber = 0;
        for (int i = 0; i < length; i++)
        {
            int currentResult = int.Parse(currentFirst[i].ToString()) + int.Parse(currentSecond[i].ToString()) + forNextNumber;
            forNextNumber = 0;
            if (currentResult >= 10)
            {
                forNextNumber = 1;
                currentResult %= 10;
            }
            result.Append(currentResult);

        }

        return ConvertToReversedString(result.ToString());
    }

    private static string ConvertToReversedString(string number)
    {
        char[] currentNumber = number.ToString().ToCharArray();
        Array.Reverse(currentNumber);
        return new string(currentNumber);
    }
}
