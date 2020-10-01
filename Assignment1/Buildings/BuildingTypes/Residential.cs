using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Residential subclass of Estate
    [Serializable]
    public abstract class Residential : Estate
    {
        public Residential()
        {

        }
        //Constructor for Residential estates.
        public Residential(int id, int sqrft, int rent, Address address, Legal legal, string image) : base(id, sqrft, rent, address, legal, image)
        {
            LegalType = legal;
        }

    }
}
