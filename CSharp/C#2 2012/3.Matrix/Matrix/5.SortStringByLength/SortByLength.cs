using System;
using System.Linq;
class SortByLength
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] stringArray = new string[N];
        for (int i = 0; i < N; i++)
        {
            stringArray[i] = Console.ReadLine();
        }
        var sortedArray = from current in stringArray
                          orderby current.Length
                          select current;
        foreach (var item in sortedArray)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
