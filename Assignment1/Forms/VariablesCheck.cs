using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Forms
{
    public class VariablesCheck
    {
        //ID's are unique properties. This method checks if a new ID already exists, throws a custom exception and informs the user of the issue without stopping the program.
        public static int AddNewId(int id, Estate selectedEstate, Estate[] estates)
        {
            if (selectedEstate.Id == id)
            {
                return id;
            }
            for (int i = 0; i < estates.Length; i++)
            {
                if (estates.ElementAt(i).Id == id)
                {

                    throw new DuplicateIDException("ID cannot be a duplicate");
                }
            }
            return id;
        }
    }
}
