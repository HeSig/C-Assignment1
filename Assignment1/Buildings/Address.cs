using Assignment1.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Address class.
    public class Address
    {
        private string street;
        public string Street
        {
            get { return street; }
            set { street = Street; }
        }
        private int zip;
        public int Zip
        {
            get { return zip; }
            set { zip = Zip; }
        }
        private string city;
        public string City
        {
            get { return city; }
            set { city = City; }
        }
        public Countries country;

       

        //Constructor for address class.
        public Address(string _street, int _zip, string _city, Countries _country)
        {

            street = _street;
            zip = _zip;
            city = _city;
            country = _country;
        }
    }
}
