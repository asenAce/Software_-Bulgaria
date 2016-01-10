using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public ThrowAwayGradeBook(string name)  // ctor
                :base(name)
        {
            Console.WriteLine("throwaway ctor");
        }

        public GradeStatistics ComputeStatistics()
        {

            Console.WriteLine("Throw away");
            float lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                lowest = Math.Min(lowest,grade);
            }

            grades.Remove(lowest);
            return base.ComputeStatistics();
        }


    }
}
