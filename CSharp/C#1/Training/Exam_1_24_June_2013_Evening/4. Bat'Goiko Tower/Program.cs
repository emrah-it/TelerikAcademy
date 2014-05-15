using System;

class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        char[,] figure = new char[length, length* 2];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length * 2; j++)
            {
                figure[i, j] = '.';
            }
        }
        int row, col;
        row = length -1;
        col = 0;
        string direction = "up";
        while (col != length * 2)
        {
            if(direction == "up")
            {
                figure[row--, col++] = '/';
                if(row == -1)
                {
                    direction= "down";
                    row = 0;
                }
            }
            else if(direction == "down")
            {
                figure[row++,col++] = '\\';
            }
        }
        row = 1;
        col = 0;
        int plus = 2;
        while (row <= length - 1)
        {
            if(figure[row,col++] == '/')
            {
                while(figure[row,col] != '\\')
                {
                    figure[row, col++] = '-';
                }
                col = 0;
                row += plus++;
            }
        }



        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length * 2; j++)
            {
                Console.Write(figure[i,j]);
            }
            Console.WriteLine();
        }

    }
}