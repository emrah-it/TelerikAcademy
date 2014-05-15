using System;
using System.Collections.Generic;
using System.Linq;
using HomeWork.Second;
using HomeWork.Third;
using System.Threading.Tasks;

namespace Run
{
    class Program
    {
        static void Main()
        {
            List<Student> allStudents = new List<Student>()
             {
                 new Student("HHH", 5),
                 new Student("asd", 4),
                 new Student("fds", 12),
                 new Student("werg", 1),
                 new Student("wnw", 3),
                 new Student("sdrfy", 2),
                 new Student("ery", 6),
                 new Student("bsdf", 9),
                 new Student("wer", 7),
                 new Student("bsd", 8),
                 new Student("ngwrt", 1),
             };

            var soretdStudents = allStudents.OrderBy(x => x.Grade);
            foreach (var item in soretdStudents)
            {
                Console.WriteLine(item.FirstName+ " " + item.Grade );
            }
            List<ISound> allAnimals = new List<ISound>(){
                new Tomcat(), new Dog(), new Cat(), new Kitten(), new Frog()
            };

            foreach (var item in allAnimals)
            {
                Console.WriteLine(item.SoundOfAnimal);
            }

            List<Worker> allWorkers = new List<Worker>()
            {
                new Worker(80, 100),
                new Worker(80, 90),
                new Worker(80, 98),
                new Worker(80, 80),
                new Worker(80, 65),
                new Worker(80, 88),
                new Worker(80, 78),
                new Worker(80, 99),
                new Worker(80, 101),
                new Worker(80, 96),
                new Worker(80, 94),
                new Worker(80, 50),
                new Worker(80, 45)
            };
            var soretd = allWorkers.OrderByDescending(x => x.MoneyPerHours());
            foreach (var item in soretd)
            {
                Console.WriteLine(item.WeekSalary);
            }
        }
    }
}
