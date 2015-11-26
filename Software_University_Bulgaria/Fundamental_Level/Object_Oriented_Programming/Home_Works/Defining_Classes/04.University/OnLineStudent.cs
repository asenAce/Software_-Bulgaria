using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.University
{
    class OnLineStudent : CurrentStudent
    {

        public OnLineStudent(string firstName,string lastName,int studentNumber,float averageGrade, int age = 0)
            : base(firstName,lastName,studentNumber,averageGrade,age)
        {

        }

    }
}
