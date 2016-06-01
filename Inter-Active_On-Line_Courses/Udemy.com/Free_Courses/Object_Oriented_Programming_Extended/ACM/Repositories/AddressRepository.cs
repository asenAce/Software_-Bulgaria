using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Repositories
{
    public class AddressRepository
    {

        public Address Retrieve(int addressID)
        {
            Address address = new Address(addressID);

            if (addressID == 1)
            {
                address.StreetLineOne = "Good Year";
                address.StreetLineTwo = "Good Harvest.";
                address.City = "Brighton";
                address.Country = "Central UK";
                address.PostCode = "144BH";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLineOne = "Good Year",
                StreetLineTwo = "Good Harvest",
                City = "Brigton",
                State = "Shine",
                Country = "Central UK",
                PostCode = "144HU"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLineOne = "Good Year 2",
                StreetLineTwo = "Good Harvest 2",
                City = "London",
                State = "London",
                Country = "Central UK 2",
                PostCode = "144HU 2"
            };

            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }

    }
}
