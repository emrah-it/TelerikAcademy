using System;
class FirstGreatrThanSecond
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        if(first > second)
        {
            int current = second;
            second = first;
            first = current;
        }
        Console.WriteLine(first);
        Console.WriteLine(second);
    }
}
