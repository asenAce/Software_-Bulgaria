using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressID)
        {
            this.AddressID = addressID;
        }

        public int AddressID { get; set; }
        public int AddressType { get; set; }
        public string StreetLineOne { get; set; }
        public string StreetLineTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

    }
}
