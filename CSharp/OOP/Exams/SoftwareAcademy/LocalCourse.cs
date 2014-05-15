namespace SoftwareAcademy
{
    using System;
    using System.Linq;
    using System.Text;

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab) : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Local course lab name cannot be null");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Local course lab name cannot empty or only with white spaces");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(base.ToString());

            output.AppendFormat("; Lab={0}", this.Lab);

            return output.ToString();
        }
    }
}