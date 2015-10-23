using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingHW
{
    class Student // shift +alt + c  = create a Class
    {
        public string FirstName 
        { 
            get;
            set;
        }

        public string LastName 
        {
            get; 
            set;
        }

        public int Age 
        {
            get;
            set;
        }

        public int FacultyNumber 
        {
            get;
            set;
        }

        public string Phone // prop--> tab tab  proparty access modifaer public type String ID Phone 
        {
            get;
            set;
        }

        public string Email 
        {
            get; 
            set;
        }

        public IList<int> Marks
        {
            get;
            set;
        }

        public int GroupNumber 
        {
            get;
            set;
        }

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        { // ctor --> tab tab Constructor

            this.FirstName = firstName;  // Instatiate the prop  
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;


        }


    }
}
