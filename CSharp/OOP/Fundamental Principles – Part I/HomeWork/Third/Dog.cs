using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Third
{
    public class Dog : Animals
    {
        public Dog(string name, byte age, Sex sex):this()
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex; 
        }
        public Dog()
        {
            this.SoundOfAnimal = "Bau Bau";
        }
    }
}
