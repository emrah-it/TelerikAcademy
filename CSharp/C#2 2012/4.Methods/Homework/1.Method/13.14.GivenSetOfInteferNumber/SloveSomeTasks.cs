using System;
using System.Collections.Generic;
using System.IO;
class SloveSomeTasks
{
    static void Main()
    {
        StreamReader myConsole = new StreamReader(@"C:\Users\Admin\Desktop\Test.txt");
        using (myConsole)
        {
            List<int> value = new List<int>();
            string current;

            while((current = myConsole.ReadLine()) != null)
            {
                value.Add(int.Parse(current));
            }
        }
    }

    static public T Sum<T>(List<T> value) where T : struct
    {
        dynamic sum = 0;
        foreach (var item in value)
        {
            sum += item;
        }
        return sum;
    }

    static public T Averge<T>(List<T> value) where T : struct
    {
        dynamic sum = Sum(value);
        return sum / value.Count;
    }


    static public T Maximum<T>(List<T> value) where T:IComparable
    {
        T maximum = value[0];
        foreach (var item in value)
        {
            if (maximum.CompareTo(item) < 0)
            {
                maximum = item;

            }
        }
        return maximum;
    }


    static public T Minimum<T>(List<T> value) where T : IComparable
    {
        T minimum = value[0];
        foreach (var item in value)
        {
            if (minimum.CompareTo(item) > 0)
            {
                minimum = item;

            }
        }
        return minimum;
    }
    
}
