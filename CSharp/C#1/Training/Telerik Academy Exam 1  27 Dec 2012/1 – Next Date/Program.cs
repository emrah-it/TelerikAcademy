using System;
class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        DateTime nextDate = new DateTime(year, month, day);
        nextDate = nextDate.AddDays(1);
        Console.WriteLine(nextDate.Day + "." + nextDate.Month + "." + nextDate.Year);
    }
}
