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
            //Constructor for Commercial Estates.
            public Commercial(int id, int sqrft, int rent, Address address, Legal legal, string image) : base(id, sqrft, rent, address, legal, image)
            {
                
            }
            //Returns legal type as string.
        }
    }
