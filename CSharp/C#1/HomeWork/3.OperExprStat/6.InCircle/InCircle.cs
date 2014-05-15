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

        if (Math.Pow((x - xCenter), 2) + Math.Pow((y - yCenter), 2) < Math.Pow(radius, 2))
        {
            Console.WriteLine("in");
        }
        Console.WriteLine("out");

    }
}


//In general, x and y must satisfy (x - center_x)^2 + (y - center_y)^2 < radius^2.
//Please note that points that satisfy the above equation
//with < replaced by == are considered the points on the circle, 
//and the points that satisfy the above equation with < replaced by > are considered the outside the circle.
