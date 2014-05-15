namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Ninja : Character, IFighter, IGatherer
    {
        private const int NinjaDefaultHitpoints = 1;
        private const int NinjaDefaultAttackPoints = 0;
        private const int NotFound = -1;

        public Ninja(string name, Point position, int owner) : base(name, position, owner)
        {
            this.HitPoints = NinjaDefaultHitpoints;
            this.AttackPoints = NinjaDefaultAttackPoints;
        }

        public int AttackPoints { get; private set; }

        public int DefensePoints
        {
            get
            {
                return int.MaxValue;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var objectHaveMaxHitPoits =
                                       from obj in availableTargets
                                       orderby obj.HitPoints descending
                                       select obj;

            foreach (var item in objectHaveMaxHitPoits)
            {
                if (item.Owner != this.Owner && item.Owner != 0)
                {
                    return availableTargets.IndexOf(item);
                }
            }

            return NotFound;
        }

        public void GatherAttackPoints(int points)
        {
            this.AttackPoints += points;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }

            return false;
        }
    }
}