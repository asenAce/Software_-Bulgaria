using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM;

namespace ACMtest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FuulNameTestValid()
        {
            
            #region Arrange 

            Customer customer = new Customer();
            customer.FirstName = "bilbo";
            customer.LastName = "strong";

            string expected = "strong,bilbo";
            #endregion Arrange

            #region Act
            string actual = customer.FullName;

            #endregion Act
            #region Assert

            Assert.AreEqual(expected,actual);
            #endregion Assert
        }
        [TestMethod]
        public void FirstNameEmpty()
        {
            Customer customer = new Customer();

            customer.LastName = " strong";
            string expected = " strong";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }
         
        [TestMethod]
        public void LastNameEmpty()
        {
            Customer customer = new Customer();

            customer.FirstName = "bilbo";
            string expected = "bilbo";

            string actual = "bilbo";

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var varOne = new Customer();
            varOne.FirstName = "bilbo";
            Customer.InstanceCount += 1;

            var varTwo = new Customer();
            varTwo.FirstName = "strong";
            Customer.InstanceCount += 1;

            var varThree = new Customer();
            varThree.FirstName = "Rosse";
            Customer.InstanceCount += 1;
            //Act

            //Assert
            Assert.AreEqual(3,Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer();

            customer.LastName = "strong";
            customer.Email = "me@bg.com";

            var expected = true;
            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer();
            customer.Email = "me@bg.com";
            //Act
            var expected = false;
            var actual = customer.Validate();
            //Assert
            Assert.AreEqual(expected,actual);

        }


    }
}
