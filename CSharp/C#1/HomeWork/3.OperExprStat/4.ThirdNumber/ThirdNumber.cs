using System;
class ThirdNumber
{
    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(number[number.Length - 3] == '7' ? "Seven" : "Not");
    }
}
