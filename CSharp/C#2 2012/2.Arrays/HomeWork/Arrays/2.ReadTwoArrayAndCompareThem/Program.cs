using System;
class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] first = new int[length];
        int[] second = new int[length];
        for (int i = 0; i < length; i++)
        {
            first[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
        {
            second[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(first[i] > second[i] ? "First" : "Second");
        }
    }
}
