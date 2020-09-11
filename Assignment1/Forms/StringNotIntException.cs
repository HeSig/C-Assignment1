using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Forms
{
    class StringNotIntException : Exception
    {
        public StringNotIntException()
        {

        }

        public StringNotIntException(string message) : base(message)
        {

        }
    }
}
