using System;
using System.Text;
class EncriptionDecrioption
{
    static void Main()
    {
        string someText = "Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.";
        string key = "abc";
        Console.WriteLine(Encription(someText, key));
        Console.WriteLine(Encription(Encription(someText, key), key));
    }
    static string Encription(string currentString, string currentKey)
    {
        StringBuilder currentEncription = new StringBuilder();
        for (int i = 0; i < currentString.Length; i++)
        {
            currentEncription.Append((char)(currentString[i] ^ currentKey[i % currentKey.Length]));
        }
        return currentEncription.ToString();
    }
}
