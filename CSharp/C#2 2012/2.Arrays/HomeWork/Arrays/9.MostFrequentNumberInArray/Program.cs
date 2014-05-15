using System;
class Program
{
    static void Main()
    {
        int[] array = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        Array.Sort(array);
        int currentNumber = array[0];
        int currentNumberRepeat = 1;
        int resultNumber = 0;
        int resultNumberRepeat = int.MinValue;
        for (int i = 1; i < array.Length; i++)
        {
            if (currentNumber == array[i])
            {
                currentNumberRepeat++;
            }
            else
            {
                if (currentNumberRepeat > resultNumberRepeat)
                {
                    resultNumber = currentNumber;
                    resultNumberRepeat = currentNumberRepeat;
                }

                currentNumber = array[i];
                currentNumberRepeat = 1;
            }
        }
        Console.WriteLine(resultNumber.ToString() + " " + resultNumberRepeat.ToString());
    }
}
