using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.University
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string firstName,string lastName,int studentNumber,float averageGrade,int age = 0)
            : base(firstName,lastName,studentNumber,averageGrade,age)
        {

        }

    }
}
