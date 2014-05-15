using System;
using System.Text.RegularExpressions;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader file = new StreamReader("text.txt");

        using (file)
        {
            int matrixSize = int.Parse(file.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            string regex = @"\s+";
            for (int i = 0; i < matrixSize; i++)
            {
                string[] numbers = Regex.Split(file.ReadLine(), regex);
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }
            FindMax(matrix);
        }
    }

    private static void FindMax(int[,] matrix)
    {
        int max = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int currentSum = 0;
                for (int k = i; k < i + 2; k++)
                {
                    for (int l = j; l < j + 2; l++)
                    {
                        currentSum += matrix[k, l];
                    }
                }
                if (currentSum > max)
                {
                    max = currentSum;
                }
            }
        }
        Console.WriteLine(max);
    }
}
