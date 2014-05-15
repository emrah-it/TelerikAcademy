using System;
class Program
{
    static void Main()
    {
        UInt32 n = UInt32.Parse(Console.ReadLine());

        UInt32 bitTree = n & (1 << 3);
        UInt32 bitFour = n & (1 << 4);
        UInt32 bitFive = n & (1 << 5);

        UInt32 bitTFrour = n & (1 << 24);
        UInt32 bitTFive = n & (1 << 25);
        UInt32 bitTSix = n & (1 << 26);
        ReplaceBits(ref n, bitTree, 24);
        ReplaceBits(ref n, bitFour, 25);
        ReplaceBits(ref n, bitFive, 26);
        ReplaceBits(ref n, bitTFrour, 3);
        ReplaceBits(ref n, bitTFive, 4);
        ReplaceBits(ref n, bitTSix, 5);
        string num = Convert.ToString(n, 2);
        Console.WriteLine(n);
    }

    private static void ReplaceBits(ref UInt32 n, UInt32 bit, int position)
    {
        if (bit == 0)
        {
            n = (UInt32) (n & (UInt32.MaxValue ^ (1 << position)));
        }
        else
        {
            n = (UInt32) (n | (1 << position));
        }
    }
}