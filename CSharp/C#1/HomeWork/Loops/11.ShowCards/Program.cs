using System;
class Program
{
    static void Main()
    {
        string[] suit = new string[] { "♠", "♥", "♦", "♣" };
        for (int i = 0; i < 4; i++)
        {
            for (int j = 1; j <= 13; j++)
            {
                Console.Write(suit[i] + " ");
                switch (j)
                {
                    case 1:
                        Console.WriteLine("Ace");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Tree");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    case 10:
                        Console.WriteLine("Ace");
                        break;
                    case 11:
                        Console.WriteLine("Jack");
                        break;
                    case 12:
                        Console.WriteLine("Queen");
                        break;
                    case 13:
                        Console.WriteLine("King");
                        break;
                }
            }
        }

    }
}
