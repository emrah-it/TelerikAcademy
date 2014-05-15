using System;
using System.Linq;

namespace Infestation
{
    public class Marine : Human
    {
        public Marine(string id) : base(id)
        {
            //TODO: add suplements
            this.AddSupplement(new WeaponrySkill()); 
        }
    }
}