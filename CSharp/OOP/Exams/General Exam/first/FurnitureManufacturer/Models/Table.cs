using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width):
            base(model,materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Length have to be bigger than zero");
                }

                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Widnth have to be bigger than zero");
                }

                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("{0}, Length: {1}, Width: {2}, Area: {3}",base.ToString(),
                this.Length, this.Width, this.Area);

            return output.ToString().TrimEnd();
        }


    }
}
