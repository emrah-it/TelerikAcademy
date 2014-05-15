using System;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            int current = i;
            for (int j = 0; j <= N; j++)
            {
                Console.Write("{0} ", current++);
            }
            Console.WriteLine();
        }
    }
}
