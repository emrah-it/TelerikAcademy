namespace HomeWork
{
    using System.Collections.Generic;

    public class Student
    {
        public Student(string fname, string lName, string FN, byte age)
        {
            this.FName = fname;
            this.LName = lName;
            this.Age = age;
            this.FN = FN;
        }

        public Student(string fName, int groupNumber)
        {
            this.FName = fName;
            this.Group = new Group(groupNumber, null);
        }

        public Student(string name, string email)
        {
            this.FName = name;
            this.Email = email;
        }

        public Student(string name, string lname, string phone)
        {
            this.FName = name;
            this.LName = lname;
            this.Tel = phone;
        }

        public Student(string name, params int[] marks)
        {
            this.FName = name;
            this.Marks = new List<int>();
            foreach (var item in marks)
            {
                this.Marks.Add(item);
            }
        }

        public Student(string fn, string name, params int[] marks)
        {
            this.FName = name;
            this.FN = fn;
            this.Marks = new List<int>();
            foreach (var item in marks)
            {
                this.Marks.Add(item);
            }
        }

        public Student(string fName, Group current)
        {
            this.FName = fName;
            this.Group = current;
        }

        public byte Age { get; set; }

        public string Email { get; set; }

        public string FN { get; set; }

        public string FName { get; set; }

        public Group Group { get; set; }

        public string LName { get; set; }

        public List<int> Marks { get; set; }

        public string Tel { get; set; }
    }
}