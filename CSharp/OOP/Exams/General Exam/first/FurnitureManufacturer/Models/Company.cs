using System;
using System.Collections.Generic;
using System.Linq;
using FurnitureManufacturer.Interfaces;
using System.Text;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {

        private const int RegistrationNumberLength = 10;

        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string initialName, string initalRegistrationNumber)
        {
            this.Name = initialName;
            this.RegistrationNumber = initalRegistrationNumber;
            furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name can't be null");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cant be empty, or with white spaces");
                }

                if (value.Length < 5)
                {
                    throw new ArgumentException("Name is too short, have to be more than 5 symbols");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Registration number can't be null");
                }

                {
                    ulong num;
                    if (!ulong.TryParse(value, out num))
                    {
                        throw new ArgumentException("Registration number shoul contain only numbers");
                    }
                }

                if (value.Length != RegistrationNumberLength)
                {
                    throw new ArgumentException("Registration number should be exacly 10 digits");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(this.furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }


        //Chek for returning result is it null if cnat find element
        public IFurniture Find(string model)
        {
            foreach (var item in this.Furnitures)
            {
                if (item.Model == model)
                {
                    return item;
                }
            }

            return null;
        }

        //        (company name) – (number of furniture/”no”) (“furniture”/”furnitures”)
        //(information about furniture)
        //(information about furniture)
        //(information about furniture)
        public string Catalog()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));
            output.AppendLine();
            if (this.Furnitures.Count > 0)
            {
                var toPrint = this.Furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model);

                foreach (var item in toPrint)
                {
                    output.AppendLine(item.ToString());
                }
            }

            return output.ToString().TrimEnd();
        }
    }
}