using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Grass : Plant
    {
        const int InitialSize = 2;
        public Grass(Point location)
            : base(location, InitialSize)
        {
        }

        public override void Update(int time)
        {
            this.Size += time;
            base.Update(time);
        }
    }
}
