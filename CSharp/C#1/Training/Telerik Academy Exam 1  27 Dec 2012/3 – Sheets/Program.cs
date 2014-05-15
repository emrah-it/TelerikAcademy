using System;
class Program
{
    static void Main()
    {
        int length = 11;
        int[] paperSize = new int[length];
        paperSize[10] = 1;
        for (int i = length - 2; i >= 0; i--)
        {
            paperSize[i] = paperSize[i + 1] * 2;
        }
        string[] paperName = new string[] { "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" };
        int pieces = int.Parse(Console.ReadLine());
        for (int k = 0; k < length; k++)
        {
            int position = 0;
            bool find = false;
            for (int i = k; i < length; i++)
            {
                if (pieces > paperSize[i] && paperSize[i] != 0)
                {
                    if (i == 0)
                    {
                        position = i;
                        find = true;
                        break;
                    }
                    else if(pieces < paperSize[i - 1])
                    {
                        position = i;
                        find = true;
                        break;
                    }
                    position = i;
                    find = true;
                    break;

                }
                else if (pieces == paperSize[i])
                {
                    position = i;
                    find = true;
                    break;
                }
            }
            if (find)
            {
                pieces -= paperSize[position];
                paperSize[position] = 0;
            }
            if (pieces == 0)
            {
                break;
            }
        }

        for (int i = 0; i < length; i++)
        {
            if (paperSize[i] != 0)
            {
                Console.WriteLine(paperName[i]);
            }
        }
    }
}
