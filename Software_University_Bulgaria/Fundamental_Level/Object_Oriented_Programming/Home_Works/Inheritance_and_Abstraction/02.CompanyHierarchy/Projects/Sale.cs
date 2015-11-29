using _02.CompanyHierarchy.IContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyHierarchy.Projects
{
    class Sale : ISale
    {
        private string productName;
        private decimal price;


        public Sale(string productName,DateTime dateOfSale,decimal price)
        {

        }

        public Sale(string productName,decimal price)
            :this(productName,DateTime.Now,price)
        {

        }

        public string ProductName 
        { 
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Incorrect");
                }
                this.productName = value;
            }
        }

        public DateTime DateOfSale
        {   get;
            set; 
        }

        public decimal Price 
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Product name: {0} , sold at: {1} , on price of {2:c2} ",
                this.ProductName,
                this.DateOfSale.Date,
                this.Price);
        }

    }
}
