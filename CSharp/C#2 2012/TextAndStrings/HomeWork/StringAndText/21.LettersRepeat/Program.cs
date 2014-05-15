using System;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        string text = @"Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 
Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example:";
        SortedDictionary<string, int> alpfabet = new SortedDictionary<string, int>();

        foreach (char item in text.ToLower())
        {
            if (item >= 'a' && item <= 'z' || item >= 'A' && item <= 'Z')
            {
                if (!alpfabet.ContainsKey(item.ToString()))
                {
                    alpfabet.Add(item.ToString(), 1);
                }
                else
                {
                    alpfabet[item.ToString()]++;
                }
            }
        }
        foreach (var item in alpfabet)
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }
    }

}
