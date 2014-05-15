using System;
class InCircle
{
    static void Main()
    {
        int xCenter = 0;
        int yCenter = 0;
        int radius = 5;

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int top = 1;
        int left = -1;
        int width = 6;
        int height = 2;
        int leftX = left;
        int rightX = left + (width - 1);
        int upY = top;
        int downY = top - height;

        bool isInide = IsInCircle(xCenter, yCenter, radius, x, y);
        if(isInide)
        {
            if(leftX < x && x < rightX && upY > y && y > downY)
            {
                Console.WriteLine("in");
                return;
            }
        }
        Console.WriteLine("out");

    }
    static bool IsInCircle(int circleCenterX, int cyrcleCenterY, int radius, int pointX, int pointY)
    {
        if (Math.Pow((pointX - circleCenterX), 2) + Math.Pow((pointY - cyrcleCenterY), 2) < Math.Pow(radius, 2))
        {
            return true;
        }
        return false;
    }
}