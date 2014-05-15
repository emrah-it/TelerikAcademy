using System;
class RectangulerMatrinxNandM
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        int[,] matrix = new int[row, col];
        EnterMatrix(row, col, matrix);
        int maximal = int.MinValue;
        for (int i = 0; i < row - 2 ; i++)
        {
            for (int j = 0; j < col - 2; j++)
            {
                int currentSum = 0;
                for (int currentRow = i; currentRow < i + 3; currentRow++)
                {
                    for (int currentCol = j; currentCol < j + 3; currentCol++)
                    {
                        currentSum += matrix[currentRow, currentCol];
                    }
                }
                maximal = Math.Max(currentSum, maximal);
            }
        }
    }

    private static void EnterMatrix(int row, int col, int[,] matrix)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return ;
    }
}
