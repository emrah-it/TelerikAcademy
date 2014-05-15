//4.Create a class Person with two fields – name and age. Age can be left unspecified
//(may contain null value. Override ToString() to display the information of a person and
//if age is not specified – to say so. Write a program to test this functionality.

namespace HomeWork
{
    using System.Text;

    public class Person
    {
        public string Name { get; set; }

        public byte? Age { get; set; }

        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        public Person(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder toReturn = new StringBuilder();
            toReturn.AppendFormat("Name: {0}\n", this.Name);
            if (this.Age != null)
            {
                toReturn.AppendFormat("Age: {0}\n", this.Age);
            }
            else
            {
                toReturn.Append("Age is not specified");
            }
            return toReturn.ToString();
        }
    }
}