using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.University
{
    class OnSiteStudent : CurrentStudent
    {

        private int visitNumber;

        public OnSiteStudent(string firstName, string lastName, int studentNumber, float averageGrade, int age = 0, int visitNumber = 0)
            : base(firstName,lastName,studentNumber,averageGrade,age)
        {
            this.VisitNumber = visitNumber;
        }

        public int VisitNumber 
        {
            get
            {
                return this.visitNumber;
            }
            set
            {
                if (value < 0 || value == null)
                {
                    throw new ArgumentException("Incorrect");
                }
                this.visitNumber = value;
            }
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format("\n Visits : {0} ",this.visitNumber);
        }

    }
}
