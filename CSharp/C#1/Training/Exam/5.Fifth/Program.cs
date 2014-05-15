using System;
class Program
{
    static void Main()
    {
        int length = 16;
        char[,] cookiesPlase = new char[16, 16];
        for (int i = 0; i < length; i++)
        {
            string current = Console.ReadLine();
            for (int j = 0; j < length; j++)
            {
                cookiesPlase[i, j] = current[j];
            }
        }
        string currentAsk;
        decimal buyedCookie = 0;
        while ((currentAsk = Console.ReadLine()) != "paypal")
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            if (currentAsk == "what is")
            {
                int sum = IsThatCookie(row, col, cookiesPlase);
                if (cookiesPlase[row, col] == '0')
                {
                    Console.WriteLine("smile");
                }
                else if (sum == 1)
                {
                    Console.WriteLine("cookie crumb");
                }
                else
                {
                    if (CalculateArea(row - 1, col - 1, cookiesPlase) == 9)
                    {
                        Console.WriteLine("cookie");
                    }
                    else
                    {
                        Console.WriteLine("broken cookie");
                    }
                }
            }
            else if (currentAsk == "buy")
            {
                if (CalculateArea(row-1, col-1, cookiesPlase) == 9)
                {
                    ClearCookie(row - 1, col - 1, cookiesPlase);
                    buyedCookie++;
                }
                else if (cookiesPlase[row,col] == '1')
                {
                    Console.WriteLine("page");
                }
                else if(cookiesPlase[row,col] == '0')
                {
                    Console.WriteLine("smile");
                }
            }
        }
        decimal result = buyedCookie * (decimal)1.79;
        Console.WriteLine(result);
    }

    private static void ClearCookie(int row, int col, char[,] cookiesPlase)
    {
        for (int i = row; i < row + 3; i++)
        {
            for (int j = col; j < col + 3; j++)
            {
                cookiesPlase[i, j] = '0';
            }
        }
    }

    private static int IsThatCookie(int row, int col, char[,] cookiesPlase)
    {
        if (row > 0)
        {
            if (cookiesPlase[row - 1, col] == '1')
            {
                return IsThatCookie(row - 1, col, cookiesPlase);
            }
        }
        else if (col > 0)
        {
            if (cookiesPlase[row, col - 1] == '1')
            {
                return IsThatCookie(row, col - 1, cookiesPlase);
            }
        }
        return CalculateArea(row, col, cookiesPlase);
    }

    private static int CalculateArea(int row, int col, char[,] cookiesPlase)
    {
        int sum = 0;
        for (int i = row; i < row + 3; i++)
        {
            for (int j = col; j < col + 3; j++)
            {
                if (i >= 0 && i < cookiesPlase.GetLength(0) && j >= 0 && j < cookiesPlase.GetLength(0))
                {
                    sum += int.Parse(cookiesPlase[i, j].ToString());
                }
            }
        }
        return sum;
    }
}
