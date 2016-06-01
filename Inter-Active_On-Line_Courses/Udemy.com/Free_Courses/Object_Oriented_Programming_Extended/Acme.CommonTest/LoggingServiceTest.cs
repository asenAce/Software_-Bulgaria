using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Acme.Common.Interfaces;
using Acme;
using ACM;
using Acme.Common;


namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public  void WriteToFileTest()
        {
            //Arrange
            var changeItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                Email = "me@bg.com",
                FirstName = "Rich",
                LastName = "Strong",
                AddressList = null
            };

            changeItems.Add(customer as ILoggable);

            var product = new Product(2)
            {
                ProductName = "Beef meat",
                ProductDescription="Scottish beef ",
                CurrentPrice = 8M
            };

            changeItems.Add(product as ILoggable);
            //Act
            LoggingServices.WriteToFile(changeItems);
            
            //Assert
            //Nothing to Assert >>

        }
    }
}
