using System;
class Program
{
    static void Main()
    {
        char[] first = new char[] { 'a', 'w', 'e', 'g' };
        char[] second = new char[] { 's', 'f', 'w', 't' };

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(first[i].CompareTo(second[i]) < 0? "First":"Second");
        }
    }
}