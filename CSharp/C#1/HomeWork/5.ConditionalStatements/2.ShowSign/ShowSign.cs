using System;
class ShowSign
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        bool result;
        if (firstNumber > 0)
        {
            if (secondNumber > 0)
            {
                if (thirdNumber > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                if (thirdNumber < 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
        }
        else
        {
            if (secondNumber < 0)
            {
                if (thirdNumber > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                if (thirdNumber < 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
        }
        Console.WriteLine(result.ToString());
    }
}
