﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Buildings.BuildingTypes
{
    class House : Residential
    {

        public House(int _id, int _sqrft, int _rent, Address _address, Residential.Legal _legal, string _image) : base(_id, _sqrft, _rent, _address, _legal, _image)
        {
            Category = "House";
        }

    }
}