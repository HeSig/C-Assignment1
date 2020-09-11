using Assignment1.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    
    //Abstract class for all Estates. 
    public class Estate : IEstate
    {
        public int Id { get; private set; }
        public Address Address { get; private set; }

        public int Sqrft { get; private set; }
        public int Rent { get; private set; }

        // Category. A value which can be used by other methods to distinguish between Residential and Commercial estates.
        public string Category { get; protected set; }

        // Legal type. Residential replaces this with its own legal types.
        public enum Legal
        {
            Ownership,
            Rental,
        }

        public Legal LegalType { get; protected set; }
        // Estate type. Residential and Commercial estates have different types, which is why they are defined there.
        public enum EstateType { };
        public EstateType BuildingType { get; protected set; }

        public void SetAddress(Address address)
        {
            try
            {
                Address = address;
            } catch (SpecialCharException e)
            {
                //TODO wtd ?
            }
            
        }
        public void SetLegal(Legal legal)
        {
            LegalType = legal;
        }

        public Estate(int id, int sqrft, int rent, Address address, string image)
        {
            Init(id, sqrft, rent, address, image);
        }

        public Estate()
        {

        }

        public void Init(int id, int sqrft, int rent, Address address, string image)
        {
            if(Category == null) { 
                Category = "Commercial";
            }
            Id = id;
            Address = address;
            Sqrft = sqrft;
            Rent = rent;
        }

        public virtual string GetLegalType()
        {
            return "";
        }

        public virtual string GetEstateType()
        {
            return "";
        }
    }

}
