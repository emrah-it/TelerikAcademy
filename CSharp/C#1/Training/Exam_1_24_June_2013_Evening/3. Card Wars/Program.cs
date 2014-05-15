using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int games = int.Parse(Console.ReadLine());

        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
        int[] points = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13 };
        string[] one = new string[3];
        string[] two = new string[3];
        BigInteger sumPlayerOne = 0;
        BigInteger sumPlayerTwo = 0;
        int gamesOne = 0;
        int gamesTwo = 0;
        int currentOne = 0;
        int currentTwo = 0;
        bool oneX = false;
        bool twoX = false;
        for (int i = 0; i < games; i++)
        {
            currentTwo = currentOne = 0;
            one[0] = Console.ReadLine();
            one[1] = Console.ReadLine();
            one[2] = Console.ReadLine();
            foreach (var item in one)
            {
                for (int j = 0; j < cards.GetLength(0); j++)
                {
                    if (item == cards[j])
                    {
                        currentOne += points[j];
                        break;
                    }
                    else if (item == "X")
                    {
                        oneX = true;
                        break;
                    }
                    else if (item == "Z")
                    {
                        sumPlayerOne *= 2;
                        break;
                    }
                    else if (item == "Y")
                    {
                        sumPlayerOne -= 200;
                        break;
                    }

                }
            }

            two[0] = Console.ReadLine();
            two[1] = Console.ReadLine();
            two[2] = Console.ReadLine();
            foreach (var item in two)
            {
                for (int j = 0; j < cards.GetLength(0); j++)
                {
                    if (item == cards[j])
                    {
                        currentTwo += points[j];
                        break;
                    }
                    else if (item == "X")
                    {
                        twoX= true;
                        break;
                    }
                    else if (item == "Z")
                    {
                        sumPlayerTwo *= 2;
                        break;
                    }
                    else if (item == "Y")
                    {
                        sumPlayerTwo -= 200;
                        break;
                    }

                }
            }

            if (oneX && twoX)
            {
                sumPlayerOne += 50;
                sumPlayerTwo += 50;

                oneX = false;
                twoX = false;
            }
            else if (oneX)
            {
                break;
            }
            else if (twoX)
            {
                break;
            }

            if (currentOne > currentTwo)
            {
                sumPlayerOne += currentOne;
                gamesOne++;
            }
            else if (currentOne < currentTwo)
            {
                sumPlayerTwo += currentTwo;
                gamesTwo++;
            }

        }
        if (oneX)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");

        }
        else if (twoX)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");

        }
        else if (sumPlayerTwo > sumPlayerOne)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", sumPlayerTwo);
            Console.WriteLine("Games won: {0}", gamesTwo);
        }
        else if (sumPlayerOne > sumPlayerTwo)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", sumPlayerOne);
            Console.WriteLine("Games won: {0}", gamesOne);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", sumPlayerOne);
        }
        return;
    }
}