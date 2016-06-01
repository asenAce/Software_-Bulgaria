using Acme.Common;
using Acme.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Product:EntityBase,ILoggable
    {

        public Product()
        {

        }

        public Product(int productID)
        {
            this.ProductID = productID;
        }

        public int ProductID { get; private set; }
        public Decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        //public string ProductName { get; set; }
        //propfull  assign the proparty with the get and set ;
        private String _ProductName;

        public String ProductName
        {
            get 
            {
                // var stringHandler = new StringHandler();
                //return StringHandler.InsertSpaces(_ProductName); 
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }
        


        public Product Retrive(int productID)
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if (CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logString = this.ProductID + ": " +
                            this.ProductName + " " +
                            "Detail: " + this.ProductDescription + " " +
                            "Status: " + this.EntityState.ToString();


            return logString;
        }

    }
}
