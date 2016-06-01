using Acme.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Order : EntityBase,ILoggable
    {

        public Order()
        {

        }

        public Order(int orderID)
        {
            this.OrderID = orderID;
        }


        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; private set; }
        public List<OrderItem> orderItems { get; set; }

        //the Customer
        public int CustomerID { get; set; }
        public int ShippingAddress { get; set; }


        public Order Retrieve(int orderID)
        {
            Order order = new Order();

            return order;
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;

        }

        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderID + ") ";
        }


        public string Log()
        {
            var logString = this.OrderID + ": " +
                            "Date: " + this.OrderDate.Value.Date + " " +
                            "Status: " + this.EntityState.ToString();

            return logString;
        }
    }
}
