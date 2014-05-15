using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = @".NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes";
        Console.WriteLine(text);
        string search = Console.ReadLine();
        string regex = @"(^|\s+)" + search + @" –\s+(?<definition>.+)";
        MatchCollection matched = Regex.Matches(text, regex);
        foreach (Match item in matched)
        {
            Console.WriteLine(item.Groups["definition"].Value);
        }
    }
}
