using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("fr-CA");
        string text = "asdf asf asdf sss dd 1.2.1989 asdfas dfa sdfa sdfa sdf a 1.5464 asdfa sdf asf a 1.2.55";
        string dateTimeReg = @"[\s](?<dateTime>\d{1,2}\.\d{1,2}\.\d{1,4})";

        MatchCollection result = Regex.Matches(text, dateTimeReg);

        foreach (Match item in result)
        {

            string[] currentDateTime = Regex.Split(item.Value, @"\.");
            DateTime firstDateTime = new DateTime(int.Parse(currentDateTime[2]), int.Parse(currentDateTime[1]), int.Parse(currentDateTime[0]));
            Console.WriteLine(firstDateTime);
        }
    }
}
