using System;
using FurnitureManufacturer.Interfaces;
using System.Text;

namespace FurnitureManufacturer.Models
{
    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;
        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {

            this.NumberOfLegs = numberOfLegs;
        }
        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Chair must have legs");//check
                }
                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("{0}, Legs: {1}",base.ToString(), this.NumberOfLegs);

            return output.ToString().TrimEnd();
        }
    }
}