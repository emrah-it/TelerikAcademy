namespace HomeWork.CalcSurface_1
{
    using System;

    public class Circle : Shape
    {
        public Circle(double widht, double height)
        {
            if (widht != height)
            {
                throw new ArgumentException();
            }
            this.Width = widht;
            this.Height = widht;
        }

        public override double Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
        public override double CalculateSurface()
        {
            double surface = (this.Height / 2) * (this.Height / 2) * Math.PI;
            return surface;
        }
    }
}