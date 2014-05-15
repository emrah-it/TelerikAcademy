using System;
using System.Text.RegularExpressions;
class ReplaceForbiddenWords
{
    static void Main()
    {
        string someText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string replace = @"\b(PHP|CLR|Microsoft)\b";

        Console.WriteLine(Regex.Replace(someText, replace,m => new string('*', m.Length)));
    }
}
