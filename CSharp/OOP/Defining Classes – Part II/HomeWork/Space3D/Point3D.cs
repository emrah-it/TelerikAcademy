//1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z}
//in the Euclidean 3D space. Implement the ToString()
// to enable printing a 3D point.

//2. Add a private static read-only field
//to hold the start of the coordinate system – the
//point O{0, 0, 0}. Add a static property to return the point O.

namespace HomeWork.Space3D
{
    using System.Text;

    public struct Point3D
    {
        static private Point3D o = new Point3D(0, 0, 0);
        private double x;
        private double y;
        private double z;
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D O
        {
            get
            {
                return o;
            }
            set
            {
                o = value;
            }
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("X: {0}\n", this.X);
            result.AppendFormat("Y: {0}\n", this.Y);
            result.AppendFormat("Z: {0}\n", this.Z);
            return result.ToString().Trim('\n');
        }
    }
}