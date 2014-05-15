using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int secondLength = (length * 2) - 1;
            char[,] road = new char[ secondLength,length];
            for (int i = 0; i < secondLength; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    road[i, j] = '.';
                }
            }
            string direction = "right";
            int col = 0;
            for (int i = 0; i < secondLength; i++)
            {
                if(direction == "right")
                {
                    road[i, col++] = '*';
                    if(col >= length)
                    {
                        col-=2;
                        direction = null;
                    }
                }
                else
                {
                    road[i, col--] = '*';
                }
            }
            for (int i = 0; i < secondLength; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(road[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
