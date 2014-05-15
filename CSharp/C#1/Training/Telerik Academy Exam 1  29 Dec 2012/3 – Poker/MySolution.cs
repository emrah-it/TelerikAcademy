using System;
class MySolution
{
    static void Main()
    {
        int length = 5;
        int[] k = new int[length];
        for (int i = 0; i < length; i++)
        {
            switch (Console.ReadLine())
            {
                case "A":
                    k[i] = 1;
                    break;
                case "2":
                    k[i] = 2;
                    break;
                case "3":
                    k[i] = 3;
                    break;
                case "4":
                    k[i] = 4;
                    break;
                case "5":
                    k[i] = 5;
                    break;
                case "6":
                    k[i] = 6;
                    break;
                case "7":
                    k[i] = 7;
                    break;
                case "8":
                    k[i] = 8;
                    break;
                case "9":
                    k[i] = 9;
                    break;
                case "10":
                    k[i] = 10;
                    break;
                case "J":
                    k[i] = 11;
                    break;
                case "Q":
                    k[i] = 12;
                    break;
                case "K":
                    k[i] = 13;
                    break;
            }
        }
        Array.Sort(k);
        if (k[0] == k[1] && k[0] == k[2] && k[0] == k[3] && k[0] == k[4])
        {
            Console.WriteLine("Impossible");
            return;
        }
        else if (k[0] == k[1] && k[0] == k[2] && k[0] == k[3] || k[1] == k[2] && k[1] == k[3] && k[1] == k[4])
        {
            Console.WriteLine("Four of a Kind");
            return;
        }
        else if ((k[0] == k[1] && k[0] == k[2]) && (k[3] == k[4]) || (k[0] == k[1]) && (k[2] == k[3] && k[3] == k[4]))
        {
            Console.WriteLine("Full House");
            return;
        }
        else if (k[0] == (k[1] - 1) && k[1] == (k[2] - 1) && k[2] == (k[3] - 1)&& k[3] == (k[4] - 1))
        {
            Console.WriteLine("Straight");
            return;
        }
        else if (k[1] == (k[2] - 1) && k[2] == (k[3] - 1) && k[3] == (k[4] - 1)&& k[4] == (k[0] + 12))
        {
            Console.WriteLine("Straight");
            return;
        }
        else if ((k[0] == k[1] && k[0] == k[2]) || (k[1] == k[2] && k[2] == k[3]) || (k[2] == k[3] && k[3] == k[4]))
        {
            Console.WriteLine("Three of a Kind");
            return;
        }
        else if (k[0] == k[1] && k[2] == k[3])
        {
            Console.WriteLine("Two Pairs");
            return;
        }
        else if (k[0] == k[1] && k[3] == k[4] || k[1] == k[2] && k[3] == k[4] || k[0] == k[1] && k[3] == k[4])
        {
            Console.WriteLine("Two Pairs");
            return;
        }
        else if (k[0] == k[1] || k[1] == k[2] || k[2] == k[3] || k[3] == k[4])
        {
            Console.WriteLine("One Pair");
            return;
        }
        else
        {
            Console.WriteLine("Nothing");
            return;
        }
    }
}
