using System;
using System.Linq;
using System.Collections.Generic;

class SequencesInTheMatrix
{
    static void Main()
    {
        //string[,] myStrings = new string[,] { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };
        string[,] myStrings = new string[,] { { "s", "qq", "s"}, { "pp", "pp", "s"}, { "pp", "qq", "s"} };

        Dictionary<string, int> repeatedTimes = new Dictionary<string, int>();

        //Horizontal
        for (int row = 0; row < myStrings.GetLength(0); row++)
        {
            for (int col = 0; col < myStrings.GetLength(1); col++)
            {
                string currentString = myStrings[row, col];
                int currentRepeat = 1;
                //horizontal
                Horizontal(myStrings, repeatedTimes, row, col, currentString, currentRepeat);

                //vertical
                Vertical(myStrings, repeatedTimes, row, col, currentString, currentRepeat);
                //Diagonal
                Diagonal(myStrings, repeatedTimes, row, col, currentString, currentRepeat);
            }
        }
        string mostRepeated = "";
        int max = int.MinValue;
        foreach (var item in repeatedTimes)
        {
            if (item.Value > max)
            {
                max = item.Value;
                mostRepeated = item.Key;
            }
        }
        Console.WriteLine(mostRepeated);
        Console.WriteLine(max);


    }

    private static void Diagonal(string[,] myStrings, Dictionary<string, int> repeatedTimes, int row, int col, string currentString, int currentRepeat)
    {
        int currentRow = row;
        int currentCol = col;
        while (++currentRow < myStrings.GetLength(0) && ++currentCol < myStrings.GetLength(1))
        {
            if (currentString == myStrings[currentRow, currentCol])
            {
                currentRepeat++;
            }
            else
            {
                break;
            }
        }
        CheckExist(repeatedTimes, currentString, currentRepeat);
        return ;
    }

    private static int Vertical(string[,] myStrings, Dictionary<string, int> repeatedTimes, int row, int col, string currentString, int currentRepeat)
    {

        for (int i = row + 1; i < myStrings.GetLength(0); i++)
        {
            if (currentString == myStrings[i, col])
            {
                currentRepeat++;
            }
            else
            {
                break;
            }
        }
        CheckExist(repeatedTimes, currentString, currentRepeat);
        return col;
    }

    private static void Horizontal(string[,] myStrings, Dictionary<string, int> repeatedTimes, int row, int col, string currentString, int currentRepeat)
    {
        for (int i = col + 1; i < myStrings.GetLength(1); i++)
        {
            if (currentString == myStrings[row, i])
            {
                currentRepeat++;
            }
            else
            {
                break;
            }
        }
        CheckExist(repeatedTimes, currentString, currentRepeat);
        return;
    }

    private static void CheckExist(Dictionary<string, int> repeatedTimes, string currentString, int currentRepeat)
    {
        if (repeatedTimes.ContainsKey(currentString))
        {
            if (repeatedTimes[currentString] < currentRepeat)
            {
                repeatedTimes[currentString] = currentRepeat;
            }
        }
        else
        {
            repeatedTimes.Add(currentString, currentRepeat);
        }
    }
}
