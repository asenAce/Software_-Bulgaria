using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook : GradeTracker
    {
        #region State
        #endregion State

        #region Behevior 
        #region GradeBook Construcor
        public GradeBook()  // ctor == constructor
            : this("No name")
        {
          //  grades = new List<float>(); // Data structor List<>
        }
        #endregion GradeBook Construcor

        public GradeBook(string name = "No name")
        {
            Console.WriteLine("gradebook ctor");
            Name = name;
            grades = new List<float>();
        }


        #region AddGrade Function
        // Method or Function,Functionality
        public void AddGrade(float grade)  // I am giving parameters.
        {
            if (grade >= 0 && grade < 100) // If the condition is met.
            {
                grades.Add(grade);  //Add variable grade to the List grades.
            }
            
        }
        #endregion AddGrade Function
        #region ComputeStatistics Function


        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook Compute");
            GradeStatistics stats = new GradeStatistics(); // Instantiate an Object stats
            
            float sum = 0f;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade,stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade,stats.LowestGrade);
                sum = sum + grade;
            }
            //The calculation is it the Lowest grade if so throw it away
            
            stats.AverageGrade = sum / grades.Count; //formula
            return stats;
        }
        #endregion ComputeStatistics Function
        #endregion Behevior
        /**
        private string name;
        
        public string Name
        {
            get
            {
                return name;
            }
         
         * set
         * {
         *      if(!String.IsNullOrEmpty(value))
         *      {
         *          name = value;
         *      }
         *      
         * }
        }
        **/
        //Data struction
        protected   List<float> grades;


        public void WriteGrades(TextWriter textWriter)
        {
            textWriter.WriteLine("Grades :");
            foreach (float grade in grades)
            {
                textWriter.WriteLine(grade);
            }
            textWriter.WriteLine("************");   // After we finish loopingh
        }

       



        
    }
}
