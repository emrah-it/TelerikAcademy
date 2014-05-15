using System;
using System.Collections;
using System.Text;
using System.IO;
class Program
{
    static void Main()
    {
        string readed;

        StreamReader file = new StreamReader("Text.txt");
        using (file)
        {
            readed = file.ReadToEnd();
        }
        Stack scope = new Stack();
        StringBuilder text = new StringBuilder();
        for (int i = 0; i < readed.Length; i++)
        {
            if (readed[i] == '<')
            {
                scope.Push('<');
            }
            else if (readed[i] == '>')
            {
                scope.Pop();
            }
            else if (scope.Count == 0)
            {
                text.Append(readed[i]);
            }
        }
        StreamWriter fileTwo = new StreamWriter("Text.txt");
        using (fileTwo)
        {
            fileTwo.Write(text);
        }
        Console.WriteLine(text);
    }
}
