using System;
class Program
{
    static void Main()
        {
            Console.WriteLine("Enter string");
            string text = Console.ReadLine();
            char[] reverse = text.ToCharArray();
            Array.Reverse(reverse);
            Console.WriteLine(reverse);
        }
}