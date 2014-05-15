namespace HomeWork.Third
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cat:Animals
    {
        public Cat(string name, byte age, Sex sex):this()
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex; 
        }
        public Cat()
        {
            this.SoundOfAnimal = "Myau Myau";
        }
    }
}
