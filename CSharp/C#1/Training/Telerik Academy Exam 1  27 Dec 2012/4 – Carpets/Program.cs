using System;
class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int leftRight = (length / 2) - 1;
        int center = 1;
        int diagonals = 0;
        int secondDiagonals = 1;
        bool row = true;

        for (int i = 0; i < length / 2; i++)
        {
            Console.Write(new string('.', leftRight));
            if (row)
            {
                for (int j = 0; j < diagonals; j++)
                {
                    Console.Write("/ ");
                }
                Console.Write(@"/\");
                for (int j = 0; j < diagonals; j++)
                {
                    Console.Write(@" \");
                }
                diagonals++;
                row = false;
            }
            else
            {
                for (int j = 0; j < secondDiagonals; j++)
                {
                    Console.Write("/ ");
                }
                for (int j = 0; j < secondDiagonals; j++)
                {
                    Console.Write(@" \");
                }
                secondDiagonals++;
                row = true;
            }
            Console.Write(new string('.', leftRight));
            leftRight--;
            Console.WriteLine();
        }
        if (row == true)
        {
            row = false;
        }
        else
        {
            row = true;
        }
        leftRight++;
        secondDiagonals--;
        diagonals--;
        for (int i = 0; i < length / 2; i++)
        {
            Console.Write(new string('.', leftRight));
            if (row)
            {
                for (int j = 0; j < diagonals; j++)
                {
                    Console.Write(@"\ ");
                }
                Console.Write(@"\/");
                for (int j = 0; j < diagonals; j++)
                {
                    Console.Write(" /");
                }
                diagonals--;
                row = false;
            }
            else
            {
                for (int j = 0; j < secondDiagonals; j++)
                {
                    Console.Write(@"\ ");
                }
                for (int j = 0; j < secondDiagonals; j++)
                {
                    Console.Write(" /");
                }
                secondDiagonals--;
                row = true;
            }
            Console.Write(new string('.', leftRight));
            leftRight++;
            Console.WriteLine();
            
        }
    }
}
