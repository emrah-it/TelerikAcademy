using System;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int maxSum = int.MinValue;
        for (int i = 0; i < N; i++)
        {
            int currentSum = 0;
            for (int j = i; j < K; j++)
            {
                currentSum += array[j];  
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;                
            }
        }
        Console.WriteLine(maxSum);
    }
}
