using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = "asdfa@asgd.bg aasdf asdf asdf aed fqaweg asgaeg awe@asga.gr asedfa efa wefa wefa ewe awerg@ased-asd.bg asdfasdf asdf awe asd awe g";
        string regText = @"(?<mail>[^\s][a-zA-Z][[a-zA-Z]{0,50}@[a-zA-Z][[a-zA-Z\.\-]{0,50}\.[a-zA-Z]{2,4})";
        MatchCollection result = Regex.Matches(text, regText);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
