using HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HomeWorkTest
{
    [TestClass]
    public class LinqSamplesUI
    {
        [TestMethod]
        public void AllStudentsWithGivenEmailUI()
        {
            List<Student> value = ListFromStudentsWithEmail();

            var takeAll = LinqSamplesAndExtentions.AllStudentsWithGivenEmail(value, "abv.bg");
            Student solution = null;
            foreach (var item in takeAll)
            {
                if (item.Email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries)[1].Trim() != "abv.bg")
                {
                    throw new ArgumentException();
                }
                break;
            }
        }

        [TestMethod]
        public void WithPhoneInSofia()
        {
            List<Student> value = ListFromStudentsWithPhone();

            var takeAll = LinqSamplesAndExtentions.StudentsWithPhoneInSofia(value, "02");
            Student solution = null;
            foreach (var item in takeAll)
            {
                if (item.Tel.Substring(0, 2) != "02")
                {
                    throw new ArgumentException();
                }
                break;
            }
        }

        [TestMethod]
        public void StudentsWithMarksUI()
        {
            List<Student> value = ListFromStudentsWithMarks();

            var takeAll = LinqSamplesAndExtentions.StudentsWithGivenMarks(value, 6);
            Student solution = null;
            foreach (var item in takeAll)
            {
                if (!item.Marks.Contains(6))
                {
                    throw new ArgumentException();
                }
                break;
            }
        }

        [TestMethod]
        public void StudentsWithMarksWithTimesUI()
        {
            List<Student> value = ListFromStudentsWithMarks();

            var takeAll = value.StudentsWithGivenMarksExt(2, 2);
            Student solution = null;
            foreach (var item in takeAll)
            {
                if (!item.Marks.Contains(2))
                {
                    throw new ArgumentException();
                }
                break;
            }
        }

        [TestMethod]
        public void StudentsWithGivenGroup()
        {
            List<Student> value = StudentsWithGroupDepartment();

            var takeAll = LinqSamplesAndExtentions.StudentFromDepartment(value, "Matematic");
            Student solution = null;
            foreach (var item in takeAll)
            {
                if (!(item.Group.DepartmentName == "Matematic"))
                {
                    throw new ArgumentException();
                }
                break;
            }
        }

        private List<Student> StudentsWithGroupDepartment()
        {
            List<Student> students = new List<Student>(){
                new Student("Peshi", new Group(1, "Matematic")),
                new Student("qwe", new Group(1, "Fisic")),
                new Student("asdf", new Group(1, "Matematic")),
                new Student("asdf", new Group(1, "Biology")),
                new Student("qrbq", new Group(1, "Matematic")),
                new Student("adf", new Group(1, "History")),
                new Student("asdg", new Group(1, "Matematic"))
            };
            return students;
        }

        private List<Student> ListFromStudentsWithMarks()
        {
            List<Student> students = new List<Student>(){
                new Student("Peshi", 1,2,3,4,5),
                new Student("qwe", 1,2,3,2,4,5,6),
                new Student("asdf", 1,2,3,4,5),
                new Student("asdf", 1,2,3,4,5,6),
                new Student("qrbq", 1,2,3,4),
                new Student("adf", 1,2,3,4,2,5),
                new Student("asdg", 1,2,3,4,5,6)
            };
            return students;
        }

        [TestMethod]
        public void Between18And24()
        {
            Student[] value = StudentToReturn();

            var takeAll = LinqSamplesAndExtentions.Between18And24(value);
            bool solution = false;
            foreach (var item in takeAll)
            {
                if (item.FName == "Nese")
                {
                    solution = true;
                }
            }
            Assert.AreEqual(true, solution);
        }

        [TestMethod]
        public void FirstNameBeforeLastNameTest()
        {
            Student[] value = StudentToReturn();

            var takeAll = LinqSamplesAndExtentions.FirstNameBeforeLastName(value);
            bool solution = false;
            foreach (var item in takeAll)
            {
                if (item.FName == "Aesho")
                {
                    solution = true;
                }
            }
            Assert.AreEqual(true, solution);
        }

        [TestMethod]
        public void SortStudentsFNameThenByLName()
        {
            List<Student> value = ListFromStudents();

            var takeAll = LinqSamplesAndExtentions.SelectStudentsByGroupAndSortByFname(value, 2);
            Student solution = null;
            foreach (var item in takeAll)
            {
                if (item.Group.GroupNumber == 2)
                {
                    throw new ArgumentException();
                }
                break;
            }
        }

        [TestMethod]
        public void SortStudentsFNameThenByLNameExtUI()
        {
            List<Student> value = ListFromStudents();

            var takeAll = value.SelectStudentsByGroupAndSortByFnameExt(2);
            Student solution = null;
            foreach (var item in takeAll)
            {
                if (item.Group.GroupNumber == 2)
                {
                    throw new ArgumentException();
                }
                break;
            }
        }

        [TestMethod]
        public void SortStudentsFNameThenByLNameUI()
        {
            Student[] value = StudentToReturn();

            var takeAll = LinqSamplesAndExtentions.SortStudentsFNameThenByLName(value);
            Student solution = null;
            foreach (var item in takeAll)
            {
                solution = item;
                break;
            }

            Assert.AreEqual("Zeorgi", solution.FName);
        }

        private List<Student> ListFromStudents()
        {
            List<Student> value = new List<Student> { new Student("Nqkoi", 2),
             new Student("Nese", 3),
             new Student("Zeorgi", 2),
             new Student("Nikolai",  4),
             new Student("Aesho", 2),
            };
            return value;
        }

        private Student[] StudentToReturn()
        {
            Student[] value = new Student[] { new Student("Nqkoi", "Si","", 15),
             new Student("Nese", "Kazva", "", 19),
             new Student("Zeorgi", "Petkov","", 100),
             new Student("Nikolai", "Georgiev","", 12),
             new Student("Aesho", "Peshov","", 14),
            };
            return value;
        }

        private List<Student> ListFromStudentsWithEmail()
        {
            List<Student> value = new List<Student> { new Student("Nqkoi", "aaas@abv.bg"),
             new Student("Nese", "aaas@abv.bg"),
             new Student("Zeorgi", "aaas@a12bv.bg"),
             new Student("Nikolai",  "aaas@ab3v.bg"),
             new Student("Aesho", "aaas@abv.bg"),
            };
            return value;
        }

        private List<Student> ListFromStudentsWithPhone()
        {
            List<Student> value = new List<Student> { new Student("Nqkoi", "Pesho", "025584856"),
             new Student("Nese",  "Pesho", "0255234656"),
             new Student("Zeorgi",  "Pesho", "025583457"),
             new Student("Nikolai",   "Pesho", "035584856"),
             new Student("Aesho",  "Pesho", "055584856"),
            };
            return value;
        }
    }
}