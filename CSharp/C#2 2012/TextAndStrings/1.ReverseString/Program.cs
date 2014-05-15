using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.Write("Enter String:");
        string someText = Console.ReadLine();

        StringBuilder reversedText = new StringBuilder();

        for (int i = someText.Length - 1;  i  >= 0;  i--)
        {
            reversedText.Append(someText[i]);
        }
        Console.WriteLine(reversedText.ToString());
    } 
}

