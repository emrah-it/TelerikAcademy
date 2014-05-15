using System;
using System.Text.RegularExpressions;

class ExtractTextWithWord
{
    static void Main()
    {
        string someText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.";
        string regex = @"(\s*[^\.]*?\bin\b(.|\s)*?\.)";
        MatchCollection matches = Regex.Matches(someText, regex, RegexOptions.IgnoreCase);

        foreach (Match item in matches)
        {
            Console.WriteLine(item.Value);
        }
    }
}
