using System;
namespace MyNameSpace
{
    public class Program
    {
        static void Main()
        {
            int[] number = new int[] { 1, 5, 9, 8, 7, 4, 5, 6, 4, 1, 3, 1, 5, 16, 1, 8, 48, 74, 9, 41, 6, 1, 61, 51, 6, 18, 89, 41 };
            int position = int.Parse(Console.ReadLine());
            if (ChekNeighboors(number, position) == 1)
            {
                Console.WriteLine("Biggest in position {0}", number[position]);
            }
            else
            {
                Console.WriteLine("Not");
            }
        }

        public static int ChekNeighboors(int[] number, int position)
        {
            return GetMax(number[position - 1], GetMax(number[position], number[position + 1])) == number[position] ? 1 : -1;
        }
        private static int GetMax(int a, int b)
        {
            return (a > b ? a : b);
        }

    }
}
