using System;
using System.Globalization;
using System.Threading;
class CoffeeVendingMachine
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int numberTree = int.Parse(Console.ReadLine());
        int numberFour = int.Parse(Console.ReadLine());
        int numberFive = int.Parse(Console.ReadLine());

        double amount = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        double change = amount - price;
        double moneyInMachine =
            numberOne * 0.05 +
            numberTwo * 0.1 +
            numberTree * 0.2 +
            numberFour * 0.5 +
            numberFive * 1;

        if (change < 0)
        {
            Console.WriteLine("More {0:F2}", price - amount);
        }
        else if ((change >= 0) && (moneyInMachine - change >= 0))
        {
            Console.WriteLine("Yes {0:F2}", moneyInMachine - change);
        }
        else if ((change >= 0) && (moneyInMachine - change < 0))
        {
            Console.WriteLine("No {0:F2}", Math.Abs(moneyInMachine - change));
        }

    }
}