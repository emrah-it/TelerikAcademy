using System;
using System.Linq;

namespace Infestation
{
    public class Tank : Unit
    {
        private const int InitialPower = 25;
        private const int InitialHealth = 20;
        private const int InitialAggression = 25;
        private const UnitClassification InitialClassification = UnitClassification.Mechanical;

        public Tank(string id) : base(id,
        InitialClassification,
        InitialHealth,
        InitialPower,
        InitialAggression)
        {
        }
    }
}