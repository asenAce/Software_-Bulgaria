using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.University
{
    class DropoutStudent : Student
    {

        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int studentNumber, float averageGrade, string dropoutReason, int age = 0)
            : base(firstName,lastName,studentNumber,averageGrade,age)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason 
        {
            get
            {
                return this.dropoutReason;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Incorrect");
                }
                this.dropoutReason = value;
            }
        }

        public override string ToString()
        {

            return base.ToString() + string.Format(",Dropoutty the reason: {0}",this.DropoutReason) ;
        } 

        public void Reapply()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
