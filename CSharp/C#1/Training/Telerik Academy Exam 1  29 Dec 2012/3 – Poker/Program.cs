//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] input = new string[5];
//        for (int i = 0; i < 5; i++)
//        {
//            input[i] = Console.ReadLine();
//        }

//        //string[] input = { "8", "J", "J", "8", "8" };

//        int[] array = new int[5];

//        for (int i = 0; i < 5; i++)
//        {
//            #region Switch
//            switch (input[i])
//            {
//                case "2": array[i] = 2;
//                    break;
//                case "3": array[i] = 3;
//                    break;
//                case "4": array[i] = 4;
//                    break;
//                case "5": array[i] = 5;
//                    break;
//                case "6": array[i] = 6;
//                    break;
//                case "7": array[i] = 7;
//                    break;
//                case "8": array[i] = 8;
//                    break;
//                case "9": array[i] = 9;
//                    break;
//                case "10": array[i] = 10;
//                    break;
//                case "J": array[i] = 11;
//                    break;
//                case "Q": array[i] = 12;
//                    break;
//                case "K": array[i] = 13;
//                    break;
//                case "A": array[i] = 1;
//                    break;
//            }
//            #endregion
//        }

//        Array.Sort(array);

//        int k1 = array[0];
//        int k2 = array[1];
//        int k3 = array[2];
//        int k4 = array[3];
//        int k5 = array[4];

//        if (k1 == k2 && k2 == k3 && k3 == k4 && k4 == k5)
//        {
//            Console.WriteLine("Impossible");
//            return;
//        }

//        if ((k1 == k2 && k2 == k3 && k3 == k4) || (k2 == k3 && k3 == k4 && k4 == k5))
//        {
//            Console.WriteLine("Four of a Kind");
//            return;
//        }

//        if (((k1 == k2 && k2 == k3) && (k4 == k5)) || ((k1 == k2) && (k3 == k4 && k4 == k5)))
//        {
//            Console.WriteLine("Full House");
//            return;
//        }

//        if ((k1 == k2 && k2 == k3) || (k2 == k3 && k3 == k4) || (k3 == k4 && k4 == k5))
//        {
//            Console.WriteLine("Three of a Kind");
//            return;
//        }

//        if ((k1 == k2 && k3 == k4) || (k1 == k2 && k4 == k5) || (k2 == k3 && k4 == k5))
//        {
//            Console.WriteLine("Two Pairs");
//            return;
//        }

//        if (k1 == k2 || k2 == k3 || k3 == k4 || k4 == k5)
//        {
//            Console.WriteLine("One Pair");
//            return;
//        }

//        if (k1 == k2 - 1 && k2 == k3 - 1 && k3 == k4 - 1 && k4 == k5 - 1)
//        {
//            Console.WriteLine("Straight");
//            return;
//        }

//        if (k2 == k3 - 1 && k3 == k4 - 1 && k4 == k5 - 1 && (k1 + 12 == k5))
//        {
//            Console.WriteLine("Straight");
//            return;
//        }

//        Console.WriteLine("Nothing");
//    }
//}