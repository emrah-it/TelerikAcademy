using System;
class Program
{
    static void Main()
    {
        short num = short.Parse(Console.ReadLine());
        byte[] binary = BitConverter.GetBytes(num);
        string showBits = "";
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            char[] charArray = Convert.ToString(binary[i], 2).PadLeft(8, '0').ToCharArray();
            Array.Reverse(charArray);
            showBits += new string(charArray);
        }
        Console.WriteLine(showBits);
    }
}
