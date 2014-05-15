using System;
class TringleWithCopyRight
{
    static void Main()
    {
        char copyRight = '\u00A9';
        Console.WriteLine(new string(copyRight, 4));
        Console.WriteLine(copyRight + " " + copyRight);
        Console.WriteLine(copyRight.ToString() + copyRight);
        Console.WriteLine(copyRight);


        
    }
}