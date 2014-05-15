using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}
