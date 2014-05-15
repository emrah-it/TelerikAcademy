namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Giant : Character, IFighter, IGatherer, IControllable
    {
        private const int GiantDefaultOwner = 0;
        private const int GiantDefaultAttackPoints = 150;
        private const int GiantDefaultDefensePoints = 80;
        private const int GiantDefaultHitPoints = 80;
        private const int GaintDefaultAddAttacPoints = 100;

        private const int NotFound = -1;

        public Giant(string name, Point position) : base(name, position, GiantDefaultOwner)
        {
            this.HitPoints = GiantDefaultHitPoints;
            this.AttackPoints = GiantDefaultAttackPoints;
            this.IsGahered = false;
        }

        public int AttackPoints { get; private set; }

        public int DefensePoints
        {
            get
            {
                return GiantDefaultDefensePoints;
            }
        }

        private bool IsGahered { get; set; }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return NotFound;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!this.IsGahered)
                {
                    this.IsGahered = true;
                    this.AttackPoints += GaintDefaultAddAttacPoints;
                }

                return true;
            }

            return false;
        }
    }
}