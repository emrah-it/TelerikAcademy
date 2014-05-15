using System;
using FurnitureManufacturer.Interfaces;
using System.Text;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        private const int MinimumHeight = 0;
        private const int MinimumPrice = 0;

        private string model;
        private decimal price;
        private decimal height;
        private string material;


        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Price = price;
            this.Height = height;
            this.Material = material;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Model can't be null");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cant be empty, or with white spaces");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Model is too short, Have to be more than 3 symbols");
                }

                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.material;
            }
            private set
            {
                
                this.material = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < MinimumPrice)
                {
                    throw new ArgumentException("Price cannot be less or equal to $0.00");
                }

                this.price = value;
            }
        }


        public decimal Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                if (value < MinimumHeight)
                {
                    throw new ArgumentException("Height cannot be less or equal to 0.00 m.");
                }

                this.height = value;
            }
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                 this.GetType().Name, this.Model, this.Material, this.Price, this.Height);

            return output.ToString().TrimEnd();
        }
    }
}