using System;
class Program
{
    static void Main()
    {
        int[] warPlace = new int[8];
        string[] nums = new string[8];
        for (int i = 0; i < 8; i++)
        {
            warPlace[i] = int.Parse(Console.ReadLine());
            nums[i] = Convert.ToString(warPlace[i], 2).PadLeft(16, '0');
        }

        int score = 0;
        for (int col = 8; col < 16; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                int bit = (warPlace[row] >> col) & 1;
                if (bit == 1)
                {
                    score += PointsFromBirdh(warPlace, col, row);
                    warPlace[row] = warPlace[row] & (~(1 << col));
                    break;
                }
            }
        }
        bool fail = false;
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                int bit = (warPlace[row] >> col) & 1;
                if (bit == 1)
                {
                    fail = true;
                }
            }
        }
        if (!fail)
        {
            Console.WriteLine("{0} Yes", score);
        }
        else
        {
            Console.WriteLine("{0} No", score);
        }
    }

    private static int PointsFromBirdh(int[] warPlace, int col, int row)
    {
        warPlace[row] = warPlace[row] & (~(1 << col));

        bool ifTrueIsUP;
        if (row > 0)
        {
            ifTrueIsUP = true;
            row--;
        }
        else
        {
            ifTrueIsUP = false;
            row++;
        }
        col--;
        int distance = 0;
        for (; col >= 0; col--)
        {
            distance++;
            int bit;
            if (ifTrueIsUP)
            {

                if (row >= 0)
                {
                    bit = (warPlace[row] >> col) & 1;
                    if (bit == 1)
                    {
                        //TODO: make some method for calculate result
                        return CalculatePoints(warPlace, distance, row, col);
                    }
                    else
                    {
                        if (row == 0)
                        {
                            row++;
                            ifTrueIsUP = false;
                        }
                        else
                        {
                            row--;
                        }
                    }
                }
            }
            else if (!ifTrueIsUP)
            {
                if (row <= 7)
                {
                    bit = (warPlace[row] >> col) & 1;
                    if (bit == 1)
                    {
                        //TODO: make some method for calculate result
                        return CalculatePoints(warPlace, distance, row, col);
                    }
                    else
                    {
                        if (row == 7)
                        {
                            return 0;
                        }
                        else
                        {
                            row++;
                        }
                    }
                }
            }
        }
        return 0;
    }

    private static int CalculatePoints(int[] warPlace, int distance, int row, int col)
    {
        int sum = 0;
        for (int j = row - 1; j <= row + 1; j++)
        {
            for (int i = col - 1; i <= col + 1; i++)
            {
                if (i >= 0 && i < 16 && j >= 0 && j < 8)
                {
                    if (((warPlace[j] >> i) & 1) == 1)
                    {
                        sum += 1;
                    }
                    warPlace[j] = warPlace[j] & (~(1 << i));
                }
            }
        }
        return sum * distance;
    }
}