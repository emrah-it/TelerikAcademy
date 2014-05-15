using System;
using System.Collections;
class Program
{
    static void Main()
    {
        string[] text = new string[]{ "((a+b)/5-d)", ")(a+b))" };
        Stack sckope = new Stack();

        bool isCorrect = true;
        for (int i = 0; i < text.GetLength(0); i++)
        {
            for (int j = 0; j < text[i].Length; j++)
            {
                if (text[i][j] == '(')
                {
                    sckope.Push(text[i][j]);
                }
                if (text[i][j] == ')')
                {
                    if (sckope.Count != 0)
                    {
                        sckope.Pop();
                    }
                    else
                    {
                        Console.WriteLine("{0} is incorect", i + 1);
                        isCorrect = false;
                        break;
                    }
                }
                
            }
            if (sckope.Count == 0 && isCorrect)
            {
                Console.WriteLine("{0} is correct", i + 1);
            }
            else if(isCorrect)
            {
                Console.WriteLine("{0} is incorect", i + 1);
            }
        }
    }
}
