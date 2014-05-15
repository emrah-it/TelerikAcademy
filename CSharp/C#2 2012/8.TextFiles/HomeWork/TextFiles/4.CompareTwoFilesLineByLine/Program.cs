using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader fileOne = new StreamReader("text.txt");
        int count = 1;
        List<int> same = new List<int>();
        List<int> different = new List<int>();
        using (fileOne)
        {
            StreamReader fileTwo = new StreamReader("text2.txt");
            using (fileTwo)
            {
                while (fileOne.Peek() != -1)
                {
                    if (fileOne.ReadLine().CompareTo(fileTwo.ReadLine()) == 0)
                    {
                        same.Add(count);
                    }
                    else
                    {
                        different.Add(count);
                    }
                    count++;

                }
            }
        }
        Console.Write("Same lines: ");
        Console.WriteLine(string.Join(", ",same));
        Console.Write("Same different: ");
        Console.WriteLine(string.Join(", ",different));
        
    }
}
