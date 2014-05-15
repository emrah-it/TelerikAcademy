using System;
class FillMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = 0;
            }
        }
        int count = 1;
        //FirstA(n, matrix, count);

        //SecondB(n, matrix, count);

        //ThirdC(n, matrix, count);
        FourthD(n, matrix, count);
    }

    private static void FourthD(int n, int[,] matrix, int count)
    {
        string direction = "down";
        int row = 0, col = 0;
        while (count <= n * n)
        {
            if (direction == "down")
            {
                if (row == n || matrix[row, col] != 0)
                {
                    row--;
                    col++;
                    direction = "right";
                }
                else
                {
                    matrix[row++, col] = count++;
                }
            }
            else if (direction == "right")
            {
                if (col == n || matrix[row, col] != 0)
                {
                    col--;
                    row--;
                    direction = "up";
                }
                else
                {
                    matrix[row, col++] = count++;
                }
            }
            else if (direction == "up")
            {
                if (row == -1 || matrix[row, col] != 0)
                {
                    row++;
                    col--;
                    direction = "left";
                }
                else
                {
                    matrix[row--, col] = count++;
                }
            }
            else if (direction == "left")
            {
                if (col == -1 || matrix[row, col] != 0)
                {
                    col++;
                    row++;
                    direction = "down";
                }
                else
                {
                    matrix[row, col--] = count++;
                }
            }
        }
        Print(matrix);
        return ;
    }

    private static void ThirdC(int n, int[,] matrix, int count)
    {
        int row = n - 1;
        int col = 0;
        while (row != -1)
        {
            int currentRow = row--;
            int currentCol = col;
            while (currentRow != n && currentCol != n)
            {
                matrix[currentRow++, currentCol++] = count++;
            }
        }
        row = 0;
        col = 1;
        while (col != n)
        {
            int currentRow = row;
            int currentCol = col++;
            while (currentRow != n && currentCol != n)
            {
                matrix[currentRow++, currentCol++] = count++;
            }
        }
        Print(matrix);
        return;
    }

    private static void SecondB(int n, int[,] matrix, int count)
    {
        for (int i = 0; i < n; i++)
        {
            if ((i % 2) == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = count++;
                }
            }
            else
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    matrix[j, j] = count++;
                }
            }
        }
        Print(matrix);
        return;
    }

    private static void FirstA(int n, int[,] matrix, int count)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, i] = count++;
            }
        }
        Print(matrix);
        return;
    }
    static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
