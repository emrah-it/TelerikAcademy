//1.Implement an extension method
//  Substring(int index, int length) for the class
//  StringBuilder that returns new StringBuilder and
//  has the same functionality as Substring in the class String.

namespace HomeWork
{
    using System.Text;

    public static class SubstringForStringBuilder
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                result.Append(str[i]);
            }

            return result;
        }
    }
}

//Rut Tests