using System;
using System.Text;
class Program
{
    static void Main()
    {
        int[] number = new int[5];
        for (int i = 0; i < 5; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            int sum = 0;
            StringBuilder sumOfString = new StringBuilder();
            for (int j = i; j < 5; j++)
            {
                sum += number[j];
                sumOfString.Append(number[j].ToString());
                if (sum == 0)
                {
                    Console.WriteLine(sumOfString.ToString() + " = 0");
                }
                sumOfString.Append(" + ");
            }
        }
    }
}
