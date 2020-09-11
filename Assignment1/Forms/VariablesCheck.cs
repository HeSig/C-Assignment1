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
        public static int AddNewId(String _id, Estate _selectedEstate, Estate[] _estates)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(_id, "[^0-9]"))
            {
                throw new StringNotIntException();
            }

            int ID = Int32.Parse(_id);

            if (_selectedEstate.Id == ID)
            {
                return ID;
            }


            for (int i = 0; i < _estates.Length; i++)
            {
                if (_estates.ElementAt(i).Id == ID)
                {

                    throw new DuplicateIDException("ID cannot be a duplicate");
                }
            }
            return ID;
        }
    }
}
