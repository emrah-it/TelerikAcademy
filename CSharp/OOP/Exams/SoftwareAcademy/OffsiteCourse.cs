namespace SoftwareAcademy
{
    using System;
    using System.Linq;
    using System.Text;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher techer, string town) : base(name, techer)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Local course lab name cannot be null");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Local course lab name cannot empty or only with white spaces");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(base.ToString());

            output.AppendFormat("; Town={0}", this.Town);

            return output.ToString();
        }
    }
}