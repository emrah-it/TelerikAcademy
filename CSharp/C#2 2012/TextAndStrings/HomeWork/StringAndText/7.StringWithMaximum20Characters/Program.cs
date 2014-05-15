using System;
using System.Text.RegularExpressions;
//Zadachata e reshena po dva nachina pyrviq koito sym go ostavil e prosto za da izpolzvam RegularExpressions
class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string reg = "(?<first>.{0,20})(?<toreplace>.*)";
        System.Console.WriteLine(Regex.Replace(text, reg, m=> string.Format("{0}{1}", m.Groups["first"], new string('*', m.Groups["toreplace"].Value.Length))));


        //if (text.Length > 20)
        //{
        //    text = text.Substring(0, 20).PadRight(text.Length, '*');
        //}
        Console.WriteLine(text);

    }
}
