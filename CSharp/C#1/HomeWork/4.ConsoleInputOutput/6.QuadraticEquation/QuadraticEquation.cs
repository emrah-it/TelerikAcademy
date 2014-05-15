using System;
class QuadraticEquation
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());

        decimal D = b * b - (4 * a * c);
        if (D < 0)
        {
            Console.WriteLine("No real roots");
        }
        else if (D == 0)
        {
            Console.WriteLine(-b / (2 * a));
        }
        else
        {
            Console.WriteLine("First root: {0}", (-a + D)/ (2 * a));
            Console.WriteLine("Second root: {0}", (-a - D) / (2 * a));
        }
    }
}
