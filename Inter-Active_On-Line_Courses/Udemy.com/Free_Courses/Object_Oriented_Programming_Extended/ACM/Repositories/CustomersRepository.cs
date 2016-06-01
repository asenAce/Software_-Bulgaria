using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM;

namespace ACM.Repositories
{
    public class CustomersRepository
    {
        public CustomersRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository  addressRepository  { get; set; }

        public Customer Retrieve(int customerID)
        {
            //Create the instance of the Customer class
            Customer customer = new Customer(customerID);

            customer.AddressList = addressRepository.RetrieveByCustomerID(customerID)
                .ToList();
                
            // to return a populate Customer;
            if (customerID == 1)
            {
                customer.Email = "me@bg.com";
                customer.FirstName = "unknown";
                customer.LastName = "strong";
            }

            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }


    }
}
