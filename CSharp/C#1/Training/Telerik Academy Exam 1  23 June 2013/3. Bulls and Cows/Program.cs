using System;
class BullsAndCows
{
    static void Main()
    {
        string number = Console.ReadLine();

        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int currentBulls = 0;
        int currentCows = 0;

        bool result = false;

        for (int i = 1111; i < 9999; i++)
        {
            char[] current = i.ToString().ToCharArray();
            char[] testNumber = number.ToCharArray();
            if (current[0] == '0' || current[1] == '0' || current[2] == '0' || current[3] == '0')
                continue;
            for (int j = 0; j < 4; j++)
            {
                if (current[j] == testNumber[j])
                {
                    currentBulls++;
                    current[j] = '@';
                    testNumber[j] = '*';
                }
            }
            for (int j = 0; j < 4; j++)
            {
                for (int z = 0; z < 4; z++)
                {
                    if (testNumber[j] == current[z])
                    {
                        testNumber[j] = '*';
                        current[z] = '@';
                        currentCows++;
                    }
                }
            }
            if (bulls == currentBulls && cows == currentCows)
            {
                if (result)
                    Console.Write(" ");
                Console.Write(i);
                result = true;
            }
            currentBulls = currentCows = 0;


        }
        if (!result)
            Console.WriteLine("No");

    }
}