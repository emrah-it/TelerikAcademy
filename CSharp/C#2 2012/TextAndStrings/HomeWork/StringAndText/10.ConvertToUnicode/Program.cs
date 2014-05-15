using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string reg = ".";
        Console.WriteLine(Regex.Replace(text, reg, m => string.Format("\\u{0:X4}", (int)m.Value[0])));
    }
}