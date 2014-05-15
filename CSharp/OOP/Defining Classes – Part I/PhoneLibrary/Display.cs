using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneLibrary
{
    public class Display
    {
        private double? size;
        private int? numberOfColors;

        // Setter check is correct size
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                Validate.ValidateSizeOfDisplay(value);
                this.size = value;
            }
        }

        // Setter check is correct number of colors
        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                Validate.ValidateColor(value);
                this.numberOfColors = value;
            }
        }


        //Separately add every property
        public Display(double? displeySize = null, int? numberOfColors = null)
        {
            Validate.ValidateSizeOfDisplay(displeySize);
            Validate.ValidateColor(numberOfColors);

            this.size = displeySize;
            this.numberOfColors = numberOfColors;
        }
        
        //Add new display
        public Display(Display display)
        {
            this.size = display.size;
            this.numberOfColors = display.numberOfColors;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.Size != null)
            {
                result.AppendFormat("Size of Display: {0}\n", this.Size);
            }
            if (this.numberOfColors != null)
            {
                result.AppendFormat("Numbers of color: {0}\n", this.NumberOfColors);
            }
            return result.ToString().Trim('\n');
        }
    }
}
