using System;
using System.Text.RegularExpressions;
class MakeUpCase
{
    static void Main()
    {
        string someText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string regex = @"<upcase>(?<upcase>(.|\s)*?)</upcase>";
        Console.WriteLine(Regex.Replace(someText, regex, m=> m.Groups["upcase"].Value.ToUpper()));
    }
}
