using System;
class BrecketsIsCorrenct
{
    static void Main()
    {
        string first = "((a+b)/5-d)";
        string second = ")(a+b))";

        Console.WriteLine(isCorrect(first));
        Console.WriteLine(isCorrect(second)); 
    }

    private static bool isCorrect(string current)
    {
        int openBreak = 0;
        int closeBreak = 0;
        foreach (char item in current)
        {
            if(item == '(')
            {
                openBreak++;
            }
            else if(item == ')')
            {
                closeBreak++;
            }
        }
        return openBreak == closeBreak;
    }
}

