using System;
class Program
{
    static void Main()
    {
        int PX1 = int.Parse(Console.ReadLine());
        int PY1 = int.Parse(Console.ReadLine());
        int PX2 = int.Parse(Console.ReadLine());
        int PY2 = int.Parse(Console.ReadLine());
        int FX = int.Parse(Console.ReadLine());
        int FY = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        int upLeftX = Math.Min(PX1, PX2);
        int upLeftY = Math.Max(PY1, PY2);

        int downRightX = Math.Max(PX1, PX2);
        int downRightY = Math.Min(PY1, PY2);

        FX += D;
        int result = 0;
        if (upLeftX <= FX && FX <= downRightX && upLeftY >= FY && FY >= downRightY)
        {
            result += 100;
        }
        int forward = FX + 1;
        if (upLeftX <= forward && forward <= downRightX && upLeftY >= FY && FY >= downRightY)
        {
            result += 75;
        }
        int upPoint = FY + 1;
        if (upLeftX <= FX && FX <= downRightX && upLeftY >= upPoint && upPoint >= downRightY)
        {
            result += 50;
        }
        int downPoint = FY - 1;
        if (upLeftX <= FX && FX <= downRightX && upLeftY >= downPoint && downPoint >= downRightY)
        {
            result += 50;
        }
        Console.WriteLine(result + "%");
    }
}
