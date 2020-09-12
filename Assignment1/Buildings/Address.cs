using Assignment1.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //set { street = Street; }
        }
        private int zip;
        public int Zip
        {
            get { return zip; }
            set { zip = Zip; }
        }
        private string city;

        //checks so that street addresses doesn't contain any spec char
        internal static bool checkValidStreetString(string _string)
        {
            Boolean result;
        
            var regexItem = new Regex("^[a-öA-Ö0-9 ]*$");

            if (regexItem.IsMatch(_string))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        //checks so that the cities doesn't contain spec chars or numbers
        internal static bool checkValidCityString(string _string)
        {
            Boolean result;

            var regexItem = new Regex("^[a-öA-Ö ]*$");

            if (regexItem.IsMatch(_string))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }



        public string City
        {
            get { return city; }
            //set { city = City; }
        }
        public Countries country;

       

        //Constructor for address class.
        public Address(string _street, int _zip, string _city, Countries _country)
        {
            if (checkValidStreetString(_street))
            {
                street = _street;
            } else
            {
                throw new SpecialCharException(_street);
            }

            if (checkValidCityString(_city))
            {
                city = _city;
            } else
            {
                throw new SpecialCharException(_city);
            }

            zip = _zip;
            country = _country;
        }
       
    }
}
