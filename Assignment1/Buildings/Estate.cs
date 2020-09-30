using Assignment1.Buildings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment1
{
    [Serializable]
    [XmlRoot("Estate")]
    //Abstract class for all Estates. 
    public class Estate : IEstate
    {
        [XmlElement("Estate Id")]
        public int Id { get; /*private*/ set; }

        [XmlElement("Address")]
        public Address Address { get; /*private*/ set; }

        [XmlElement("Square feet")]
        public int Sqrft { get; /*private*/ set; }

        [XmlElement("Rent")]
        public int Rent { get; /*private*/ set; }

        // Category. A value which can be used by other methods to distinguish between Residential and Commercial estates.
        [DisplayName("Category")]
        public string Category { get; /*protected*/ set; }

        // Legal type. Residential replaces this with its own legal types.
        public enum Legal
        {
            Ownership,
            Rental,
            Tenement,
        }

        //Returns the legal type as a string.
        public string GetLegalType()
        {
            switch (LegalType)
            {
                case Legal.Ownership:
                    return "Ownership";
                case Legal.Rental:
                    return "Rental";
                case Legal.Tenement:
                    return "Tenement";
            }
            return "No info.";
        }

        public Legal LegalType { get; /*protected*/ set; }
        // Estate type. Residential and Commercial estates have different types, which is why they are defined there.

        public string Image { get; /*private*/ set; }
        public void SetAddress(Address address)
        {
            try
            {
                Address = address;
            } catch (SpecialCharException)
            {
                throw new SpecialCharException();
            }
            
        }
        public void SetLegal(Legal legal)
        {
            LegalType = legal;
        }

        public Estate(int id, int sqrft, int rent, Address address, Legal legal, string image)
        {
            Init(id, sqrft, rent, address, legal, image);
        }

        public Estate()
        {

        }

        public void Init(int id, int sqrft, int rent, Address address, Legal legal, string image)
        {
            Id = id;
            try
            {
                Address = address;
            } catch (SpecialCharException specialCharException)
            {
                throw specialCharException;
            }
            LegalType = legal;
            Sqrft = sqrft;
            Rent = rent;
            Image = image;
        }

        public virtual string GetEstateType()
        {
            return Category;
        }
    }

}
