using System;
using System.IO;

class LargestArea
{
    static void Main()
    {
        string[] separetor = { " " };

        StreamReader myConsole = new StreamReader(@"C:\Users\Admin\Desktop\Test.txt");
        using (myConsole)
        {
            int row = int.Parse(myConsole.ReadLine());
            int col = int.Parse(myConsole.ReadLine());
            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                var inputLine = myConsole.ReadLine().Split(separetor, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = int.Parse(inputLine[j]);
                }
            }
            PrintMatrix(matrix);
            int number = int.MinValue;
            int maxArea = int.MinValue;
            FindMax(matrix, ref  number, ref maxArea);
            Console.WriteLine("Number is: " + number);
            Console.WriteLine("Equal Area is: "+ maxArea);
        }
    }

    private static void FindMax(int[,] matrix, ref int number, ref int maxArea)
    {
        bool[,] alreadyCheked = new bool[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                BeginPossition(alreadyCheked);
                int currenSolution = DFS(matrix, alreadyCheked, i, j, matrix[i, j]);
                if (currenSolution > maxArea)
                {
                    maxArea = currenSolution;
                    number = matrix[i, j];
                }
            }
        }
    }

    private static int DFS(int[,] matrix, bool[,] alreadyCheked, int row, int col, int searchedNumber)
    {
        int sum = 0;
        if (searchedNumber != matrix[row, col] || alreadyCheked[row, col])
        {
            return 0;
        }
        else
        {
            sum++;
            alreadyCheked[row, col] = true;
        }

        if (row > 0)
        {
            sum += DFS(matrix, alreadyCheked, row - 1, col, searchedNumber);
        }

        if (col > 0)
        {
            sum += DFS(matrix, alreadyCheked, row, col - 1, searchedNumber);
        }

        if (row < matrix.GetLength(0) - 1)
        {
            sum += DFS(matrix, alreadyCheked, row + 1, col, searchedNumber);
        }

        if (col < matrix.GetLength(1) - 1)
        {
            sum += DFS(matrix, alreadyCheked, row, col + 1, searchedNumber);
        }

        return sum;
    }

    private static void BeginPossition(bool[,] alreadyCheked)
    {
        for (int i = 0; i < alreadyCheked.GetLength(0); i++)
        {
            for (int j = 0; j < alreadyCheked.GetLength(1); j++)
            {
                alreadyCheked[i, j] = false;
            }
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}