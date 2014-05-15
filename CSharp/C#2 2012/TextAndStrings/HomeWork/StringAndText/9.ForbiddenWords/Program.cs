using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string regex = @"(?<replece>\b(PHP|CLR|Microsoft)\b)";
        Console.WriteLine(Regex.Replace(text, regex, m => (new string('*', m.Groups["replece"].Value.Length))));
    }
}
