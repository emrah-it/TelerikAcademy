//8.Create a class Call to hold a call performed through a GSM. 
//  It should contain date, time, dialed phone number and 
//  duration (in seconds).

namespace PhoneLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Call
    {
        private DateTime date;
        private string phoneNumber;
        private double duration;


        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                Validate.ValidatePhoneNumber(value);
                this.phoneNumber = value;
            }
        }

        public double Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                Validate.Duration(value);
                this.duration = value;
            }
        }

        public Call(DateTime startDate, string phoneNumber)
        {
            this.date = startDate;
            this.phoneNumber = phoneNumber;
            this.Duration = (int)DateTime.Now.Subtract(startDate).TotalSeconds;
        }
        public Call(string phoneNumber, int duration)
        {
            this.phoneNumber = phoneNumber;
            this.duration = duration;
            date = DateTime.Now.AddSeconds(-duration);
        }
        public Call(DateTime date, string phoneNumber, double duration)
        {
            this.Date = date;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1} {2}", this.date, this.phoneNumber, this.Duration);
            return result.ToString().Trim('\n');
        }
    }
}
