using System;

class Program
{
    static void Main()
    {
        int jury = int.Parse(Console.ReadLine());
        int[] cats = new int[10];
        for (int i = 0; i < 10; i++)
        {
            cats[i] = 0;
        }

        for (int i = 0; i < jury; i++)
        {
            int current = int.Parse(Console.ReadLine());
            cats[current - 1]++;
        }
        int maxPoint = int.MinValue;
        int winner = 0;
        for (int i = 0; i < 10; i++)
        {
            if(cats[i] > maxPoint)
            {
                maxPoint = cats[i];
                winner = i + 1;
            }
        }
        Console.WriteLine(winner);
    }
}
