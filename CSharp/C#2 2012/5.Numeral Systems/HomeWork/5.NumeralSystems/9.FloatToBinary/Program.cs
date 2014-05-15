using System;
class Program
{
    static void Main()
    {
        float number = float.Parse(Console.ReadLine());
        byte[] bits =  BitConverter.GetBytes(number);
        string showBits = "";
        for (int i = bits.Length - 1; i >= 0 ; i--)
        {
            char[] charArray = Convert.ToString(bits[i], 2).PadLeft(8, '0').ToCharArray();
            Array.Reverse(charArray);
            showBits += new string(charArray);
        }
        Console.WriteLine(showBits);
    }
}
