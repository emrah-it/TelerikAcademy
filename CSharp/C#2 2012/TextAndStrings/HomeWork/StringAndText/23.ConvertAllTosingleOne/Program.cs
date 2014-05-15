using System;
using System.Text;

class Program
{
    static void Main()
    {
        string text = @"Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 
Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: aaaaabbbbbcdddeeeedssaa  abcdedsa.";
        StringBuilder newText = new StringBuilder();
        char last = text[0];
        newText.Append(last);
        foreach (char item in text)
        {
            if (item != last)
            {
                last = item;
                newText.Append(last);
            }
        }
        Console.WriteLine(newText.ToString());
    }
}
