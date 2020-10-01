using Assignment1.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    //Address class.
    public class Address
    {
        /*
        [DataMember]
        private string street;
        public string Street
        {
            get { return street; }
            set { street = Street; }
        }
        [DataMember]
        private int zip;
        public int Zip
        {
            get { return zip; }
            set { zip = Zip; }
        }
        [DataMember]
        private string city;

        public string City
        {
            get { return city; }
            set { city = City; }
        }
        */

        //Find a way to make set to private.
        [DataMember]
        public string Street
        {
            get; set;
        }
        [DataMember]
        public int Zip
        {
            get; set;
        }
        [DataMember]
        public string City
        {
            get; set;
        }

        public Countries country;


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


        //empty construct for seralize
        public Address()
        {

        }

        //Constructor for address class.
        public Address(string _street, int _zip, string _city, Countries _country)
        {
            if (checkValidStreetString(_street))
            {
                Street = _street;
            } else
            {
                throw new SpecialCharException(_street);
            }

            if (checkValidCityString(_city))
            {
                City = _city;
            } else
            {
                throw new SpecialCharException(_city);
            }

            Zip = _zip;
            country = _country;
        }
       
    }
}
