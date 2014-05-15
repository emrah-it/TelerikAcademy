using System;

class Program
{
    static void Main()
    {
        const int TotalArea = 250;
        decimal[] price = new decimal[] { 0.5M/*tomato*/,
            0.4M/*cucumber*/,
            0.25M/*potato*/,
            0.6M/*carrot*/,
            0.3M/*cabbage*/,
            0.4M/*beans*/ };
        int sumOfArea = 0;
        decimal cost = 0;
        int i;
        for ( i = 0; i < 5; i++)
        {
            int seed = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            sumOfArea += area;
            cost += seed * price[i];
        }
        int beansSeed = int.Parse(Console.ReadLine());
        cost += beansSeed * price[i];
        Console.WriteLine("Total costs: {0:0.00}", cost);
        if (TotalArea - sumOfArea > 0)
        {
            Console.WriteLine("Beans area: {0}", TotalArea - sumOfArea);
        }
        else if (sumOfArea == TotalArea)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }
 
     }
}
