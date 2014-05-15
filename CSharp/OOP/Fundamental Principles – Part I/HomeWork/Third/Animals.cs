using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Third
{
    public class Animals: ISound
    {
        private byte age;
        private string name;
        private string soundOfAnimal;
        private Sex sex;

        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid age");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
               
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value;
            }
        }

        public Sex Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }

        public string SoundOfAnimal
        {
            get
            {
                return this.soundOfAnimal;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cant be empty or null string");
                }
                this.soundOfAnimal = value;
            }
        }

        public void Sound()
        {
            Console.WriteLine(this.SoundOfAnimal);
        }
    }
}
