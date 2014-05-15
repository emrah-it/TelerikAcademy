using System;
class Program
{
    static void Main()
    {
        decimal radius = decimal.Parse(Console.ReadLine());
        decimal perimeter = 2 * (decimal)Math.PI * radius;
        decimal area = (decimal)Math.PI * radius * radius;
        Console.WriteLine("Perimeter: {0}\nArea: {1}", perimeter, area);
    }
}
