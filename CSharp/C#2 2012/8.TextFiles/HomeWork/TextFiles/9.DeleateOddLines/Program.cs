using System;

using System.IO;
using System.Text.RegularExpressions;
class OddLine
{
    static void Main()
    {
        StreamReader file = new StreamReader("text.txt");
        MatchCollection macthes;
        using (file)
        {
            string text = file.ReadToEnd();
            string regex = @"(.+)";
            macthes = Regex.Matches(text, regex, RegexOptions.IgnoreCase);
        }
        StreamWriter fileTwo = new StreamWriter("text.txt");
        using (file)
        {
            for (int i = 0; i < macthes.Count; i++)
            {
                if ((i % 2) == 1)
                {
                    fileTwo.WriteLine(macthes[i].Value);
                }
            }
        }
    }
}
