using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.University
{
    class Student : Person
    {

        private int studentNumber;
        private float averageGrade;


        public Student(string firstName, string lastName, int studentNumber,int age = 0)
            :base(firstName,lastName,age)
        {
            this.StudentNumber = studentNumber;
        }

        public Student(string firstName, string lastName, int studentNumber, float averageGrade, int age = 0)
            : this(firstName, lastName,studentNumber,age)
        {
            this.AverageGrade = averageGrade;
        }

        public Student(string firstName, string lastName,int age = 0)
            :base(firstName,lastName,age)
        {

        }

        public int StudentNumber 
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                if (value == null || value < 0 )
                {
                    throw new ArgumentException("Invalid");
                }

                
                this.studentNumber = value;
            }
        }

        public float AverageGrade 
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                if (averageGrade < 0 || averageGrade == null )
                {
                    throw new ArgumentNullException("Invalid");
                }
                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format(",Student Number: {0},Average Grade:{1},",this.StudentNumber , this.AverageGrade);
        }

    }
}
