//3. Write a method that from a given array of students finds
//  all students whose first name is before its last name
//  alphabetically. Use LINQ query operators.
//
//4. Write a LINQ query that finds the first name and last name
//of all students with age between 18 and 24.
//
//5.Using the extension methods OrderBy() and ThenBy()
//with lambda expressions sort the students by first name
//and last name in descending order. Rewrite the same with LINQ.
//
//9.Create a class student with properties FirstName, LastName, FN,
//Tel, Email, Marks (a List<int>), GroupNumber. Create a List<Student>
//with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.
//
//10.Implement the previous using the same query expressed with extension methods.
//Look at file LinqSamples
//
//11.Extract all students that have email in abv.bg. Use string methods and LINQ.
//
//12.Extract all students with phones in Sofia. Use LINQ.
//
//13.Select all students that have at least one mark Excellent
//(6) into a new anonymous class that has properties – FullName
//and Marks. Use LINQ.
//
//14. Write down a similar program that extracts the students with
//exactly  two marks "2". Use extension methods.
//
//15.Extract all Marks of the students that enrolled in 2006. (The students\
//from 2006 have 06 as their 5-th and 6-th digit in the FN).
//
//16.* Create a class Group with properties GroupNumber and DepartmentName.
//Introduce a property Group in the Student class. Extract all students from
//"Mathematics" department. Use the Join operator.
//
//17.Write a program to return the string with maximum length from
//an array of strings. Use LINQ.
//
//18.Create a program that extracts all students grouped by GroupName and then
//prints them to the console. Use LINQ.
//
//19.Rewrite the previous using extension methods.

namespace HomeWork
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LinqSamplesAndExtentions
    {
        //
        //4. Write a LINQ query that finds the first name and last name
        //of all students with age between 18 and 24.
        //
        public static IEnumerable<Student> Between18And24(Student[] value)
        {
            var result =
                from stud in value
                where stud.Age > 18 && stud.Age < 24
                select stud;

            return result;
        }

        //
        //3. Write a method that from a given array of students finds
        //  all students whose first name is before its last name
        //  alphabetically. Use LINQ query operators.
        //
        public static IEnumerable<Student> FirstNameBeforeLastName(Student[] value)
        {
            var result =
                from stud in value
                where stud.FName.CompareTo(stud.LName) < 0
                select stud;

            return result;
        }

        //
        //9.Create a class student with properties FirstName, LastName, FN,
        //Tel, Email, Marks (a List<int>), GroupNumber. Create a List<Student>
        //with sample students. Select only the students that are from group number 2.
        //Use LINQ query. Order the students by FirstName.
        //
        public static IEnumerable<Student> SelectStudentsByGroupAndSortByFname(IEnumerable<Student> students, int groupNumber)
        {
            var studentsByGroup =
                from stud in students
                where stud.Group.GroupNumber == groupNumber
                orderby stud.FName
                select stud;

            return studentsByGroup;
        }

        public static IEnumerable<Student> SelectStudentsByGroupAndSortByFnameExt(this IEnumerable<Student> students, int groupNumber)
        {
            return SelectStudentsByGroupAndSortByFname(students, groupNumber);
        }

        //
        //5.Using the extension methods OrderBy() and ThenBy()
        //with lambda expressions sort the students by first name
        //and last name in descending order. Rewrite the same with LINQ.
        //
        public static IEnumerable<Student> SortStudentsFNameThenByLName(Student[] value)
        {
            var result =
                from stud in value
                orderby stud.FName descending, stud.LName
                select stud;

            return result;
        }

        //
        //11.Extract all students that have email in abv.bg. Use string methods and LINQ.
        //
        public static IEnumerable<Student> AllStudentsWithGivenEmail(IEnumerable<Student> students, string domainName)
        {
            var result =
              from stud in students
              where stud.Email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries)[1].Trim() == domainName.Trim()
              select stud;

            return result;
        }

        //
        //12.Extract all students with phones in Sofia. Use LINQ.
        //
        public static IEnumerable<Student> StudentsWithPhoneInSofia(IEnumerable<Student> students, string phoneNumber)
        {
            var result =
              from stud in students
              where stud.Tel.Substring(0, 2) == phoneNumber.Trim()
              select stud;

            return result;
        }

        //
        //13.Select all students that have at least one mark Excellent
        //(6) into a new anonymous class that has properties – FullName
        //and Marks. Use LINQ.
        //
        public static IEnumerable<Student> StudentsWithGivenMarks(IEnumerable<Student> students, int marks)
        {
            var result =
              from stud in students
              where stud.Marks.Contains(marks)
              select stud;

            return result;
        }

        //
        //14. Write down a similar program that extracts the students with
        //exactly  two marks "2". Use extension methods.
        //
        public static IEnumerable<Student> StudentsWithGivenMarksExt(this IEnumerable<Student> students, int marks, int times)
        {
            var result =
              from stud in students
              where StudentWithExactlyMarks(stud.Marks, times) == 2
              select stud;

            return result;
        }

        //
        //16.* Create a class Group with properties GroupNumber and DepartmentName.
        //Introduce a property Group in the Student class. Extract all students from
        //"Mathematics" department. Use the Join operator.
        //
        public static IEnumerable<Student> StudentFromDepartment(IEnumerable<Student> students, string DepartmentName)
        {
            var result =
              from stud in students
              where stud.Group.DepartmentName.Trim() == DepartmentName.Trim()
              select stud;

            return result;
        }

        //
        //14. Write down a similar program that extracts the students with
        //exactly  two marks "2". Use extension methods.
        //
        private static int StudentWithExactlyMarks(List<int> list, int times)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item == times)
                {
                    count++;
                }
            }
            return count;
        }

        //
        //15.Extract all Marks of the students that enrolled in 2006. (The students\
        //from 2006 have 06 as their 5-th and 6-th digit in the FN).
        //
        public static List<int> AllMarksFromGivenYear(IEnumerable<Student> students, int year)
        {
            string thisYear = year.ToString();
            var result =
              from stud in students
              where stud.FN[4] == thisYear[2] && stud.FN[5] == thisYear[3]
              select stud;
            List<int> allMarks = new List<int>();
            foreach (var item in result)
            {
                foreach (var marks in item.Marks)
                {
                    allMarks.Add(marks);
                }
            }

            return allMarks;
        }

        //
        //17.Write a program to return the string with maximum length from
        //an array of strings. Use LINQ.
        //
        public static string MaximumString(IEnumerable<string> strings)
        {
            int maxLength = strings.Max(x => x.Length);

            var result = from str in strings
                         where str.Length == maxLength
                         select str;

            return result.First();
        }

        //18.Create a program that extracts all students grouped by GroupName and then
        //prints them to the console. Use LINQ.

        public static IEnumerable<Student> StudentByGroupName(IEnumerable<Student> students, string groupName)
        {
            var result = from stud in students
                         where stud.Group.GroupName == groupName
                         select stud;

            return result;
        }

        //
        //19.Rewrite the previous using extension methods.

        public static IEnumerable<Student> StudentByGroupNameAllEnumerable(this IEnumerable<Student> students, string groupName)
        {
            var result = from stud in students
                         where stud.Group.GroupName == groupName
                         select stud;

            return result;
        }
    }
}