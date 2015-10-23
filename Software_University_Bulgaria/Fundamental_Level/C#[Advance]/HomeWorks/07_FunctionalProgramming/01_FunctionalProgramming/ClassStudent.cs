using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingHW
{
    /*
     * Task 01.
     * */
    class ClassStudent : Student // Inherited class Student shift+alt+ = Class Menue....
    {
        static void Main(string[] args)
        {
            #region InPutTheInfo
            
            var students = new List<Student>  //Declaring a Generic List<> of students 
            {

                //Adding the Information
            new Student("Ivan","Dirido",20,24545,"+359867343","ivan@abv.bg",new List<int>{5,3,4,3},1),
            new Student("Burabura","Duradura",23,354355,"03003030","burabuga@abv.bg",new List<int>{5,63,5,2},1),
            new Student("huffo","fsdfdd",33,244555,"+359858583","huffo@abv.bg",new List<int>{8,43,2,4},2),
            new Student("rwere","rwett",33,233444,"+3598992929","rwere@mail.bg",new List<int>{66,55,3,3},2),
            new Student("Assdsd","dasds",12,255555,"+1987777","ass@abv.bg",new List<int>{34,44,2,4},1),
            new Student("SDADSD","Ssdsdsd",23,455444,"+1948484","sdsd@mail.bg",new List<int>{656,23,23,5},2),
            };


            // Instantiationg a Generic List<> 

            List<StudentSpecialty> specialties = new List<StudentSpecialty>()  // Creating a second List<>
            {
                new StudentSpecialty("Web Developer",235567),  // Creating an object StudentSpecialty has two prop specialty and faculty number the info then is store into 
                // the List<class> StudentSpecialty
                new StudentSpecialty("Web Developer",345567),
                new StudentSpecialty("PHP Developer",534543),
                new StudentSpecialty("C# Developer",643634),
                new StudentSpecialty("Android Developer",454355),
                new StudentSpecialty("iOS Developer",454355),
                new StudentSpecialty("Java Developer Junior",4565463),
                new StudentSpecialty("Java Developer Senior",213244),
                new StudentSpecialty("Web Base Technologies",235445),
                new StudentSpecialty("Project Manager  ",4234325),

            };

            #endregion InPutTheInfo

            #region CallingTheMethods

            

            TaskOneStudentsByGroup(students); // First i am writing the call Method then on the blue drop menue i am Generated it hit F12 
            // a worm hole took me right into the Method to finished  it...

            TaskTwoStudentsByFirstAndLastName(students); // call the specific Method hit F12 to have a close look

            TaskThreeStudentsByAge(students);

            TaskFiveSortTheStudents(students);

            TaskSixSortTheStudentsTwo(students);

            TaskSevenFilterStudentsByEmail(students); // The method filter the information regrding the students by Email Domains..criteria

            TaskEightFilterStudentsByPhone(students);

            TaskNineExcellentStudents(students);

            TaskTenWeekStudents(students);

            TaskStudentsEnrolled(students);

            TaskTwelveStudentsByGroups(students);

            TaskThirteenStudentsBySpecialties(students, specialties);

            #endregion CallingTheMethods

        }

        

  
        

        private static void TaskOneStudentsByGroup(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;     //GUI
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Task Two output: ");
            Console.ResetColor();

            var studentsQuery = from student in students // var student in the generic List<> : class Student do iteretion
                                where student.GroupNumber == 2 // object student dot separetor . call GroupNumber == 2; 
                                orderby student.FirstName  // Clasify by FirstName
                                select student; // then return student

            foreach (var st in studentsQuery)  // iteration st in studentsQuery past through each one...
            {
                Console.WriteLine("{0} {1} : {2}",st.FirstName,st.LastName,st.GroupNumber); // place holder possitions 1-2-3
            }
        }

        private static void TaskTwoStudentsByFirstAndLastName(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Task three output: ");
            Console.ResetColor();

            var studentsQuery = from student in students
                                where student.FirstName.CompareTo(student.LastName) < 0
                                select student;

            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1}",st.FirstName,st.LastName);
            }
        }

        private static void TaskThreeStudentsByAge(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Task Four output : ");
            Console.ResetColor();

            var studentsQuery = from student in students
                                where student.Age >= 18 && student.Age <= 24
                                select new
                                {
                                    student.FirstName,student.LastName,student.Age
                                };

            foreach (var student in studentsQuery)
            {
                Console.WriteLine("{0} {1} {2}",student.FirstName,student.LastName,student.Age);
            }


        }

        private static void TaskFiveSortTheStudents(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Task Five OutPut: ");
            Console.ResetColor();

            var studentsQuery = from student in students
                                orderby student.FirstName descending, student.LastName descending
                                select student;

            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1} ",st.FirstName,st.LastName);
            }
        }

        private static void TaskSixSortTheStudentsTwo(List<Student> students) // Method
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Task Six output");
            Console.ResetColor();

            var studentsQuery = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            foreach (var st in students)
            {
                Console.WriteLine("{0} {1}",st.FirstName,st.LastName);
            }

        }


        private static void TaskSevenFilterStudentsByEmail(List<Student> students)
        {
            //GUI
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Task seven output: ");
            Console.ResetColor();

            var studentsQuery = from student in students
                                where student.Email.Contains("@abv.bg") // Object student . prop Email . call the method Contains() 
                                // passing the parameters "@abv.bg" looking for this!!!!
                                select student;

            foreach (var st in students)
            {
                Console.WriteLine("{0} {1} {2}",st.FirstName,st.LastName,st.Email);
            }

        }

        private static void TaskEightFilterStudentsByPhone(List<Student> students) // passing the parameters 
        {
            //GUI
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            var studentsQuery = from student in students
                                where student.Phone.Contains("02") || student.Phone.Contains("+359") || student.Phone.Contains("+1")
                                select student;

            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1} {2}",st.FirstName,st.LastName,st.Phone);
            }

        }

        private static void TaskNineExcellentStudents(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Task Nine output: ");
            Console.ResetColor();

            var studentsQuery = from student in students
                                where student.Marks.Contains(6) // Object--> . prop -->. Method()  value(6)
                                select new  
                                {
                                    FullName = student.FirstName + " " + student.LastName,student.Marks  // Concatinetion
                                };

            foreach (var st in students) // Iteration
            {
                Console.WriteLine(st.FirstName + ":" + string.Join(", ",st.Marks));
            }
        }


        private static void TaskTenWeekStudents(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" Task Ten OutPut: ");
            Console.ResetColor();

            var studentsQuery = students.Where(student => student.Marks.Count(mark => mark == 2) == 2)
                .Select(student => new { FullName = student.FirstName + " " + student.LastName, student.Marks });

            foreach (var st in students)
            {
                Console.WriteLine(st.FirstName + ":" + string.Join(", ",st.Marks));
            }

        }

        private static void TaskStudentsEnrolled(List<Student> students)
        {
            // Students that enrolled in 2014 

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Students enrolled in 2014");
            Console.ResetColor();

            var studentsQuery = from student in students
                                where student.FacultyNumber % 100 == 14  // this is how we check is it 2014 when we divaded on 100 if 
                                // the left number is 14 that mean that the year is 2014 ex. 2014 / 100 = 14;
                                select student;

            foreach (var st in students)
            {
                Console.WriteLine("{0} {1} FacultyNumber: {2}  Marks: {3}", st.FirstName, st.LastName, st.FacultyNumber, string.Join(", ", st.Marks));
            }
        }

        private static void TaskTwelveStudentsByGroups(List<Student> students)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Task Twelve Students by Groups: ");
            Console.ResetColor();

            var studentsWithGroupName = new List<StudentMark>(); // Class StudentMark

            foreach ( Student st in students)
            {
                string groupName;

                switch (st.GroupNumber)
                {
                    case 1:
                        groupName = "Basic";
                        break;
                    case 2:
                        groupName = "Fundamentals";
                        break;
                    case 3:
                        groupName = "Front-End";
                        break;
                    case 4:
                        groupName = "Back-End";
                        break;
                    default:
                        groupName = "Alumni";
                        break;
                }
                studentsWithGroupName.Add(new StudentMark(st,groupName));
            }

            var studentsQuery = from student in studentsWithGroupName
                                group student by student.GroupName;

            foreach (var pair in studentsQuery)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(pair.Key);
                Console.ResetColor();

                foreach (var st in pair)
                {
                    Console.WriteLine("First Name: {0} Last Name: {1} Groups Name: {2}",st.FirstName,st.LastName,st.GroupName);
                }
            }

        }

        private static void TaskThirteenStudentsBySpecialties(List<Student> students, List<StudentSpecialty> specialties)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" Students Joined by Specialties");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("|{0,15}|{1,-15}|{2,-20}|"," ",""," ");
            Console.WriteLine("|{0,15}|{1,-15}|{2,-20}|", " Name", "Faculty Number", "Specialty ");
            Console.WriteLine("|{0,15}|{1,-15}|{2,-20}|", " ", "", " ");

            var studentsQuery = from student in students
                                join specialty in specialties on student.FacultyNumber equals specialty.FacultyNumber
                                select new { student.FirstName, student.LastName, student.FacultyNumber, specialty.Specialty };

            int counter = 1;

            foreach (var st in studentsQuery)
            {
                if (counter % 2 == 0) // even
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("|{0,15}|{1,-15}|{2,-20}|",st.FirstName + " " + st.LastName,st.FacultyNumber,st.Specialty);
                counter++;
              
            }

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|{0,15}|{1,-15}|{2,-20}|","","","");
            Console.ResetColor();



        }

    } 

    
}
