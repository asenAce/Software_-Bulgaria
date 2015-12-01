using _02.MunicipalBank.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MunicipalBank.Customers
{
    class Customer : ICustomer
    {

        private string name;


        public Customer(string name,CustomerType customerType)
        {

            this.CustomerType = customerType;
            this.Name = name;

        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Incorrect");    
                }

                else if (value.Length <= 3)
                {
                    throw new ArgumentException("Requarement minimum 3 worlds for the name.","name");
                }

                this.name = value;
            }
        }

        public CustomerType CustomerType  { get; set; }

    }
}
