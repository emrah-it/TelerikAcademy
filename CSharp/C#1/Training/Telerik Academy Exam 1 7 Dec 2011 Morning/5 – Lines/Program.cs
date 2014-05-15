using System;
class Program
{
    static void Main()
    {
        int length = 8;
        byte[] number = new byte[8];
        byte one = 1;
        for (int i = 0; i < length; i++)
        {
            number[i] = byte.Parse(Console.ReadLine());
        }
        int maximalLength = 0;
        int repeatedTimes = 0;
        for (int i = 0; i < length; i++)
        {
            byte currentNumber = number[i];
            for (int j = 0; j < length; j++)
            {
                int currentLength = 0;
                for (int k = j; k < length; k++)
                {
                    if ((currentNumber & (one << k)) != 0)
                    {
                        currentLength++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maximalLength)
                {
                    maximalLength = currentLength;
                    repeatedTimes = 1;
                }
                else if (currentLength == maximalLength && currentLength != 0)
                {
                    repeatedTimes++;
                }
            }
        }
        for (int j = 0; j < length; j++)
        {
            for (int i = 0; i < length; i++)
            {
                int currentLength = 0;
                for (int k = i; k < length; k++)
                {
                    if ((number[k] & (one << j)) != 0)
                    {
                        currentLength++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maximalLength)
                {
                    maximalLength = currentLength;
                    repeatedTimes = 1;
                }
                else if (currentLength == maximalLength && currentLength != 0)
                {
                    repeatedTimes++;
                }
            }
        }
        if (maximalLength == 1)
        {
            repeatedTimes /= 2;
        }
        Console.WriteLine(maximalLength);
        Console.WriteLine(repeatedTimes);
    }
}
