using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingHW
{
    class StudentSpecialty
    {
        public string Specialty { get; set; }  // prop
        public int FacultyNumber { get; set; }

        public StudentSpecialty(string specialty, int facultyNumber) // ctor
        {
            this.Specialty = specialty; // Creating the Objects; 
            this.FacultyNumber = facultyNumber;
        }

    }
}
