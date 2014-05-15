﻿using System;
using System.Linq;

namespace Infestation
{
    public abstract class Suplement : ISupplement
    {
        public Suplement(int powerEffect, int healthEffect, int aggressionEffect)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = aggressionEffect;
        }
      
        public int PowerEffect { get; protected set; }

        public int HealthEffect { get; protected set; }

        public int AggressionEffect { get; protected set; }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
            //TODO: Implement
        }
    }
}