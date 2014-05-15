using System;
class ReplaceBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        int result;
        if(v == 0)
        {
            result = n & (255 ^(1 << p));
        }
        else
        {
            result = n | (1 << p);
        }
        Console.WriteLine(result);
        
    }
}
