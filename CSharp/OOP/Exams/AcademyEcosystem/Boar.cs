using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Boar : Animal, IHerbivore, ICarnivore
    {
        private const int InitialSize = 4;
        public Boar(string name, Point location)
            : base(name, location, InitialSize)
        {
        }

        //The Boar should be able to eat any animal, which is smaller
        //than him or as big as him. The Boar should be able to eat 
        //from any plant. The Boar always has a bite size of 2. 
        //When eating from a plant, the Boar increases its size by 1.
        public int EatPlant(Plant plant)
        {
            if (null != plant)
            {
                this.Size++;
                return plant.GetEatenQuantity(2);
            }
            return 0;
        }

        public int TryEatAnimal(Animal animal)
        {

            if (null != animal)
            {
                return animal.GetMeatFromKillQuantity();
            }
            return 0;
        }
    }
}
