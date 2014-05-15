using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine((number % 5)== (number % 7)?"Can divided" : "Cant divided");
    }
}
