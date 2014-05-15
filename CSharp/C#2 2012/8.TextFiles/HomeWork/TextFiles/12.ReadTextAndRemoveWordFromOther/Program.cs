using System;
using System.IO;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        StreamReader file = new StreamReader("keyWord.txt");
        string result;
        using (file)
        {
            string[] keyword = Regex.Split(file.ReadToEnd(), @"\s+");
            StreamReader fileTwo = new StreamReader("text.txt");
            using (fileTwo)
            {
                result = fileTwo.ReadToEnd();
                foreach (string item in keyword)
                {
                    string regex = @"\b" + item + @"\b";
                    result = Regex.Replace(result, regex, "");
                }
            }
        }
        StreamWriter fileToWrite = new StreamWriter("text.txt");
        using (fileToWrite)
        {
            fileToWrite.Write(result);
        }

    }
}
