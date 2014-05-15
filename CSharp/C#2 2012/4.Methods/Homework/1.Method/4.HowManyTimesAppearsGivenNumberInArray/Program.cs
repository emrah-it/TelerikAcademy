using System;
class Program
{
    static void Main()
    {
        
        int[] test = NewIntNumber();
        ShowRepeatedTimes(test);
    }
    static int[] NewIntNumber()
    {
        int[] number = new int[] { 1, 5, 9, 8, 7, 4, 5, 6, 4, 1, 3, 1, 5, 16, 1, 8, 48, 74, 9, 41, 6, 1, 61, 51, 6, 18, 89, 41 };
        return number;
    }
    private static void ShowRepeatedTimes(int[] number)
    {
        Array.Sort(number);
        int j = number[0];
        int count = 1;
        for (int i = 1; i < number.Length; i++)
        {
            if(number[i] == j)
            {
                count++;
            }
            else
            {
                Console.WriteLine(j.ToString() + " " + count.ToString());
                count = 1;
                j = number[i];
            }
        }
    }

}
