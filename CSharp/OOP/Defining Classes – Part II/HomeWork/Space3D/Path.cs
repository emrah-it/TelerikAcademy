﻿//4.Create a class Path to hold a sequence
//of points in the 3D space. Create a static
//class PathStorage with static methods to save
//and load paths from a text file. Use a file
//format of your choice.

namespace HomeWork.Space3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Path
    {
        public List<Point3D> pointsIn3DSpace;

        public Path()
        {
            pointsIn3DSpace = new List<Point3D>();
        }
    }
}
