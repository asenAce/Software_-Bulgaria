using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Scott's book";
            g1 = new GradeBook();

            Console.WriteLine(g2.Name);

            int x1 = 4;
            int x2 = x1;

            x1 = 100;
            Console.WriteLine(x2);



            //GradeBook book = new GradeBook();
            //book.AddGrade(91f);
            //book.AddGrade(89.5f);
            //book.AddGrade(75f);

            //GradeStatistics stats= book.ComputeStatistics();
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);

          // GradeBook book2 = new GradeBook();
          //  book2.AddGrade(76);
        }
    }
}
