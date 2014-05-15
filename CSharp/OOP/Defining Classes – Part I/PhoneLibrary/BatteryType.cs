//3. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new
//  field for the batteries.

namespace PhoneLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Enumeration of battery type, easy to add new types.
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }
}
