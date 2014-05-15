using System;
class Program
{
    static void Main()
    {
        string input;
        int choose;
        ShowMenu();
        while ((input = Console.ReadLine()) != "0")
        {
            try
            {
                choose = MakeChoise(input);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }
            switch (choose)
            {
                case 1:
                    DecimalNumberToReverse();
                    break;
                case 2:
                    SequenseOfNumver();
                    break;
                case 3:
                    SloveLinearEquation();
                    break;
                default:
                    break;
            }
            ShowMenu();
        }
    }

    private static void SloveLinearEquation()
    {
        Console.Write("Enter a:");
        int a;
        do
        {
            a = int.Parse(Console.ReadLine());
        } while (a == 0);
        int b;
        Console.Write("Enter b:");
        b = int.Parse(Console.ReadLine());
        Console.Write("Result is:");
        Console.WriteLine((-b)/a);
    }

    private static void SequenseOfNumver()
    {
        int length;
        do
        {
            Console.WriteLine("How many numbers you want to enter.");
            length = int.Parse(Console.ReadLine());
        } while (length == 0);
        int sum = 0;
        for (int i = 0; i < length; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum / length);

    }

    private static void ShowMenu()
    {
        Console.WriteLine("1.Reverse number");
        Console.WriteLine("2.Average sum of integer");
        Console.WriteLine("3.Slove linear euation a*x + b = 0");
    }

    private static void DecimalNumberToReverse()
    {
        Console.WriteLine("Enter positive decimal number");
        string input = Console.ReadLine();
        decimal number;
        if (!decimal.TryParse(input, out number))
        {
            Console.WriteLine("Number is invalid");
        }
        else
        {
            if (number >= 0)
            {
                Console.WriteLine(ReversNumber(input));
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }
    }
    private static string ReversNumber(string current)
    {
        char[] number = current.ToCharArray();
        Array.Reverse(number);
        return new string(number);
    }
    private static int MakeChoise(string input)
    {
        int validInput;
        if (!int.TryParse(input, out validInput))
        {
            Console.WriteLine("Make valid choose");
            throw new ArgumentException("Enter Valid Argument");
        }
        return validInput;
    }
}
