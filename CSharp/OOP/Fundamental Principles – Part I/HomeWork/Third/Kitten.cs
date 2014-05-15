namespace HomeWork.Third
{
    using System;

    public class Kitten : Animals
    {
        public Sex SexOfAnimal { get { return this.SexOfAnimal; } }
        public Kitten(string name, byte age)
            : this()
        {
            this.Name = name;
            this.Age = age;
        }
        public Kitten()
        {
            this.Sex = Sex.Female;
            this.SoundOfAnimal = "Maac pis pis pis";
        }
    }
}
