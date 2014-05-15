using System;
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int left = N - 2;
            int right = N - 2;
            int center = 1;
            for (int i = 0; i < N - 1; i++)
            {
                Console.WriteLine(new string('.',left--) + new string('*', center++) + new string('.',right--));
                center++;
            }
            Console.WriteLine(new string('.', N-2) + "*" + new string('.',N - 2));
            
        }
    }
