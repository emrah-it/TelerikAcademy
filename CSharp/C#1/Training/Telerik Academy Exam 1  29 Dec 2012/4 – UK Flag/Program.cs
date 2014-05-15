using System;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int leftRihtDons = -1;
        int centerDots = (N / 2);
        for (int i = 0; i < (N /2); i++)
        {
            centerDots--;
            leftRihtDons++;
            Console.Write(new string('.', leftRihtDons));
            Console.Write(@"\");
            Console.Write(new string('.', centerDots));
            Console.Write("|");
            Console.Write(new string('.', centerDots));
            Console.Write("/");
            Console.WriteLine(new string('.', leftRihtDons));
            
        }
        Console.Write(new string('-', (N /2)));
        Console.Write("*");
        Console.WriteLine(new string('-', (N /2)));
        for (int i = 0; i < (N /2); i++)
        {
            Console.Write(new string('.', leftRihtDons));
            Console.Write(@"/");
            Console.Write(new string('.', centerDots));
            Console.Write("|");
            Console.Write(new string('.', centerDots));
            Console.Write(@"\");
            Console.WriteLine(new string('.', leftRihtDons));
            centerDots++;
            leftRihtDons--;
        }
    }
}
