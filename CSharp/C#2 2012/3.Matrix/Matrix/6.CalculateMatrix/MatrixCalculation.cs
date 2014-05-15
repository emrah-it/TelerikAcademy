using System;
class MatrixCalculation
{
    static void Main()
    {


        Matrix matOne = new Matrix(2, 2);
        Matrix matTwo = new Matrix(2, 2);

        

        for (int i = 0; i < matOne.GetLength(0); i++)
        {
            for (int j = 0; j < matOne.GetLength(0); j++)
            {
                matOne[i, j] = matTwo[i, j] = i + j;
            }
        }
        Matrix result = matTwo + matTwo;
        Console.WriteLine(result.ToString());
    }
}
