using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Commercial subclass of Estate.
    class Commercial : Estate
        {
            //Unique Residential building types.
            public new enum EstateType
            {
                Shop,
                Warehouse
            }

            new EstateType BuildingType;

            //Constructor for Commercial Estates.
            public Commercial(int id, int sqrft, int rent, Address address, Legal legal, EstateType type, string image) : base(id, sqrft, rent, address, image)
            {
                LegalType = legal;
                BuildingType = type;
            }
            //Returns legal type as string.
            public override string GetLegalType()
            {
                switch ((Legal)LegalType)
                {
                    case Legal.Ownership:
                        return "Ownership";
                    case Legal.Rental:
                        return "Rental";
                }
                return "No info.";
            }
            //Returns Estate type as string.
            public override string GetEstateType()
            {
                switch ((Commercial.EstateType)BuildingType)
                {
                    case EstateType.Shop:
                        return "Shop";
                    case EstateType.Warehouse:
                        return "Warehouse";
                }
                return "No info";
            }
        }
    }
