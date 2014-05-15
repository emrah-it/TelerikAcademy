namespace HomeWork.Space3D
{
    using System.IO;

    public static class PathStorage
    {
        static public void WriteToFile(Path points)
        {
            //Ask for file name
            string fileName = @"test.txt";
            //fileName = Console.ReadLine();

            WritePoints(points, fileName);
        }

        public static void WriteToFile(Path points, string name)
        {
            WritePoints(points, name);
        }

        private static void WritePoints(Path points, string fileName)
        {
            StreamWriter file = new StreamWriter(fileName);
            using (file)
            {
                foreach (var item in points.pointsIn3DSpace)
                {
                    file.WriteLine(item.ToString());
                }
            }
        }
    }
}