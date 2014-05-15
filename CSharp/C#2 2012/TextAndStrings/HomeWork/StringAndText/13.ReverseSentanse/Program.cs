using System;
using System.Collections;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = @"C# is not C++, not PHP and not Delphi!";
        string regex = @"[ ]|\,|\.|\?|\!";
        string[] splitedWords = Regex.Split(text, regex, RegexOptions.IgnorePatternWhitespace);
        Stack words = new Stack();
        for (int i = 0; i < splitedWords.GetLength(0) - 2; i++)
        {
            words.Push(splitedWords[i]);
        }


        MatchCollection splits = Regex.Matches(text, regex);
        foreach (var item in splits)
        {
            if (words.Count > 0)
            {
                Console.Write(words.Pop());

            }
            Console.Write(item);
        }
    }
}

