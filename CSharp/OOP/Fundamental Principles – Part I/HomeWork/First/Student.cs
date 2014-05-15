namespace HomeWork.First
{
    using System;

    public class Student : NameAttribute, IComment, IPeople
    {
        private int uniqueClassNumber;
        private string optionalComments;
        public int UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }
            set
            {
                this.uniqueClassNumber = value;
            }
        }

        public string OptionalComments
        {
            get
            {
                return this.optionalComments;
            }
            set
            {
                this.optionalComments = value;
            }
        }
        public Student(string name)
        {
            this.Name = name;
        }
        public Student()
        { }

    }
}
