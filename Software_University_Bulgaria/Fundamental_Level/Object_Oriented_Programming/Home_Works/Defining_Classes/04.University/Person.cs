using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.University
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName, string lastName, int age)
            : this(firstName,lastName)
        {
            this.Age = age;
        }

        public int Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Incorrect");
                }
                this.age = value;
            }
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value == null || value.Length < 3)
                {
                    throw new ArgumentException("Incorrect");
                }
                this.firstName = value;
            }
        }

        public string LastName 
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3 || value == null)
                {
                    throw new ArgumentException("Incorrect");
                }
                this.lastName = value; 
            }
        }

        public override string ToString()
        {

            return string.Format("{3}: Name: {0} {1}, {2} years old",this.FirstName,this.LastName,this.Age,GetType().Name);
        }


    }
}
