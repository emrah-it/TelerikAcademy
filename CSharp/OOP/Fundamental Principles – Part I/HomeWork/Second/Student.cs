namespace HomeWork.Second
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Student : Human
    {
        private int grade;
        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        public Student(string name, int grad)
        {
            this.FirstName = name;
            this.grade = grad;
        }
    }
}
