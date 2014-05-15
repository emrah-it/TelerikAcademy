using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        string first = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string second = Console.ReadLine();


        string[] firstDates = Regex.Split(first, @"\.");
        string[] secondDates = Regex.Split(second, @"\.");
        DateTime firstDateTime = new DateTime(int.Parse(firstDates[2]), int.Parse(firstDates[1]), int.Parse(firstDates[0]));
        DateTime secondDateTime = new DateTime(int.Parse(secondDates[2]), int.Parse(secondDates[1]), int.Parse(secondDates[0]));
        
        if (firstDateTime.CompareTo(secondDateTime) > 0)
        {
            DateTime current = firstDateTime;
            firstDateTime = secondDateTime;
            secondDateTime = current;
        }

        int sum = 0;
        while (firstDateTime != secondDateTime)
        {
            firstDateTime = firstDateTime.AddDays(1);
            sum++;
        }
        Console.WriteLine(sum);

    }
}
