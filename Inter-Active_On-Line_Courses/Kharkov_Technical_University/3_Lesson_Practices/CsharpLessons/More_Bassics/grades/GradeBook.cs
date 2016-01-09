using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class GradeBook
    {
        public GradeBook()  //int maximumGrades
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade < 100)
            {
               grades.Add(grade);
            }
    
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();


            float sum = 0f;

            foreach (float grade in grades)
            {
                /**
                if (grade > stats.HighestGrade)
                {
                    stats.HighestGrade = grade;
                }
                 * */
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum = sum + grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public string Name;


        private List<float> grades;


        
    }
}
 