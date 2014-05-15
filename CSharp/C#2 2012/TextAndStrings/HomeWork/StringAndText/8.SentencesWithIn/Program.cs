using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string regex = @"\w\s*[^.]*?\bin\b\s*[^.]*\.";
        MatchCollection result = Regex.Matches(text, regex);
        foreach (Match item in result)
        {
            Console.WriteLine(item.Value);
        }
    }
}
