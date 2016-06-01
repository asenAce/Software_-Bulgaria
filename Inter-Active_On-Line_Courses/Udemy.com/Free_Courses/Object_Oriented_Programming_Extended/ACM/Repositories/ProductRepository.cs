using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Repositories
{
    public class ProductRepository
    {

        public Product Retrieve(int productID)
        {
            //Create the instance of the Product class pass in the request ID
            Product product = new Product(productID);

            //Code that retrive the defined product
            // a populate product
            if (productID == 2)
            {
                product.ProductName = "SunFlowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 15.95M;
            }

            return product;

        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    //Call an Insert Stored Procedure ...
                }

                else
                {
                    //Call an UpDate Stored Procedure...
                }
            }

            return success;
        }

        

    }
}
