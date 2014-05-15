using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary
{
    static class Validate
    {
        // Validate name, if name is incorrect throw argument expetion
        static public void ValidName(string currName)
        {
            if (currName != null && currName.Trim() == string.Empty)
            {
                throw new ArgumentNullException("Please enter correct name");
            }
        }

        // Validate battery hourse idle and talk, chek is it correct.
        //If isn't correct throw expetion, and write type of battery
        static public void BatteryValidate(short? currentNumber, string batteryType)
        {
            if (currentNumber < 0 && currentNumber > 10000)
            {
                throw new ArgumentException(string.Format("Enter correct value {0}", batteryType));
            }
        }

        //Validate color. Number of colors have to be more tha 1 color
        static public void ValidateColor(int? color)
        {
            if (color < 1)
            {
                throw new ArgumentException("Disppaly can be mimimum with 2 colors");
            }
        }

        //Validate size of display. Minimum requairment is is bigger than zero
        static public void ValidateSizeOfDisplay(double? color)
        {
            if (color < 0)
            {
                throw new ArgumentException("Disppaly size have to be with minimum size 0.1 inc");
            }
        }

        //Price have to be positive decimal number
        static public void ValidatePrice(decimal? price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Price cant be negative");
            }
        }

        static public void ValidateModelAndManufacturer(string currentName)
        {
            if (currentName == null || currentName.Trim() == string.Empty)
            {
                throw new ArgumentException("String cant be empty and null");
            }

        }

        static public void ValidatePhoneNumber(string phoneNumber)
        {
            ulong number = ulong.Parse(phoneNumber);
            if (phoneNumber.Length < 1 || !ulong.TryParse(phoneNumber,out number) || number < 0)
            {
                throw new ArgumentException("Incorrect number");
            }
        }

        internal static void Duration(double duration)
        {

            if (duration < 0)
            {
                throw new ArgumentException("Duration have to be bigger or equal to  0");
            }
        }
    }
}
