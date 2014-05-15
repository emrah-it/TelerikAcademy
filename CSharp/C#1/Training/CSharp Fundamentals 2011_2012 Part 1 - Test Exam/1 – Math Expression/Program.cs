using System;
using System.Globalization;
using System.Threading;
class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());
        double result = ((N * N) + ((1 / (M * P)) + 1337)) / (N - ((double)128.523123123 * P)) + (double)Math.Sin( (int)M % 180 );
        Console.WriteLine("{0:0.000000}", result);

    }
}
