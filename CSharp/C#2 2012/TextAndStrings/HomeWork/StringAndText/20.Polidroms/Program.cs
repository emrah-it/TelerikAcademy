using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = @"Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.
Write a program that extracts from a given text all palindromes, e.g.\""ABBA\"",\""lamal\"",\""exe\"".";

        MatchCollection result = Regex.Matches(text, @"\w+");

        PrintAllPolidroms(result);
    }

    private static void PrintAllPolidroms(MatchCollection result)
    {
        foreach (Match item in result)
        {
            if (item.Value.Length > 2)
            {
                if ((item.Value.Length % 2) == 1)
                {
                    if (ChekIt(item, (item.Value.Length / 2)))
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    if (ChekIt(item, (item.Value.Length / 2) ))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }

    private static bool ChekIt(Match item, int length)
    {
        int first = 0;
        int last = item.Value.Length - 1;
        for (int i = 0; i < length; i++)
        {
            if (item.Value[first++] != item.Value[last--])
            {
                return false;
            }
        }
        return true;
    }

}
