using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = @"Write a program that reads a text file and prints on the console its odd lines.
Write a program that concatenates two text files into another text file.
Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.
Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.
";
        string regex = @"(.+)";
        MatchCollection macthes = Regex.Matches(text, regex, RegexOptions.IgnoreCase);
        int line = 0;
        for (int i = 0; i < macthes.Count; i++)
        {
            if ((i%2) == 1)
            {
                Console.WriteLine(macthes[i].Value);
            }
        }
    }
}
