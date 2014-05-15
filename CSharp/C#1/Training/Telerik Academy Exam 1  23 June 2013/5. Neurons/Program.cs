using System;
class Program
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        while (inputLine != "-1")
        {
            uint inputNumber = uint.Parse(inputLine);
            char[] currentNumber = Convert.ToString(inputNumber, 2).PadLeft(32, '0').ToCharArray();
            bool inBorder = false;
            bool inSide = false;
            bool wasInside = false;

            for (int i = 0; i < 32; i++)
            {
                if (currentNumber[i] == '1')
                {
                    if (inSide)
                    {
                        wasInside = true;
                    }
                    currentNumber[i] = '0';
                    inBorder = true;
                    inSide = false;

                }
                else
                {
                    if (inBorder && !wasInside)
                    {
                        inSide = true;
                    }
                    if (inSide)
                    {
                        currentNumber[i] = '1';
                    }
                }
            }
            if (wasInside)
            {
                Console.WriteLine(Convert.ToUInt32(new string(currentNumber), 2));
            }
            else
            {
                Console.WriteLine(0);
            }
            inputLine = Console.ReadLine();
        }

    }
}
