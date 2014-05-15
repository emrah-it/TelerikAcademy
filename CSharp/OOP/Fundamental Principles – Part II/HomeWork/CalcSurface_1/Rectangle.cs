namespace HomeWork.CalcSurface_1
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculateSurface()
        {
            double result = (this.Width * this.Height);
            return result;
        }
    }
}