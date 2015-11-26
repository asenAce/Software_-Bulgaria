using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.University
{
    public abstract class CurrentStudent : Student
    {
        private IList<String> currentCourses;

        public CurrentStudent(string firstName,string lastName,int studentNumber,float averageGrade,int age = 0 )
            : base(firstName,lastName,studentNumber,averageGrade,age)
        {
            this.CurrentCourses = new List<String>();
        }

        public IList<String> CurrentCourses
        {
            get
            {
                return this.currentCourses;
            }
            set
            {
                if (value == null )
                {
                    throw new ArgumentException("Incorrect");
                }
                this.currentCourses = value;
            }
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            string courses = String.Join(", ",this.CurrentCourses);
            return baseStr + string.Format(", Courses: {0}", courses);
        }

    }
}
