using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Base interface for estates. Contains variables which all Estates have: Id, Address, Square feet, Rent and Category (Residential OR Commercial).
    interface IEstate
    {
        int Id { get; }
        Address Address { get;}
        int Sqrft { get; }
        int Rent { get; }

        //Residential or Commercial
        string Category { get; }
    }
    //Abstract class for all Estates. 
    abstract class Estate : IEstate
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
            Address = address;
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

    //Address class.
    class Address
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

        public enum Countries
        {
            Afghanistan,
            Algeria,
            Andorra,
            Angola,
            Antigua_and_Barbuda,
            Argentina,
            Armenia,
            Australia,
            Austria,
            Azerbaijan,
            Bahamas,
            Bahrain,
            Bangladesh,
            Barbados,
            Belarus,
            Belgium,
            Belize,
            Benin,
            Bhutan,
            Bolivia,
            Bosnia_and_Herzegovina,
            Botswana,
            Brazil,
            Brunei,
            Bulgaria,
            Burkina_Faso,
            Burundi,
            Cambodia,
            Cameroon,
            Canada,
            Cape_Verde,
            Central_African_Republic,
            Chad,
            Chile,
            China,
            Colombia,
            Comoros,
            Congo,
            Democratic_Republic_of_the_Congo,
            Costa_Rica,
            Côte_d_Ivoire,
            Croatia,
            Cuba,
            Cyprus,
            Czech_Republic,
            Denmark,
            Djibouti,
            Dominica,
            Dominican_Republic,
            East_Timor_or_Timur,
            Ecuador,
            Egypt,
            El_Salvador,
            Equatorial_Guinea,
            Eritrea,
            Estonia,
            Ethiopia,
            Fiji,
            Finland,
            France,
            Gabon,
            Gambia,
            Georgia,
            Germany,
            Ghana,
            Greece,
            Grenada,
            Guatemala,
            Guinea,
            Guinea_Bissau,
            Guyana,
            Haiti,
            Honduras,
            Hungary,
            Iceland,
            India,
            Indonesia,
            Iran,
            Iraq,
            Ireland,
            Israel,
            Italy,
            Jamaica,
            Japan,
            Jordan,
            Kazakhstan,
            Kenya,
            Kiribati,
            Korea_North,
            Korea_South,
            Kuwait,
            Kyrgyzstan,
            Laos,
            Latvia,
            Lebanon,
            Lesotho,
            Liberia,
            Libya,
            Liechtenstein,
            Lithuania,
            Luxembourg,
            Macedonia,
            Madagascar,
            Malawi,
            Malaysia,
            Maldives,
            Mali,
            Malta,
            Marshall_Islands,
            Mauritania,
            Mauritius,
            Mexico,
            Micronesia_Federated_States_of,
            Moldova,
            Monaco,
            Mongolia,
            Morocco,
            Mozambique,
            Myanmar,
            Namibia,
            Nauru,
            Nepal,
            Netherlands,
            New_Zealand,
            Nicaragua,
            Niger,
            Nigeria,
            Norway,
            Oman,
            Pakistan,
            Palau,
            Panama,
            Papua_New_Guinea,
            Paraguay,
            Peru,
            Philippines,
            Poland,
            Portugal,
            Qatar,
            Romania,
            Russia,
            Rwanda,
            Saint_Kitts_and_Nevis,
            Saint_Lucia,
            Saint_Vincent_and_The_Grenadines,
            Samoa,
            San_Marino,
            Sao_Tome_and_Principe,
            Saudi_Arabia,
            Senegal,
            Serbia_and_Montenegro,
            Seychelles,
            Sierra_Leone,
            Singapore,
            Slovakia,
            Slovenia,
            Solomon_Islands,
            Somalia,
            South_Africa,
            Spain,
            Sri_Lanka,
            Sudan,
            Suriname,
            Swaziland,
            Sverige,
            Switzerland,
            Syria,
            Taiwan,
            Tajikistan,
            Tanzania,
            Thailand,
            Togo,
            Tonga,
            Trinidad_and_Tobago,
            Tunisia,
            Turkey,
            Turkmenistan,
            Tuvalu,
            Uganda,
            Ukraine,
            United_Arab_Emirates,
            United_Kingdom,
            United_States_of_America,
            Uruguay,
            Uzbekistan,
            Vanuatu,
            Vatican_City,
            Venezuela,
            Vietnam,
            Western_Sahara,
            Yemen,
            Zambia,
            Zimbabwe
        }

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
