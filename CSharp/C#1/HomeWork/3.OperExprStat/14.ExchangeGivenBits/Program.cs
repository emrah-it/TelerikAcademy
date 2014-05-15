using System;
class Program
{
    static void Main()
    {
        UInt32 number = UInt32.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        byte[] bitsP = new byte[k];
        byte[] bitsQ = new byte[k];
        int bits = 0;
        for (int i = p; i < k + p; i++)
        {
            bitsP[bits] = TakeBit(number, i);
            bits++;
        }
        bits = 0;
        for (int i = q; i < k + q; i++)
        {
            bitsQ[bits] = TakeBit(number, i);
            bits++;
        }
        bits = 0;
        for (int i = q; i < q + k; i++)
        {
            ReplaceBits(ref number, bitsP[bits], i);
            bits++;
        }
        bits = 0;
        for (int i = p; i < p + k; i++)
        {
            ReplaceBits(ref number, bitsQ[bits], i);
            bits++;
        }

        Console.WriteLine(Convert.ToString(number,2));
    }
    private static void ReplaceBits(ref UInt32 n, byte bit, int position)
    {
        if (bit == 0)
        {
            n = (UInt32)(n & (UInt32.MaxValue ^ (1 << position)));
        }
        else
        {
            n = (UInt32)(n | (1 << position));
        }
    }
    static byte TakeBit(UInt32 number, int position)
    {
        if ((number & (1 << position)) == 0)
        {
            return 0;
        }
        return 1;
    }

}

