using System;
class Program
{
    static void Main()
    {
        int length = 10;
        int[] array = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int sequense = 1;
        int solution = int.MinValue;
        int maxPoint = int.MinValue;
        for (int i = 1; i < length; i++)
        {
            int currentNumber = array[i];
            int points = 1;
            for (int j = i + 1; j < length; j++)
            {
                if (currentNumber == array[j])
                {
                    points++;
                }
                else break;
            }
            if (points > maxPoint)
            {
                solution = array[i];
                maxPoint = points;
            }
        }
        Console.WriteLine(solution.ToString() + " " + maxPoint.ToString());
    }
}
