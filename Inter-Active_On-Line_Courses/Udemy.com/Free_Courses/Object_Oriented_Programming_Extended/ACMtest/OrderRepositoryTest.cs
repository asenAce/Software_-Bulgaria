using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM;
using ACM.Repositories;
using System.Collections.Generic;

namespace ACMtest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetriveOrderDisplayTest()
        {
            //Arrange
            var orderRepository = new OrderRepository();

            var expected = new OrderDisplay()
            {
                FirstName = "Rich",
                LastName = "Strong",
                OrderDate = new DateTimeOffset(2015,4,12,9,00,00, new TimeSpan(7,0,0)),

                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLineOne = "Good Year",
                    StreetLineTwo = "Good Harvest",
                    City = "Brighton",
                    State = "Central UK",
                    Country = "bRIGHTON Area",
                    PostCode = "144UK"
                },

                OrderDisplayItemsList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Beef meat",
                        PurchasePrice = 8M,
                        OrderQuantity = 1

                    },

                    new OrderDisplayItem()
                    {
                        ProductName = "Sheep meat",
                        PurchasePrice = 12M,
                        OrderQuantity = 2

                    }
                }
            };
            //Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            //Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType,actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLineOne, actual.ShippingAddress.StreetLineOne);
            Assert.AreEqual(expected.ShippingAddress.StreetLineTwo,actual.ShippingAddress.StreetLineTwo);
            Assert.AreEqual(expected.ShippingAddress.City,actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State,actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.Country,actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostCode,actual.ShippingAddress.PostCode);

            for (int i = 0; i < 1; i++)
			{
			    Assert.AreEqual(expected.OrderDisplayItemsList[i].OrderQuantity
                    ,actual.OrderDisplayItemsList[i].OrderQuantity);
                Assert.AreEqual(expected.OrderDisplayItemsList[i].ProductName
                    ,actual.OrderDisplayItemsList[i].ProductName);
                Assert.AreEqual(expected.OrderDisplayItemsList[i].PurchasePrice
                    ,actual.OrderDisplayItemsList[i].PurchasePrice);


			}
        }

        
    }
}
