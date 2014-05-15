using System;
using FurnitureManufacturer.Interfaces;
using System.Text;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted;
        private decimal initialHeight;
        private string materialType;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.isConverted = false;
            this.initialHeight = this.Height;
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }

            private set
            {
                this.isConverted = value;
            }

        }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
            if (this.IsConverted)
            {
                this.Height = 0.10M;
            }
            else if (!this.IsConverted)
            {
                this.Height = this.initialHeight;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("{0}, State: {1}", base.ToString(),
                 this.IsConverted ? "Converted" : "Normal");


            return output.ToString().TrimEnd();
        }
    }
}