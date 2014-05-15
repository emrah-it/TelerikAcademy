namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : ITeacher
    {
        private readonly ICollection<ICourse> coures;

        private string name;

        public Teacher(string name)
        {
            this.Name = name;
            this.coures = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Teacher name cannot be null");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Teacher name cannot empty or only with white spaces");
                }

                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.coures.Add(course);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("Teacher: Name={0}", this.Name);

            if (this.coures.Count > 0)
            {
                output.Append("; Courses=[");

                output.Append(string.Join(", ", this.coures));

                output.Append("]");
            }

            return output.ToString();
        }
    }
}