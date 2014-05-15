using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Third
{
    public class Tomcat:Animals
    {
        public Sex SexOfAnimal { get { return this.SexOfAnimal; } }
        public Tomcat(string name, byte age)
            : this()
        {
            this.Name = name;
            this.Age = age;
        }
        public Tomcat()
        {
            this.Sex = Sex.Male;
            this.SoundOfAnimal = "Maac pis pis pis";
        }
    }
}
