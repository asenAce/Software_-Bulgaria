using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.HumanStudentAndWor
{
    class Student: Human
    {
        private const string FACULTINUMBERERRORMSG = @"[A-zA-Z0-9]{5,10}";
        private const int MINFACULNUMBLENGHT = 5;
        private const int MAXFACULNUMBLENGHT = 10;

        private string facultyNumber; // why not int??

        public Student(string firstName, string lastName, string  facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber 
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                
                if (!ValidateFacultyNumber(value))
                {
                    throw new ArgumentException("Incorrect");
                }
                this.facultyNumber = value;
            }
        }

        public static bool ValidateFacultyNumber(string number)
        {
            return Regex.IsMatch(number,FACULTINUMBERERRORMSG);
        }

        public override string ToString()
        {

            return base.ToString() + "\nFaculty number : " + this.FacultyNumber + "\n";
        } 

    }
}
