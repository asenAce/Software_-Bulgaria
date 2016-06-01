using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM;
using ACM.Repositories;
using System.Collections.Generic;

namespace ACMtest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveExiting()
        {
            //Arrange
            var customerRepository = new CustomersRepository();
            var expected = new Customer(1)
            {
                Email = "me@bg.com",
                FirstName = "unknown",
                LastName = "strong"
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            //Assert.AreEqual(expected,actual);
            Assert.AreEqual(expected.CustomerID,actual.CustomerID);
            Assert.AreEqual(expected.Email,actual.Email);
            Assert.AreEqual(expected.FirstName,actual.FirstName);
            Assert.AreEqual(expected.LastName,actual.LastName);

        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //Arrange
            var customerRepository = new CustomersRepository();
            var expected = new Customer(1)
            {
                Email = "me@bg.com",
                FirstName = "strong",
                LastName = "unknow",

                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLineOne = "Good Year",
                        StreetLineTwo = "Good Harvest",
                        City = "Brigton",
                        State = "Shine",
                        Country = "Central UK",
                        PostCode = "144HU"
                    },

                    new Address()
                    {
                        AddressType = 2,
                        StreetLineOne = "Good Year 2",
                        StreetLineTwo = "Good Harvest 2",
                        City = "London",
                        State = "London",
                        Country = "Central UK 2",
                        PostCode = "144HU 2"
                    }
                }
            };


            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerID,actual.CustomerID);
            Assert.AreEqual(expected.Email,actual.Email);
            Assert.AreEqual(expected.FirstName,actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType,actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLineOne,actual.AddressList[i].StreetLineOne);
                Assert.AreEqual(expected.AddressList[i].City,actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State,actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country,actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].PostCode,actual.AddressList[i].PostCode);

            }

        }

         



    }
}
