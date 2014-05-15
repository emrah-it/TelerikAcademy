using System;

class ShipDamage
{
    static void Main()
    {
        int boat1X = int.Parse(Console.ReadLine());
        int boat1Y = int.Parse(Console.ReadLine());
        int boat2X = int.Parse(Console.ReadLine());
        int boat2Y = int.Parse(Console.ReadLine());

        int horizon = int.Parse(Console.ReadLine());

        int c1X = int.Parse(Console.ReadLine());
        int c1Y = int.Parse(Console.ReadLine());
        int c2X = int.Parse(Console.ReadLine());
        int c2Y = int.Parse(Console.ReadLine());
        int c3X = int.Parse(Console.ReadLine());
        int c3Y = int.Parse(Console.ReadLine());

        boat1Y -= horizon;
        boat2Y -= horizon;
        c1Y -= horizon;
        c2Y -= horizon;
        c3Y -= horizon;

        int projC1Y = -c1Y;
        int projC2Y = -c2Y;
        int projC3Y = -c3Y;

        int top = Math.Max(boat1Y, boat2Y);
        int left = Math.Min(boat1X, boat2X);
        int bottom = Math.Min(boat1Y, boat2Y);
        int right = Math.Max(boat1X, boat2X);
        
        int sum = 0;

        if (projC1Y > bottom && projC1Y < top)
        {
            if (c1X > left && c1X < right)
            {
                sum += 100;
            }
            else if (c1X == left || c1X == right)
            {
                sum += 50;
            }
        }
        else if (projC1Y == bottom || projC1Y == top)
        {
            if (c1X > left && c1X < right)
            {
                sum += 50;
            }
            else if (c1X == left || c1X == right)
            {
                sum += 25;
            }
        }
        if (projC2Y > bottom && projC2Y < top)
        {
            if (c2X > left && c2X < right)
            {
                sum += 100;
            }
            else if (c2X == left || c2X == right)
            {
                sum += 50;
            }
        }
        else if (projC2Y == bottom || projC2Y == top)
        {
            if (c2X > left && c2X < right)
            {
                sum += 50;
            }
            else if (c2X == left || c2X == right)
            {
                sum += 25;
            }
        }
        if (projC3Y > bottom && projC3Y < top)
        {
            if (c3X > left && c3X < right)
            {
                sum += 100;
            }
            else if (c3X == left || c3X == right)
            {
                sum += 50;
            }
        }
        else if (projC3Y == bottom || projC3Y == top)
        {
            if (c3X > left && c3X < right)
            {
                sum += 50;
            }
            else if (c3X == left || c3X == right)
            {
                sum += 25;
            }
        }
        Console.WriteLine(sum + "%");
    }
}