using System;

class Program
{
    static void Main()
    {
        int witdh = int.Parse(Console.ReadLine());
        int leftRightDoth = (witdh / 2) - 1;
        int midleDoth = 0;
        int current = 0;
        for (current = 0; ; current++)
        {
            Console.Write(new string('.', leftRightDoth));
            Console.Write("#");
            Console.Write(new string('.', midleDoth));
            Console.Write("#");
            Console.Write(new string('.', leftRightDoth));
            Console.WriteLine();
            if (leftRightDoth == 0)
                break;

            leftRightDoth--;
            midleDoth += 2;
        }
        for (current++; current < witdh - (witdh / 4); current++)
        {
            Console.Write(new string('.', leftRightDoth));
            Console.Write("#");
            Console.Write(new string('.', midleDoth));
            Console.Write("#");
            Console.Write(new string('.', leftRightDoth));
            Console.WriteLine();
            leftRightDoth++;
            midleDoth -= 2;
        }
        Console.WriteLine(new string('-', witdh));
        leftRightDoth = 0;
        int slashs = witdh / 2;
        for (int i = 0; i < (witdh / 2); i++)
        {
            Console.Write(new string('.', leftRightDoth));
            Console.Write(new string('\\', slashs));
            Console.Write(new string('/', slashs));
            Console.Write(new string('.', leftRightDoth));
            Console.WriteLine();
            slashs--;
            leftRightDoth++;
        }
    }
}