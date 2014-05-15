using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = @"Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 
Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example:";
        List<string> alpfabet = new List<string>();

        MatchCollection matched = Regex.Matches(text, @"\w+");



        foreach (Match item in matched)
        {
            if (!alpfabet.Contains(item.Value.ToLower()))
            {
                alpfabet.Add(item.Value.ToLower());
            }
        }
        alpfabet.Sort();
        foreach (var item in alpfabet)
        {
            Console.WriteLine("{0}", item);
        }
    }

}
