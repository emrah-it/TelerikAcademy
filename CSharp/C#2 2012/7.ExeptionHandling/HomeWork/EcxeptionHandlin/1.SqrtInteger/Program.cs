using System;
class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        try
        {
            double number = double.Parse(first);
            if (number >= 0)
            {
                Console.WriteLine(Math.Sqrt(number));
            }
            else
            {
                throw new ArgumentException();
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("InvalidNumber");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }

    }
}
