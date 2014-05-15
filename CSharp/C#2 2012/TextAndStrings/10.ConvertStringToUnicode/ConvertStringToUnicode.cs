using System;
using System.Text;

public class SamplesEncoding
{
    static void Main()
    {
        Console.WriteLine(GiveUnicode("Hi!"));    
    }

    private static string GiveUnicode(string p)
    {
        StringBuilder converted = new StringBuilder();
        for (int i = 0; i < p.Length; i++)
        {
            converted.AppendFormat("\\u{0:X4}", (int)p[i]);
        }
        return converted.ToString();
    }

}
