using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bittris
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        bool gameOver = false;
        int commands = 3;
        int points = 0;
        int[] rows = new int[4] { 0, 0, 0, 0 };
        for (int i = 0; i < length / 4; i++)
        {
            string[] command = new string[3];
            int number = int.Parse(Console.ReadLine());
            command[0] = Console.ReadLine();
            command[1] = Console.ReadLine();
            command[2] = Console.ReadLine();

            int currentRow = 0;
            if (rows[currentRow] != 0)
            {
                break;
            }
            else
            {
                rows[currentRow] = number;
            }
            string numberOfBytes = Convert.ToString(number, 2).Replace("0", "");
            for (int j = 0; j < commands; j++)
            {
                if (command[j] == "L")
                {
                    if ((rows[currentRow] & 128) != 128)
                    {
                        rows[currentRow] = rows[currentRow] << 1;
                    }
                }
                else if (command[j] == "R")
                {
                    if ((rows[currentRow] & 1) != 1)
                    {
                        rows[currentRow] = rows[currentRow] >> 1;
                    }
                }
                if (rows[currentRow + 1] == 0)
                {
                    rows[currentRow + 1] = rows[currentRow];
                    rows[currentRow++] = 0;
                    continue;
                }
                else if ((Convert.ToString(rows[currentRow + 1], 2).Replace("0", "").Length + numberOfBytes.Length) <= 8)
                {
                    int sum = rows[currentRow] | rows[currentRow + 1];
                    if (Convert.ToString(sum, 2).Replace("0", "").Length == (Convert.ToString(rows[currentRow + 1], 2).Replace("0", "").Length + numberOfBytes.Length))
                    {
                        if (currentRow + 2 <= 3)
                        {
                            int sum2 = rows[currentRow] | rows[currentRow + 2];
                            if (Convert.ToString(sum2, 2).Replace("0", "").Length == (Convert.ToString(rows[currentRow + 2], 2).Replace("0", "").Length + numberOfBytes.Length))
                            {
                                if (currentRow + 2 <= 3)
                                {
                                    int sum3 = rows[currentRow] | rows[currentRow + 3];
                                    if (Convert.ToString(sum3, 2).Replace("0", "").Length == (Convert.ToString(rows[currentRow + 3], 2).Replace("0", "").Length + numberOfBytes.Length))
                                    {
                                        rows[currentRow + 3] = sum3;
                                        sum2 = rows[currentRow + 2];
                                    }

                                }
                                rows[currentRow + 2] = sum2;
                                rows[currentRow] = 0;
                                sum = rows[currentRow + 1];
                            }
                        }
                        rows[currentRow + 1] = sum;
                        rows[currentRow] = 0;
                        if (Convert.ToString(rows[currentRow + 1], 2).Replace("0", "").Length == 8)
                        {
                            rows[currentRow] = rows[currentRow + 1] = 0;
                            points += (numberOfBytes.Length * 10) - numberOfBytes.Length;
                        }
                        break;
                    }
                    break;
                }
                else
                {
                    break;
                }
            }
            points += numberOfBytes.Length;
        }
        Console.WriteLine(points);

    }
}