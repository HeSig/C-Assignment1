using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Residential subclass of Estate
    class Residential : Estate
    {
        //Replaces Estate legal types with unique Residential ones.
        public new enum Legal
        {
            Ownership,
            Rental,
            Tenement
        }
        //Replaces Estate building types with unique Residential ones.
        public new enum EstateType
        {
            House,
            Villa,
            Apartment,
            Rowhouse,
        }

        public new Legal LegalType { get; private set; }
        public new EstateType BuildingType { get; private set; }

        //Constructor for Residential estates.
        public Residential(int id, int sqrft, int rent, Address address, Residential.Legal legal, EstateType type, string image) : base(id, sqrft, rent, address, image)
        {
            Category = "Residential";
            LegalType = legal;
            BuildingType = type;
        }

        //Returns the legal type as a string.
        public override string GetLegalType()
        {
            switch ((Residential.Legal)LegalType)
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

        //Returnt the Residential types as a string.
        public override string GetEstateType()
        {
            switch ((Residential.EstateType)BuildingType)
            {
                case EstateType.House:
                    return "House";
                case EstateType.Villa:
                    return "Villa";
                case EstateType.Apartment:
                    return "Apartment";
                case EstateType.Rowhouse:
                    return "Row house";
            }
            return "No info";
        }

    }
}
