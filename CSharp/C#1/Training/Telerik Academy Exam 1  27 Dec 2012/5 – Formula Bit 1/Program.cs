using System;
class Program
{
    static void Main()
    {
        int length = 8;
        string[] binnaryArray = new string[length];
        for (int i = 0; i < length; i++)
        {
            binnaryArray[i] = Convert.ToString(byte.Parse(Console.ReadLine()), 2);
            if (binnaryArray[i].Length < 8)
            {
                binnaryArray[i] = new string('0', 8 - binnaryArray[i].Length) + binnaryArray[i];
            }
        }
        string[] arrayToUse = new string[length];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                arrayToUse[i] += binnaryArray[i][(length - 1) - j];
            }
        }

        int row, col, direcetionPoz, sum;
        direcetionPoz = row = col = sum = 0;
        string direction = "down";
        bool upDown = true;
        bool result = false;
        try
        {

        
        while (true)
        {
            if (direction == "down")
            {
                if (row == length)
                {
                    
                    if (arrayToUse[row - 1][col + 1] == '0')
                    {
                        direcetionPoz++;
                        row--;
                        col++;
                        direction = "right";
                    }
                    else
                    {
                        break;
                    }
                }
                else if (arrayToUse[row][col] == '1')
                {
                    if (arrayToUse[row - 1][col + 1] == '0')
                    {
                        direction = "right";
                        direcetionPoz++;
                        row--;
                        col++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (arrayToUse[row][col] == '0')
                {
                    row++;
                    sum++;
                }
            }
            else if (direction == "up")
            {
                if (row == -1)
                {
                    if (row == -1 && col == 7)
                    {
                        break;
                    }
                    if (arrayToUse[row + 1][col + 1] == '0')
                    {
                        direcetionPoz++;
                        row++;
                        col++;
                        direction = "right";
                    }
                    else
                    {
                        break;
                    }
                }
                else if (arrayToUse[row][col] == '1')
                {
                    if (col == 7)
                    {
                        break;
                    }
                    if (arrayToUse[row + 1][col + 1] == '0')
                    {
                        direction = "right";
                        direcetionPoz++;
                        row++;
                        col++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (arrayToUse[row][col] == '0')
                {
                    row--;
                    sum++;
                }
            }
            else if (direction == "right")
            {
                int upOrDown = upDown ? -1 : 1;
                if (col == length)
                {
                    if (row == 0 && col == 8)
                    {
                        if (((upDown) ? "up" : "down") == "up")
                        {
                            break;
                        }
                    }
                    if (arrayToUse[row + upOrDown][col - 1] == '0')
                    {
                        direcetionPoz++;
                        row += upOrDown;
                        col--;
                        direction = (upDown) ? "up" : "down";
                        upDown = upDown ? false : true;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (arrayToUse[row][col] == '1')
                {
                    if (row == -1)
                    {
                        if (((upDown) ? "up" : "down") == "up")
                        {
                            break;
                        }
                    }
                    if (arrayToUse[row + upOrDown][col - 1] == '0')
                    {
                        direction = (upDown) ? "up" : "down";
                        upDown = upDown ? false : true;
                        direcetionPoz++;
                        row += upOrDown;
                        col--;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (arrayToUse[row][col] == '0')
                {
                    col++;
                    sum++;
                }
            }
            if (row == 7 && col == 7)
            {
                if (arrayToUse[row][col] == '0')
                {
                    sum++;
                    result = true;
                    break;
                }
            }
        }
        }
        catch (Exception)
        {
        }
        if (result)
        {
            Console.WriteLine("{0} {1}", sum, direcetionPoz);
        }
        else
        {
            Console.WriteLine("No {0}", sum);
        }

    }
}