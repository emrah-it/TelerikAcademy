using System;
class BonusScore
{
    static void Main()
    {
        string input = Console.ReadLine();
        int score;
        switch (input)
        {
            case "1":
            case "2":
            case "3":
                score = int.Parse(input) * 10;
                Console.WriteLine(score);
                break;
            case "4":
            case "5":
            case "6":
                score = int.Parse(input) * 100;
                Console.WriteLine(score);
                break;
            case "7":
            case "8":
            case "9":
                score = int.Parse(input) * 1000;
                Console.WriteLine(score);
                break;
            case "0":
                Console.WriteLine("Nuber is zero");
                break;
            default:
                Console.WriteLine(int.TryParse(input,out score) ? "Incoreccet number":"Is not a integer number");
                break;
        }
    }
}
