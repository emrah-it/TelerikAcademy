using System;
class IsPrime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < 100; i++)
        {
            if ((n % i) == 0)
            {
                if(i == n)
                {
                    Console.WriteLine("Prime");
                    return;
                }
                break;
            }
        }
        Console.WriteLine("Not");
    }
}
