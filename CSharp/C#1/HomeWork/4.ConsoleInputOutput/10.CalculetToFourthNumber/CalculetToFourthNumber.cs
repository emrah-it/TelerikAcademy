using System;
class CalculetToFourthNumber
{
    static void Main()
    {
        double sum = 1;
        double one = 1;
        for (int i = 2;i < 9999 ; i++)
        {
            
            if((i % 2) == 0)
            {
                sum += (one / i);
            }
            else
            {
                sum -= (one / 2);
            }
        }
        Console.WriteLine("{0:0.000}", sum);
    }
}
