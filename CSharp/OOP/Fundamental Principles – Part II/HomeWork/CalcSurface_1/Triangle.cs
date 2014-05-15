namespace HomeWork.CalcSurface_1
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculateSurface()
        {
            double result = (this.Height * this.Width) / 2;
            return result;
        }
    }
}