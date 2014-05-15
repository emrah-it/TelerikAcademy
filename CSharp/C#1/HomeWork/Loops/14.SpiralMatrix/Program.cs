using System;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = 0;
            }
        }
        string direction = "right";
        int row = 0;
        int col = 0;

        for (int i = 1; i <= N * N; i++)
        {
            if (direction == "right" )
            {
                if (col == N || matrix[row, col] != 0)
                {
                    i--;
                    row++;
                    col--;
                    direction = "down";
                }
                else
                {
                    matrix[row, col++] = i;
                }
            }
            else if (direction == "down")
            {
                if (row == N || matrix[row, col] != 0)
                {
                    i--;
                    row--;
                    col--;
                    direction = "left";
                }
                else
                {
                    matrix[row++, col] = i;
                }
            }
            else if (direction == "left")
            {
                if (col == -1 || matrix[row, col] != 0)
                {
                    i--;
                    row--;
                    col++;
                    direction = "up";
                }
                else
                {
                    matrix[row, col--] = i;
                }
            }
            else if (direction == "up")
            {
                if (row == -1 || matrix[row, col] != 0)
                {
                    i--;
                    row++;
                    col++;
                    direction = "right";
                }
                else
                {
                    matrix[row--, col] = i;
                }
            }
        }
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j]); 
            }
            Console.WriteLine();
        }
    }
}
