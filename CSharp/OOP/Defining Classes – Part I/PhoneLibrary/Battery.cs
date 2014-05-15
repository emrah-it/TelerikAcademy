using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneLibrary
{
    public class Battery
    {
        private string model;
        private short? hoursIdle;
        private short? hourseTalk;
        private BatteryType? battertyType;

        //Model of battery
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                //Chek is valid name and set it.
                Validate.ValidName(model);
                this.model = value;
            }
        }

        //Idle hours to work
        public short? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                //Chek is valid input
                Validate.BatteryValidate(value,  "hours battery idle");
                this.hoursIdle = value;
            }
        }

        //Talk hours
        public short? HourseTalk
        {
            get
            {
                return this.hourseTalk;
            }
            set
            {
                //Chek is valid talk hours
                Validate.BatteryValidate(hoursIdle, "hourse talk");
            }
        }
        
        //Battery type
        public BatteryType? BattertyType
        {
            get
            {
                return this.battertyType;
            }
            set
            {
                this.battertyType = value;
            }
        }

        //Battery constructor, easy to add directly parameters of battery
        public Battery(Battery battery)
        {
            this.model = battery.Model;
            this.hourseTalk = battery.HourseTalk;
            this.hoursIdle = battery.HoursIdle;
            this.battertyType = battery.BattertyType;

        }


        //To add every part separately
        public Battery(string model = null, short? hourseIdle = null, short? hourseTalk = null, BatteryType? typeOfBattery = null)
        {
            Validate.ValidName(model);
            this.model = model;

            Validate.BatteryValidate(hourseIdle, "hours idle");
            Validate.BatteryValidate(hourseTalk, "hours talk");

            this.hourseTalk = hourseTalk;
            this.hoursIdle = hourseIdle;
            this.battertyType = typeOfBattery;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.Model != null)
            {
                result.AppendFormat("Battery Model: {0}\n", this.Model);
            }
            if (this.HourseTalk != null)
            {
                result.AppendFormat("Battery hours talk: {0}\n", this.HourseTalk);
            }
            if (this.HoursIdle != null)
            {
                result.AppendFormat("Battery hours idle: {0}\n", this.HoursIdle);
            }
            if (this.BattertyType != null)
            {
                result.AppendFormat("Battery hours talk: {0}\n", GetBatteryTypeToString(this.BattertyType));
            }
            return result.ToString().Trim('\n');
        }

        private string GetBatteryTypeToString(BatteryType? nullable)
        {
            switch (nullable)
            {
                case BatteryType.LiIon:
                    return "Li-Ion";
                case BatteryType.NiMH:
                    return "NiMH";
                case BatteryType.NiCd:
                    return "NiCd";
            }
            throw new ArgumentException();
        }
    }
}
