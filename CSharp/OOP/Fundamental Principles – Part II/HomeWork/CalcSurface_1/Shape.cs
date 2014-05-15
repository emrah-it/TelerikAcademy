using System;

namespace HomeWork.CalcSurface_1
{
    public abstract class Shape
    {
        private double height;
        private double width;
        public virtual double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.height = value;
            }
        }

        public virtual double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.width = value;
            }
        }
        public abstract double CalculateSurface();
    }
}