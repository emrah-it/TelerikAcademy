using System;
class Program
{
    static void Main()
    {
        int start, end;
        start = int.Parse(Console.ReadLine());
        end = int.Parse(Console.ReadLine());
        try
        {
            ReadNumber(start, end);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Out of range");
        }
        catch(ArgumentNullException)
        {
            Console.WriteLine("Empty string is entered");
        }
        catch(FormatException)
        {
            Console.WriteLine("Format exception");
        }

    }

    private static void ReadNumber(int start, int end)
    {
        int[] numbes = new int[10];
        Console.WriteLine("Enter Ten number betweem {0} and {1}", start, end);
        for (int i = 0; i < 10; i++)
        {
            int current;
            current = int.Parse(Console.ReadLine());
            if (current > start && current < end)
            {
                numbes[i] = current;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }
    }
}
