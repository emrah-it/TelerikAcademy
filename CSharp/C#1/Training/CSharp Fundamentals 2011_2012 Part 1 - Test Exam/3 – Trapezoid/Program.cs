using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int width = N * 2;
        int height = N + 1;
        char[,] figure = new char[height, width];
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                figure[i, j] = '.';
            }
        }
        for (int i = N; i < width; i++)
        {
            figure[0, i] = '*';
        }
        for (int i = 0; i < height; i++)
        {
            figure[i, width - 1] = '*';
        }
        for (int i = 0; i < width; i++)
        {
            figure[height - 1, i] = '*';
        }
        int col = 0;
        for (int i = height - 1; i >= 0; i--)
        {
            figure[i, col++] = '*';
        }

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(figure[i, j]);
            }
            Console.WriteLine();
        }
    }
}
