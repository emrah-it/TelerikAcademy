using System;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int leftRightDots = N;
        int middleDots = 0;
        int height = 6 + ((N - 3) / 2) * 3;
        int length = ((height * 2) / 3);
        Console.Write(new string('.', leftRightDots));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('.', leftRightDots--));

        for (int i = 2; i < length; i++)
        {
            Console.Write(new string('.', leftRightDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.WriteLine(new string('.', leftRightDots));
            leftRightDots--;
            middleDots++;
        }
        Console.WriteLine(new string('*', ((N * 2) + 1)));
        leftRightDots++;
        middleDots--;
        for (int i = 1; i < length / 2; i++)
        {
            Console.Write(new string('.', leftRightDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.WriteLine(new string('.', leftRightDots));
            leftRightDots++;
            middleDots--;
        }
        Console.Write(new string('.', leftRightDots));
        Console.Write(new string('*', (((N * 2) + 1) - (2 * leftRightDots))));
        Console.WriteLine(new string('.', leftRightDots));
    }
}