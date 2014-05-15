using System;
using MyNameSpace;
class Program
{
    static void Main()
    {
        int[] number = new int[] { 1, 5, 9, 8, 7, 4, 5, 6, 4, 1, 3, 1, 5, 16, 1, 8, 48, 74, 9, 41, 6, 1, 61, 51, 6, 18, 89, 41 };
        if (FindNeighbors(number) == 1)
        {
            Console.WriteLine("Find");
        }
        else
        {
            Console.WriteLine("Lose");
        }
    }

    private static int FindNeighbors(int[] number)
    {
        for (int i = 1; i < number.Length - 1; i++)
        {
            if (1 == MyNameSpace.Program.ChekNeighboors(number, i))
            {
                Console.WriteLine(number[i]);
                return 1;
                break;
            }

        }
        return -1;
    }
}
