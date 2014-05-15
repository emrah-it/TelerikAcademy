using System;
class ChoiseVarible
{
    static void Main()
    {
        string choise = Console.ReadLine();
        string result = Console.ReadLine();
        switch (choise)
        {
            case "int":
                Console.WriteLine(int.Parse(result) + 1);
                break;
            case "double":
                Console.WriteLine(double.Parse(result) + 1);
                break;
            case "string":
                Console.WriteLine( result + "*");
                break;
            default:
                break;
        }
    }
}
