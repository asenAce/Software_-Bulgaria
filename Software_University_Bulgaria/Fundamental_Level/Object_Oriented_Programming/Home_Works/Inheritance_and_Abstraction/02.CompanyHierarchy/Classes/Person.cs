using _02.CompanyHierarchy.IContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyHierarchy
{
    abstract class Person : IPerson
    {
        private   int iD;
        private string firstName;
        private string lastName;


        public Person (int iD,string firstName,string lastName)
	        {

                this.ID = iD;
                this.FirstName = firstName;
                this.LastName = lastName;
                
	        }

        public int ID 
        {
            get
            {
                return this.iD;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }
                this.iD = value;
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

                if (string.IsNullOrWhiteSpace(value))
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Incorrect");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "ID: {0}\nFirst Name: {1}\nLast Name:{2}\n"
                ,this.ID
                ,this.FirstName
                ,this.LastName);
        }



    }
}
