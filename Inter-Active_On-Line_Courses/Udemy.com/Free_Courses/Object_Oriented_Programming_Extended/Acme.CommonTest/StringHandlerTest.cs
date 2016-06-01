using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void TestTheStringHandler()
        {

            //Arrange
            //Hard coded
            var source = "MashinenPistol";
            var expected = "Mashinen Pistol";

            // var handler = new StringHandler();
            //Act
            // var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();
            
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {

            //Arrange
            //Hard coded
            var source = "MashinenPistol";
            var expected = "Mashinen Pistol";

            // var handler = new StringHandler();
            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
