using System;
using System.Collections.Generic;
using System.Linq;

namespace Infestation
{
    public class Parasite : Unit
    {
        private const int InitialPower = 1;
        private const int InitialHealth = 1;
        private const int InitialAggression = 1;
        private const UnitClassification InitialClassification = UnitClassification.Biological;

        public Parasite(string id) : base(id, InitialClassification, InitialHealth, InitialPower, InitialAggression)
        {
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = this.GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo current = attackableUnits.First();

            foreach (var item in attackableUnits)
            {
                if (item.Health > current.Health)
                {
                    current = item;
                }
            }

            return current;
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (!(unit is Parasite))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}