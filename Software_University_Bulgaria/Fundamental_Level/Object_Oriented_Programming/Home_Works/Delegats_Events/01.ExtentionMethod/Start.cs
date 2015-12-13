using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    class Start
    {
        static void Main(string[] args)
        {
            var list = new List<int>{1,4,5,60,50,};

            list.WhereNot(e => e % 2 == 0)
                .ToList().ForEach(Console.WriteLine); // 1 and 50

            Console.WriteLine(list.Maximum(i => i)); // 60

            var students = new List<Student>
            {
                new Student{Name = "Jonny",Age = 33},
                new Student{Name = "Tonny",Age = 40},
                new Student{Name = "Philipe",Age = 23},

            };

            Console.WriteLine(students.Maximum(s => s.Age)); // return 40
            Console.WriteLine(students.Min(s => s.Age));  // return 23
            Console.WriteLine(students.OrderBy(s => s.Name)); // alphabetic order
            
        }
    }
}
