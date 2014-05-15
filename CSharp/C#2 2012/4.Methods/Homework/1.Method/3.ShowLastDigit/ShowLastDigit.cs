using System;
class ShowLastDigit
{
    static void Main()
    {
        int i = int.Parse(Console.ReadLine());
        GetLastDigit(i % 10);
    }
    static void GetLastDigit(int i)
    {
        string[] units = new string[] { "Zero", "One", "Two", "Tree", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        Console.WriteLine(units[i]);
    }
}
