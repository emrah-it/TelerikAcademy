using System;
class TakeBit
{
    static void Main()
    {
        int i = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int result = i & (1 << b);

        Console.WriteLine(result == 0? "0": "1");
    }
}
