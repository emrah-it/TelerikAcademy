using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string regex = "(<upcase>(?<hello>.*?)</upcase>)";
        Console.WriteLine(Regex.Replace(text, regex, m => m.Groups["hello"].Value.ToUpper()));
    }
}
