using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using Assignment1.Buildings;
using System;

namespace UnitTestAssignment1
{
    [TestClass]
    public class UnitTestAdress
    {

        [TestMethod]

        //tests valid street address in the class address
        //PASSES
        public void TestValidStreetAddressString()
        {
            //arrange
            string _streetAddress = "Storgatan 22";
            int _zipcode = 24334;
            string _city = "Malmö";
            Countries _country = Countries.Sverige;

            string expected = "Storgatan 22";
            string actual = "";
            Address address;

            //act
            address = new Address(_streetAddress, _zipcode, _city, _country);
            actual = address.Street;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //assert
        [ExpectedException(typeof(SpecialCharException))]
        //tests invalid form of street address in the class address
        //PASSES
        public void TestInvalidStreetAddressString()
        {
            //arrange
            string _streetAddress = "St*rgatan 2?2";
            int _zipcode = 24334;
            string _city = "Malmö";
            Countries _country = Countries.Sverige;

            string expected = "";
            Address address = null;
            
            //act
            address = new Address(_streetAddress, _zipcode, _city, _country);

        }

        
         [TestMethod]
         //tests the valid form for city in the class address
        public void TestValidCityString()
        {
            //arrange
            string _streetAddress = "Storgatan 22";
            int _zipcode = 24334;
            string _city = "Malmo";
            Countries _country = Countries.Sverige;

            string expected = "Malmo";
            string actual = "";
            Address address;

            //act
            address = new Address(_streetAddress, _zipcode, _city, _country);
            actual = address.City;

            //assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        [ExpectedException(typeof(SpecialCharException), "invalid string in class adress")]
        //tests the invalid form for city in the class address
        public void TestInvalidCityString()
        {
            //arrange
            string _streetAddress = "Storgatan 22";
            int _zipcode = 24334;
            string _city = "Malm4&ö";
            Countries _country = Countries.Sverige;

            string expected = "";
            Address address = null;

            //act
            address = new Address(_streetAddress, _zipcode, _city, _country);
        } 
    }
}
