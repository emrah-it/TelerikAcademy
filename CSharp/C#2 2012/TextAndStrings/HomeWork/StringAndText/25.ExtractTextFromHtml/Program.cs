using System;
using System.Collections;
using System.Text;
class Program
{
    static void Main()
    {
        string html = @"<html><head><title>News</title></head><body><p><a href=\""http://academy.telerik.com\"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        Stack scope = new Stack();
        StringBuilder text = new StringBuilder();
        for (int i = 0; i < html.Length; i++)
        {
            if (html[i] == '<')
            {
                scope.Push('<');
            }
            else if(html[i] == '>')
            {
                scope.Pop();
            }
            else if (scope.Count == 0)
            {
                text.Append(html[i]);
            }
        }
        Console.WriteLine(text);
    }
}
