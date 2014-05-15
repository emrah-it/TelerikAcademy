using System;
using System.Linq;

namespace Infestation
{
    public class InfestationSpores : Suplement
    {
        private const int InitialPowerEffect = -1;
        private const int InitialHealthEffect = 0;
        private const int InitialAggressionEffect = 20;

        public InfestationSpores() : base(InitialPowerEffect, InitialHealthEffect, InitialAggressionEffect)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.AggressionEffect = 0;
                this.HealthEffect = 0;
                this.PowerEffect = 0;   
            }
        }
    }
}