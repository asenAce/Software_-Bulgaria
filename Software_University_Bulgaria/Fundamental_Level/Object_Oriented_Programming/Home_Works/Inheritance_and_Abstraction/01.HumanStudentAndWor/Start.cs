using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWor
{
    class Start
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>()
            {
                new Student("First Name","Second Name","FacultyNumber#"),
                new Student("First Name","Second Name","FacultyNumber#"),
                new Student("First Name","Second Name","FacultyNumber#"),
                new Student("First Name","Second Name","FacultyNumber#"),
                new Student("First Name","Second Name","FacultyNumber#"),
                new Student("First Name","Second Name","FacultyNumber#"),
                new Student("First Name","Second Name","FacultyNumber#"),
                // 
            };


            var sortedStudents = students.OrderBy(x => x.FacultyNumber);
            Console.WriteLine("Ordered students (by Faculty Numbers): ");
            PrintList(sortedStudents);

            List<Worker> workers = new List<Worker>()
            {
                new Worker("First Name ","Second Name", 23.89, 16),
                new Worker("First Name ","Second Name", 23.19, 30),
                new Worker("First Name ","Second Name", 23.19, 50),
                new Worker("First Name ","Second Name", 20.89, 196),
            };

            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("Ordered workers (by hourly salary): ");
            PrintList(sortedWorkers);

            List<Human> peoples = new List<Human>(20);
            peoples.AddRange(students);
            peoples.AddRange(workers);

            var sortedPeople = peoples.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            Console.WriteLine("Ordered people (by first Name and last Name): ");
            PrintList(sortedPeople);

        }

        private static void PrintList(IOrderedEnumerable<Human> sortedPeople)
        {
            foreach (var human in sortedPeople)
            {
                Console.WriteLine(human);
            }

            Console.WriteLine();
        }

        private static void PrintList(IOrderedEnumerable<Worker> sortedWorkers)
        {
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();
        }


        private static void PrintList(IOrderedEnumerable<Student> sortedStudents)
        {

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        

       
    }
}
