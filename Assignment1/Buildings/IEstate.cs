using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Buildings
{
    //Base interface for estates. Contains variables which all Estates have: Id, Address, Square feet, Rent and Category (Residential OR Commercial).
    interface IEstate
    {
        int Id { get; }
        Address Address { get; }
        int Sqrft { get; }
        int Rent { get; }

        //Residential or Commercial
        string Category { get; }
    }
}
