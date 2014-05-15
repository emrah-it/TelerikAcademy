namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Knight : Character, IFighter
    {
        private const int KinghtDefaultAttackPoints = 100;
        private const int KinghtDefaultDefenseoints = 100;
        private const int KinghtDefaultHitPointPoints = 100;

        public Knight(string name, Point position, int owner) : base(name, position, owner)
        {
            this.HitPoints = KinghtDefaultHitPointPoints;
        }

        public int AttackPoints
        {
            get
            {
                return KinghtDefaultAttackPoints;
            }
        }

        public int DefensePoints
        {
            get
            {
                return KinghtDefaultDefenseoints;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}