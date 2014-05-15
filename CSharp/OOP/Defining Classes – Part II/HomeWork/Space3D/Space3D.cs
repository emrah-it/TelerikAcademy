//3. Write a static class with a static method
//to calculate the distance between two
//points in the 3D space.
namespace HomeWork.Space3D
{
    using System;

    public static class Space3D
    {
        public static double Distance(Point3D p1, Point3D p2)
        {
            return Math.Sqrt(p1.X * p2.X + p1.Y * p2.Y + p1.Z * p2.Z);
        }
    }
}