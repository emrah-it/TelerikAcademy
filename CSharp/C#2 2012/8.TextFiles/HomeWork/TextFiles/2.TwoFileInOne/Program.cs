using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader file = new StreamReader("text.txt");
        using (file)
        {
            StreamReader file2 = new StreamReader("text2.txt");
            using (file2)
            {
                StreamWriter file3 = new StreamWriter("text3.txt");
                using (file3)
                {
                    file3.Write(file.ReadToEnd() + file2.ReadToEnd());
                }
            }       
        }
    }
}
