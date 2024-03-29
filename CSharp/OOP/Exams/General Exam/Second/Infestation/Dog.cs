﻿using System;
using System.Linq;

namespace Infestation
{
    public class Dog : Unit
    {
        private const int DogPower = 5;
        private const int DogAggression = 2;
        private const int DogHealth = 4;

        public Dog(string id) : base(id, UnitClassification.Biological, Dog.DogHealth, Dog.DogPower, Dog.DogAggression)
        {
        }
    }
}