using System;
class Program
{
    static void Main()
    {
        string text = "http://www.devbg.org/forum/index.php";
        Uri toParse = new Uri(text);
        Console.WriteLine(toParse.Scheme);
        Console.WriteLine(toParse.Host);
        Console.WriteLine(toParse.AbsolutePath);
    }
}
