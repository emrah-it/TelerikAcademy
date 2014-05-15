using System;
class Program
{
    static string[] units = new string[] { "Zero", "One", "Two", "Tree", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    static string[] firstTens = new string[] {"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    static string[] tens = new string[] { "","", "Twenty", "Thirty", "Forty", "Fifty", "Sixty","Seventy", "Eighty", "Ninety" };
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        
        if (number < 10)
        {
            Console.WriteLine(Program.units[number]);
        }
        else if(number >= 10 && number < 20)
        {
            Console.WriteLine(firstTens[number%10]);
        }
        else if (number >= 20 )
        {
            ShowText(number);
        }
       
    }

    private static void ShowText(int number)
    {
        string numberInString = number.ToString();
        if (number < 100)
        {
            Console.Write(tens[int.Parse(numberInString[0].ToString())]);
            if (int.Parse(numberInString[1].ToString()) != 0)
            {
                Console.Write(" ");
                Console.Write(units[int.Parse(numberInString[1].ToString())].ToLower());
            }
        }
        else if (number >= 100)
        {
            Console.Write(units[int.Parse(numberInString[0].ToString())]);
            Console.Write(" hundred");
            if ((number % 100) == 0)
            {
                return;
            }
            else if ((number % 100) > 0 && (number % 100) < 10)
            {
                Console.Write(" and ");
                Console.Write(units[int.Parse(numberInString[2].ToString())].ToLower());
            }
            else if ((number % 100) > 9 && (number % 100) < 20)
            {
                Console.Write(" and ");
                Console.Write(firstTens[int.Parse(numberInString[2].ToString())].ToLower());
            }
            else
            {
                Console.Write(" ");
                Console.Write(tens[int.Parse(numberInString[1].ToString())].ToLower());
                Console.Write(" ");
                Console.Write(units[int.Parse(numberInString[2].ToString())].ToLower());
            }
        }
    }
}
