using System;
using System.IO;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        StreamReader file = new StreamReader("text.txt");
        string result;
        using (file)
        {
            result = Regex.Replace(file.ReadToEnd(), "start", "finish");
        }
        StreamWriter fileToSave = new StreamWriter("text.txt");
        using (fileToSave)
        {
            fileToSave.Write(result);
        }
    }
}
