using System;
class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        int sum = 0;
        int count = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if ((i % 2) == 1)
            {
                int current;
                if (int.TryParse(number[i].ToString(), out current))
                {
                    sum += current;
                    count++;
                }
            }
        }
        Console.WriteLine("{0} {1}", count, sum);
    }
}
