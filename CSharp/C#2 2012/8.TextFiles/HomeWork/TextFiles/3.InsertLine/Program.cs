using System;
using System.IO;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        StreamReader file = new StreamReader("text.txt");
        using (file)
        {
            StreamWriter fileToSave = new StreamWriter("text2.txt");
            using (fileToSave)
            {
                string text = file.ReadToEnd();
                MatchCollection allLines = Regex.Matches(text, @".+");
                for (int i = 0; i < allLines.Count; i++)
                {
                    fileToSave.WriteLine("{0}:{1}", i + 1, allLines[i].Value);
                }
            }
            
        }
    }
}
