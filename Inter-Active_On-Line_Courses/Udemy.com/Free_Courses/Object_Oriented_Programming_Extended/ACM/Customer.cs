using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Enums;
using Acme.Common.Interfaces;
//using ACM;
//using ACM.Repositories;
//using Acme;

namespace ACM
{
   public class Customer : EntityBase, ILoggable
    {
        string lastName;

        public Customer()
            :this(0)
        {

        }

        public Customer(int customerID)
        {
            this.CustomerID = customerID;
            AddressList = new List<Address>();
        }

        //public Address HomeAddress { get; set; }
        //public Address WorkAddress { get; set; }  OR
        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }
        public static int InstanceCount { get; set; }
        public string FirstName { get; set; }

        public string LastName 
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string Email { get; set; }

        public int CustomerID { get; private set; }

        public string FullName 
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ",";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }
            
        }


        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                isValid = false;
            }

            return isValid;
        }
       // Polymorph
        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logString = this.CustomerID + ": " + this.FullName + " " +
                "Email: " + this.Email;
              //  "Status: " + this.EntityState.ToString();

              return logString;
        }


        //string ILoggable.Log()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
