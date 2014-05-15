using System;
class Program
{
    static void Main()
    {
        string k = Console.ReadLine();

        for (int i = 0; i < 3; i++)
        {
            int nextNumber = k.Length - 1;
            string currentNumber = "";
            for (int j  = 0; j < k.Length; j++)
            {
                currentNumber += k[nextNumber++];
                if (nextNumber == k.Length)
                {
                    nextNumber = 0;
                }
            }
            k = int.Parse(currentNumber).ToString();
        }
        Console.WriteLine(k);
    }
}
