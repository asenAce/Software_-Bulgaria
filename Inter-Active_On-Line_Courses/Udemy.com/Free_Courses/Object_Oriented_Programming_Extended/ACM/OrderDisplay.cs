using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class OrderDisplay
    {

        // prop >>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset?  OrderDate { get; set; }
        // OrderDisplay is OrderDisplayIteams
        public List<OrderDisplayItem> OrderDisplayItemsList { get; set; }
        public int OrderID { get; set; }
        public Address ShippingAddress { get; set; }


    }
}
