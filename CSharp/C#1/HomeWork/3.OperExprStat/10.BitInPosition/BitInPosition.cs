using System;
class BitInPosition
{
    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int result = v & (1 << p );
        
        Console.WriteLine(result == 1 ? true : false);
    }
}
