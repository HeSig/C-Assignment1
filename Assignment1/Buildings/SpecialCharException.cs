using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Buildings
{
    [Serializable]
    public class SpecialCharException : Exception
    {

        string exception;
        public SpecialCharException()
        {

        }

        public SpecialCharException(string _string) : base(_string) { }

    }
}
