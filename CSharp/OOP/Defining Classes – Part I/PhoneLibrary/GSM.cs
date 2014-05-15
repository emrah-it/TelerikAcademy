//1. Define a class that holds information about a mobile phone device: 
//  model, manufacturer, price, owner, battery characteristics (model, 
//  hours idle and hours talk) and display characteristics (size and number
//  of colors). Define 3 separate classes (class GSM holding instances of the 
//  classes Battery and Display).
//
//2. Define several constructors for the defined classes that take
//  different sets of arguments (the full information for the class 
//  or part of it). Assume that model and manufacturer are mandatory 
//  (the others are optional). All unknown data fill with null.
//
//4. Add a method in the GSM class for displaying all information about it.
//  Try to override ToString().
//
//5. Use properties to encapsulate the data fields inside the GSM, 
//  Battery and Display classes. Ensure all fields hold correct data at 
//  any given time.
//
//6.Add a static field and a property IPhone4S in the GSM class to 
//  hold the information about iPhone 4S.
//
//9. Add a property CallHistory in the GSM class to hold a 
//  list of the performed calls. Try to use the system \
//  class List<Call>.
//
//10.Add methods in the GSM class for adding and 
//deleting calls from the calls history. Add a method 
//to clear the call history.
//
//11. Add a method that calculates the total price of the 
//calls in the call history. Assume the price per minute 
//is fixed and is provided as a parameter.
//



namespace PhoneLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSM
    {
        #region Property field

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private decimal priceOfMinute;

        private Battery battery;
        private Display display;
        private List<Call> callHistory;
        #endregion


        static public GSM iPhone4s = new GSM(new Battery("Iphone4s", 10, 1000, BatteryType.LiIon),
                                                new Display(2, 16000000),"Iphone4s","Telerik","Apple", 1010);

        #region All properties


        public int TotalCallHistory
        {
            get
            {
                return this.callHistory.Count;
            }
           
        }

        public decimal PriceOfMinute
        {
            get
            {
                return this.priceOfMinute;
            }
            set
            {
                Validate.ValidatePrice(value);
                this.priceOfMinute = value;
            }
        }

        //Model of GSM get set
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                Validate.ValidateModelAndManufacturer(value);
                this.model = value;
            }
        }

        //Manufacturer name get set
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                Validate.ValidateModelAndManufacturer(value);
                this.manufacturer = value;
            }
        }

        //Price of GSM get set
        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                Validate.ValidatePrice(value);
                this.price = value;
            }
        }

        //Owner of phone get set
        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                Validate.ValidName(value);
                this.owner = value;
            }
        }

        //Display size get set
        public double? DisplaySize
        {
            get
            {
                return display.Size;
            }
            set
            {
                this.display.Size = value;
            }
        }

        //Display colors
        public int? DisplayColos
        {
            get
            {
                return this.display.NumberOfColors;
            }
            set
            {
                this.display.NumberOfColors = value;
            }
        }

        //Battery model can get set
        public string BatteryModel {
            get
            {
                return this.battery.Model;
            }
            set
            {
                this.battery.Model = value;
            }
        }

        //Idle hours get set
        public short? HoursIdle {
            get
            {
                return this.battery.HoursIdle;
            }
            set
            {
                this.battery.HoursIdle = value;
            }
        }

        //Idle talk get set
        public short? HourseTalk{
            get
            {
                return this.HourseTalk;
            }
            set
            {
                this.battery.HourseTalk = value;
            }
        }

        public BatteryType? BattertyType {
            get
            {
                return this.battery.BattertyType;
            }
            set
            {
                this.battery.BattertyType = value;
            }
        }

        //Add new battery, or get all battery parameters
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = new Battery(battery);
            }
        }

        //Add new display, or get all display parameters
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = new Display(display);
            }
        }
        #endregion


        private GSM()
        {
            this.callHistory = new List<Call>();
        }
        public GSM(Battery battery, Display display, string model, string owner, string manufacturer, decimal? price = null):this()
        {
            this.battery = new Battery(battery);
            this.display = new Display(display);
            this.model = model;
            this.owner = owner;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public GSM(string model, string manufacturer)
            : this()
        {
            this.battery = new Battery();
            this.display = new Display();
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        //Biggest constructor, it can be added all parameters
        public GSM(string model, string manufacturer, decimal? price = null,
            string owner = null)
            : this()
        {
            battery = new Battery();
            display = new Display();

            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }
        

        //Override ToString, to print correctly message
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Manufacturer: {0}\n", this.manufacturer);
            result.AppendFormat("Model: {0}\n", this.model);
            if (this.Price != null)
            {
                result.AppendFormat("Price: {0}\n", this.Price);
            }
            else if (this.Owner != null)
            {
                result.AppendFormat("Owner: {0}\n", this.Owner);
            }
            result.AppendLine(battery.ToString());
            result.AppendLine(display.ToString());
            
            return result.ToString().Trim('\n');
        }

        //Add calls to history
        public void AddCalls(double duration, string phoneNumber, DateTime startDate)
        {
            this.callHistory.Add(new Call(startDate, phoneNumber, duration));
        }

        //Total removed numbers
        public int RemoveCallWithPhoneNumber(string phoneNumber)
        {
            int counter = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (callHistory[i].PhoneNumber == phoneNumber)
                {
                    this.callHistory.RemoveAt(i);
                    counter++;
                }
            }
            return counter;
        }

        public void RemoveAllCalls()
        {
            this.callHistory.Clear();
        }

        public decimal CallculateTotalCost(decimal priceOfMinute )
        {
            double totatlDUration = 0;
            foreach (var item in callHistory)
            {
                totatlDUration += item.Duration;
            }
            decimal totalPrice = (decimal)(totatlDUration / 60) * priceOfMinute;
            return totalPrice;
        }
        public decimal TotalPriceWithCurrentPrice()
        {
            return CallculateTotalCost(this.priceOfMinute);
        }
        

        public void ChoosePositionToRemove()
        {
            PrintCallHistory();
            Console.WriteLine("Enter position you want, separate with ' ' or ','");
            var split = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            List<Call> callsToRemove = new List<Call>();
            for (int i = 0; i < split.Length; i++)
            {
                callsToRemove.Add(this.callHistory[int.Parse(split[i])]);
            }

            for (int i = 0; i < callsToRemove.Count; i++)
            {
                callHistory.Remove(callsToRemove[i]);
            }
        }

        private void PrintCallHistory()
        {
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                Console.WriteLine("{0} {1}",i , callHistory[i]);
            }
        }
    }
}
