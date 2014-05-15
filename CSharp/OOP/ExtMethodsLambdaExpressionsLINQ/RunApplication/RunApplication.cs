using HomeWork;
using HomeWork.MyEventHadnler;
using System;
using System.Collections.Generic;

//Run all test, there have a lot of information
namespace RunApplication
{
    internal class RunApplication
    {
        private static void Main()
        {
            // Може да бъдат пуснати тестовете и да се прегледа кода от там
            //Test for 7.
            //Timer.CallMethod(WriteTest, 1);
            Console.WriteLine(CalculateSecuence.ConvergentSum(index => 1 / Math.Pow(2, index - 1), 0.01));
            PrintStudentWithGivenGroup();
            PrintStudentWithGivenGroupExt();
            PrintMaxString();


            Publisher evnt = new Publisher();
            Subscriber first = new Subscriber("first one", evnt);
            Subscriber second = new Subscriber("second one", evnt);
            evnt.MakeSomething();
        }


        private static void PrintMaxString()
        {
            List<string> words = new List<string>(){
                "rtdtwerhwerhwerhrfe",
                "rtdtwerhwerhwerhwerhwerhrfe",
                "sgdfgsdfgsdfg",
                "rtdwerwtrfe",
                "wrthwerhqwerthwerh",
                "rtdtwerhwrfe",
                "rtdtrwerwerhfe",
            };
            string result = LinqSamplesAndExtentions.MaximumString(words);
            Console.WriteLine(result);
        }

        private static void PrintStudentWithGivenGroupExt()
        {
            List<Student> value = StudentWithGroup();
            var result = LinqSamplesAndExtentions.StudentByGroupName(value, "Fasion");
            foreach (var item in result)
            {
                Console.WriteLine(item.FName);
            }
        }

        private static void PrintStudentWithGivenGroup()
        {
            List<Student> value = StudentWithGroup();

            var result = value.StudentByGroupNameAllEnumerable("Fasion");
            foreach (var item in result)
            {
                Console.WriteLine(item.FName);
            }
        }

        static public void WriteTest()
        {
            Console.WriteLine("aaa");
        }

        public static List<Student> StudentWithGroup()
        {
            List<Student> allStudents = new List<Student>(){
                new Student("Pesho", new Group(1 , "Department", "Fasion")),
                new Student("Gosh", new Group(1 , "Department", "Fasion")),
                new Student("Disho", new Group(1 , "Department", "asdg")),
                new Student("Face", new Group(1 , "Department", "Fasion")),
                new Student("Space", new Group(1 , "Department", "asda")),
            };
            return allStudents;
        }
    }
}