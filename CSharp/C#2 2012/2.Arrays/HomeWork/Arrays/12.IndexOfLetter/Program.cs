using System;
class Program
{
    static void Main()
    {
        char[] arrayOfLetter = new char[26];
        for (int i = 0; i < 26; i++)
        {
            arrayOfLetter[i] = (char)('A' + i);
        }

        string enteredString = Console.ReadLine();
        for (int i = 0; i < enteredString.Length; i++)
        {
            for (int j = 0; j < arrayOfLetter.Length; j++)
            {
                if (enteredString[i] == arrayOfLetter[j])
                {
                    Console.WriteLine("{0}", j + 1);
                    break;
                }
            }
            //Console.WriteLine("{0}",enteredString[i] - (char)('A' - 1));
         }
        Console.WriteLine();
    }
}
