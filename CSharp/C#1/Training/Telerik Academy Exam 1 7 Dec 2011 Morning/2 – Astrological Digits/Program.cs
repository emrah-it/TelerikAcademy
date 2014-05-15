using System;
class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        long sum = 0;
        bool first = false;
        do
        {
            if(first)
            {
                number = sum.ToString();
                sum = 0;
            }
            for (int i = 0; i < number.Length; i++)
            {
                if ('0' < number[i] && number[i] <= '9')
                {
                    sum += int.Parse(number[i].ToString());
                }
            }
            first = true;
        } while (sum > 9);
        Console.WriteLine(sum);
    }
}
