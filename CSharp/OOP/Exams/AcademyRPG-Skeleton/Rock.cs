﻿namespace AcademyRPG
{
    using System;
    using System.Linq;

    public class Rock : StaticObject, IResource
    {
        private const int RockDefaultOwner = 0;

        public Rock(int hitPoints, Point position) : base(position, RockDefaultOwner)
        {
            this.HitPoints = hitPoints;
        }

        public int Quantity
        {
            get
            {
                return this.HitPoints / 2;
            }
        }

        public ResourceType Type
        {
            get 
            { 
                return ResourceType.Stone; 
            }
        }
    }
}