using System;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int center = N;
        int leftRight = 0;
        for (int i = 0; i < (N / 2) ; i++)
        {
            Console.Write(new string('.', leftRight));
            Console.Write(new string('*', center));
            Console.Write(new string('.', leftRight));
            Console.WriteLine();
            center -= 2;
            leftRight++;
        }
        center = 1;
        leftRight = N / 2;
        for (int i = 0; i < (N / 2) + 1; i++)
        {
            Console.Write(new string('.', leftRight));
            Console.Write(new string('*', center));
            Console.Write(new string('.', leftRight));
                Console.WriteLine();
            center += 2;
            leftRight--;
        }
    }
}
