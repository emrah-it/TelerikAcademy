namespace HomeWork
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private string fName;
        private string mName;
        private string lName;
        private int ssn;
        private string adress;
        private string mobilePhone;
        private string email;
        private int course;
        private Specialties secialties;
        private Faculties faculty;
        private Universities university;
        private bool equal;

        public bool Equal
        {
            get
            {
                return this.equal;
            }
            set
            {
                this.equal = value;
            }
        }

        public string FName
        {
            get
            {
                return this.fName;
            }
            set
            {
                this.fName = value;
            }
        }

        public string MName
        {
            get
            {
                return this.mName;
            }
            set
            {
                this.mName = value;
            }
        }

        public string LName
        {
            get
            {
                return this.lName;
            }
            set
            {
                this.lName = value;
            }
        }

        public int Ssn
        {
            get
            {
                return this.ssn;
            }
            set
            {
                this.ssn = value;
            }
        }

        public string Adress
        {
            get
            {
                return this.adress;
            }
            set
            {
                this.adress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }

        public Specialties Secialties
        {
            get
            {
                return this.secialties;
            }
            set
            {
                this.secialties = value;
            }
        }

        public Faculties Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }

        public Universities University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }

        public Student(bool equal)
        {
            this.equal = equal;
        }

        public Student()
        {
        }

        public override string ToString()
        {
            StringBuilder tostring = new StringBuilder();
            tostring.AppendFormat("First Name: {0}", this.FName);
            tostring.AppendFormat("Middle Name: {0}", this.MName);
            tostring.AppendFormat("Last Name: {0}", this.LName);
            tostring.AppendFormat("SSB: {0}", this.Ssn);
            tostring.AppendFormat("Permanent Address: {0}", this.FName);
            tostring.AppendFormat("MobilePhone: {0}", this.MobilePhone);
            tostring.AppendFormat("E-mail: {0}", this.Email);
            tostring.AppendFormat("Course: {0}", this.Course);
            tostring.AppendFormat("Specialties: {0}", SpecialitiesToString(this.Secialties));
            tostring.AppendFormat("Faculty: {0}", FacultyToString(this.Faculty));
            tostring.AppendFormat("University: {0}", UniversityToString(this.University));
            return tostring.ToString();
        }

        private string UniversityToString(Universities universities)
        {
            switch (universities)
            {
                case Universities.TechniclaUniversity:
                    return "Technical University";

                case Universities.KlimentOhridski:
                    return "Kliment Ohridski";

                case Universities.NewBulgarianUniversity:
                    return "New Bulgarian University";
            }
            throw new ArgumentException();
        }

        private string FacultyToString(Faculties faculties)
        {
            switch (faculties)
            {
                case Faculties.Automation:
                    return "Automation";

                case Faculties.MatematikAndInforomation:
                    return "Mathematik and Information";
            }
            throw new ArgumentException();
        }

        private string SpecialitiesToString(Specialties current)
        {
            switch (current)
            {
                case Specialties.Automation:
                    return "Automation";

                case Specialties.ComputerSience:
                    return "Computer Sience";

                case Specialties.Softwareengineering:
                    return "Software engineering";
            }
            throw new ArgumentException();
        }

        public static Student operator ==(Student first, Student second)
        {
            return new Student(first.Equals(second));
        }

        public static Student operator !=(Student first, Student second)
        {
            return new Student(!first.Equals(second));
        }

        public override bool Equals(object obj)
        {
            Student cmp = obj as Student;
            if ((object)cmp == null)
            {
                return false;
            }
            return (this.FName == cmp.FName) && (this.Ssn == cmp.Ssn) && (this.LName == cmp.LName);
        }

        public object Clone()
        {
            Student newStudent = new Student();

            newStudent.FName = this.FName;
            newStudent.LName = this.LName;
            newStudent.MName = this.MName;
            Ssn = this.Ssn;

            newStudent.Adress = this.Adress;
            newStudent.MobilePhone = this.MobilePhone;
            newStudent.Email = this.Email;
            newStudent.Course = this.Course;
            newStudent.Secialties = this.Secialties;
            newStudent.Faculty = this.Faculty;
            newStudent.University = this.University;
            newStudent.Equal = this.Equal;

            return newStudent;
        }

        public int CompareTo(Student other)
        {
            if (this.FName.CompareTo(other.FName) == 0)
            {
                if (this.Ssn.CompareTo(other.Ssn) < 0)
                {
                    return 1;
                }
                else if (this.Ssn.CompareTo(other.Ssn) > 0)
                {
                    return -1;
                }
                return 0;
            }
            else
            {
                return this.FName.CompareTo(other.FName);
            }
        }
    }
}