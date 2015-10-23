using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingHW
{
    class StudentMark:Student
    {
        public string GroupName 
        {
            get;
            set;
        }

        public StudentMark(Student student , string groupName):base (student.FirstName,student.LastName,student.Age,student.FacultyNumber
            ,student.Phone,student.Email,student.Marks,student.GroupNumber) // class Student is the base
        {
            GroupName = groupName;
        }

    }
}
