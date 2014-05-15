using System;
class NearsK
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        Array.Reverse(array);
        for (int i = 0; i < N; i++)
        {
            if (array[i] <= K)
            {
                Console.WriteLine(array[i]);
                break;
            }
        }
    }
}
