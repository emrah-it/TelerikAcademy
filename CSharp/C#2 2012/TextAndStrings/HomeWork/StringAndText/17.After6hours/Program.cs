using System;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Enter date and time in format day.month.year hour:minute:second ");
        string text = Console.ReadLine();

        string dateReg = @"(?<date>\d{1,2}\.\d{1,2}\.\d{1,4})";
        string timeReg = @"(?<time>\d{1,2}\s*:\s*\d{1,2}\s*:\s*\d{1,2})";


        Match date = Regex.Match(text, dateReg);
        Match time = Regex.Match(text, timeReg);

        DateTime now = ConverToDateTime(date, time);

        now = now.AddMinutes(390);
        string[] dayOfWeebBulgaria = {"Неделя", "Понеделник", "Вторник", "Сряда", "Четвъртак", "Петък", "Събота",  };
        Console.WriteLine("{0}.{1}.{2} {3}:{4}:{5} {6}", now.Day, now.Month, now.Year, now.Hour, now.Minute, now.Second, dayOfWeebBulgaria[(int)now.DayOfWeek]);
    }

    private static DateTime ConverToDateTime(Match date, Match time)
    {
        string[] dateSplit = Regex.Split(date.Value, @"\.");
        string[] timeSplit = Regex.Split(time.Value, @"\:");
        return new DateTime(int.Parse(dateSplit[2]), int.Parse(dateSplit[1]), int.Parse(dateSplit[0]), int.Parse(timeSplit[0]), int.Parse(timeSplit[1]), int.Parse(timeSplit[2]));
        

    }

}
