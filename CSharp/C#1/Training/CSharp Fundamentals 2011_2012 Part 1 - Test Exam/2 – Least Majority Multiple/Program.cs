using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] number = new int[5];
        for (int i = 0; i < 5; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        int divisible = 2;
        int max = 0;
        bool find = true;
        while(find)
        {
            if(( divisible % number[0] ) == 0)
            {
                max++;
            }
            if ((divisible % number[1]) == 0)
            {
                max++;
            }
            if ((divisible % number[2]) == 0)
            {
                max++;
            }
            if ((divisible % number[3]) == 0)
            {
                max++;
            }
            if ((divisible % number[4]) == 0)
            {
                max++;
            }

            if(max >= 3)
            {
                find = false;
            }
            else
            {
                max = 0;
                divisible++;
            }

        }
        Console.WriteLine(divisible);
    }
}
