using System;
using System.IO;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        StreamReader file = new StreamReader("text.txt");
        using (file)
        {
            string text = file.ReadToEnd();
            string regex = @"(.+)";
            MatchCollection macthes = Regex.Matches(text, regex, RegexOptions.IgnoreCase);
            for (int i = 0; i < macthes.Count; i++)
            {
                if ((i % 2) == 1)
                {
                    Console.WriteLine(macthes[i].Value);
                }
            }
        }
    }
}
