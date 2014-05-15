using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore
    {
        public const int InitialSize = 6;
        public Lion(string name, Point location)
            : base(name, location, InitialSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            //The Lion should be able to eat any animal, which is 
            //at most twice larger than him (inclusive).
            //Also, the Lion should grow by 1 with each animal it eats.
            if (animal != null)
            {
                if (animal.Size <= this.Size * 2)
                {
                    this.Size++;
                    return animal.GetMeatFromKillQuantity();
                }
            }
            return 0;
        }
    }
}
