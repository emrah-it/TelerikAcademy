using System;
using System.IO;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.Write("Enter Word you want to put: ");
        string replease = Console.ReadLine();
        StreamReader file = new StreamReader("text.txt");
        string result;
        using (file)
        {
            result = Regex.Replace(file.ReadToEnd(), @"\w+", replease);
        }
        StreamWriter fileToSave = new StreamWriter("text.txt");
        using (fileToSave)
        {
            fileToSave.Write(result);
        }
    }
}
