using System;
using System.Text;
public class Matrix
{

    private int[,] matrix;
    public Matrix(int row, int col)
    {
        this.matrix = new int[row, col];
    }
    public int this[int row, int col]
    {
        get
        {
            return matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }
    public int GetLength(int dimension)
    {
        if (dimension == 0)
        {
            return this.matrix.GetLength(0);
        }
        else if (dimension == 1)
        {
            return this.matrix.GetLength(1);
        }
        throw new IndexOutOfRangeException("Out of range");

    }

    public static Matrix operator +(Matrix one, Matrix two)
    {
        return AddingSubstracting(one, two, true);
    }

    private static Matrix AddingSubstracting(Matrix one, Matrix two, bool SubscribeOrAdd)
    {

        if (one.GetLength(0) != one.GetLength(0) || one.GetLength(1) != one.GetLength(1))
        {
            throw new IndexOutOfRangeException("Cant do that");

        }
        Matrix result = new Matrix(one.GetLength(0), one.GetLength(1));
        for (int row = 0; row < one.GetLength(0); row++)
        {
            for (int col = 0; col < one.GetLength(1); col++)
            {
                result[row, col] = one[row, col] + (SubscribeOrAdd ? two[row, col] : -two[row, col]);
            }
        }
        return result;
    }
    public static Matrix operator -(Matrix one, Matrix two)
    {
        return AddingSubstracting(one, two, false);
    }
    public static Matrix operator *(Matrix one, Matrix two)
    {
        if (one.GetLength(0) != two.GetLength(1))
        {
            throw new IndexOutOfRangeException("Cant Multiplayed");
        }

        Matrix result = new Matrix(one.GetLength(0), two.GetLength(1));

        for (int row = 0; row < one.GetLength(0); row++)
        {
            for (int col = 0; col < two.GetLength(1); col++)
            {
                int currentSum = 0;
                for (int i = 0; i < one.GetLength(0); i++)
                {
                    currentSum += one[row, i] * two[i, col];
                }
                result[row, col] = currentSum;
            }
        }
        return result;
    }
    public override string ToString()
    {
        StringBuilder toReturn = new StringBuilder();
        for (int row = 0; row < this.GetLength(0); row++)
        {
            for (int col = 0; col < this.GetLength(1); col++)
            {
                toReturn.Append(string.Format("{0} ", matrix[row, col]));
            }
            toReturn.AppendLine();
        }
        return toReturn.ToString();
    }

}
