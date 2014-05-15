using System;
class GreaterNumber
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine(first > second ? first : second);
    }
}
