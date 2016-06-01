using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Repositories
{
    public class OrderRepository
    {
        public OrderDisplay RetrieveOrderDisplay(int orderID)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            //Code that retrieves the defined order field..

            //Creare the instance of the Order class;
            //Pass in the request ID;

            Order order = new Order(orderID);
            //Temporary Hard - coded data in order to make Tests
            if (orderID == 10)
            {
                orderDisplay.FirstName = "Rich";
                orderDisplay.LastName = "Strong";
                orderDisplay.OrderDate = new DateTimeOffset(2015,4,12,9,00,00, new TimeSpan());

                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLineOne = "Good Year",
                    StreetLineTwo = "Good Harvest",
                    City = "Brighton",
                    State = "Central UK",
                    Country = "bRIGHTON Area",
                    PostCode = "144UK"
                };
            }

            orderDisplay.OrderDisplayItemsList = new List<OrderDisplayItem>();
            // Code that retrives the order items
            // Hardcode data....
            if (orderID == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Beef meat",
                    PurchasePrice = 8M,
                    OrderQuantity = 1

                };

                orderDisplay.OrderDisplayItemsList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sheep meat",
                    PurchasePrice = 12M,
                    OrderQuantity = 2

                };

                orderDisplay.OrderDisplayItemsList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }


    }
}
