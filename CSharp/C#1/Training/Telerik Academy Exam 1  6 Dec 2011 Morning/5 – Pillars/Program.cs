using System;
class Program
{
    static void Main()
    {
        int length = 8;
        byte[] numbers = new byte[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = byte.Parse(Console.ReadLine());
        }
        int rightSide = 0;
        int leftSide = 0;
        int one = 1;
        bool result = false;
        int resultOfDots, resultOfSplitLine;
        resultOfDots = resultOfSplitLine = 0;
        for (int splitLine = 0; splitLine < length; splitLine++)
        {
            for (int i = 0; i < length; i++)
            {
                int current = numbers[i];
                for (int j = 0; j < splitLine; j++)
                {
                    if ((current & (one << j)) == (one << j))
                    {
                        rightSide++;
                    }
                }
                for (int j = splitLine + 1; j < length; j++)
                {
                    if ((current & (one << j)) == (one << j))
                    {
                        leftSide++;
                    }
                }
            }
            if (rightSide == leftSide )
            {
                resultOfDots = leftSide;
                resultOfSplitLine = splitLine;
                result = true;
            }
            leftSide = rightSide = 0;
        }
        if (result)
        {
            Console.WriteLine(resultOfSplitLine);
            Console.WriteLine(resultOfDots);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
