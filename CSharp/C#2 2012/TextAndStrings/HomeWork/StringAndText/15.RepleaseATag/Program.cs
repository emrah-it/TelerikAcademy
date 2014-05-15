using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string regexTag = @"(<\s*a\s*href\s*=\s*)(\""(?<link>[^""]*)\""\S*)(>)(?<inside>(.|\s)*?)(?<endtag><\s*/a\s*>)";
        string text2 = Regex.Replace(text, regexTag, m => string.Format("{0}{1}{2}{3}{4}", "[URL=", m.Groups["link"], "]", m.Groups["inside"], "[/URL]"));
        Console.WriteLine(text2);
    }
}
