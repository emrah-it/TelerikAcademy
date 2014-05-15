using System;

class DrunkenNumbers
{
    static void Main()
    {

        int rounds = int.Parse(Console.ReadLine());
        int mitko = 0;
        int vlatko = 0;
        string[] beers = new string[rounds];
        for (int i = 0; i < rounds; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                number *= -1;
            }
            beers[i] = Convert.ToString(number);
        }
        for (int i = 0; i < rounds; i++)
        {
            if ((beers[i].Length % 2) == 0)
            {
                for (int j = 0; j < beers[i].Length; j++)
                {
                    if (j < (beers[i].Length / 2))
                    {
                        mitko += (int)char.GetNumericValue(beers[i][j]);
                    }
                    else
                    {
                        vlatko += (int)char.GetNumericValue(beers[i][j]);
                    }

                }
            }
            else
            {
                for (int j = 0; j < beers[i].Length; j++)
                {
                    if (j < (beers[i].Length / 2))
                    {
                        mitko += (int)char.GetNumericValue(beers[i][j]);
                    }
                    else if (j == (beers[i].Length / 2))
                    {
                        mitko += (int)char.GetNumericValue(beers[i][j]);
                        vlatko += (int)char.GetNumericValue(beers[i][j]);
                    }
                    else
                    {
                        vlatko += (int)char.GetNumericValue(beers[i][j]);
                    }
                }
            }
        }
        if (mitko > vlatko)
            Console.WriteLine("M {0}", mitko - vlatko);
        else if (vlatko > mitko)
            Console.WriteLine("V {0}", vlatko - mitko);
        else
        {
            Console.WriteLine("No {0}", mitko + vlatko);
        }

    }

}