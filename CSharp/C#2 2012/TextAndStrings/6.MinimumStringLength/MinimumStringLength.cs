using System;
class MinimumStringLength
{    static void Main()
    {
        int lenthOfString = 20;
        Console.Write("Enter String:");
        string someText = Console.ReadLine();

        if(someText.Length < 20)
        {
            someText = someText + new String('*', (lenthOfString - someText.Length));
        }
        Console.WriteLine(someText);
    }
}
