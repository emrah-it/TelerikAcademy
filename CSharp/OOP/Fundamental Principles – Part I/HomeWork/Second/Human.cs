namespace HomeWork.Second
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                ValidateName(value);
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                ValidateName(value);
                this.firstName = value;
            }
        }

        private void ValidateName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid user name");
            }
        }
    }
}
