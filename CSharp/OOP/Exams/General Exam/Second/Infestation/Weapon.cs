using System;
using System.Linq;

namespace Infestation
{
    public class Weapon : Suplement
    {
        private const int InitialPowerEffect = 10;
        private const int InitialHealthEffect = 0;
        private const int InitialAggressionEffect = 3;

        public Weapon() : base(InitialPowerEffect, InitialHealthEffect, InitialAggressionEffect)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is Weapon)
            {
                this.AggressionEffect = InitialAggressionEffect;
                this.PowerEffect = InitialPowerEffect;
                this.HealthEffect = InitialHealthEffect;
            }
        }
    }
}