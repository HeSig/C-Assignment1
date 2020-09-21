using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.ListManager;

namespace Assignment1.Forms
{
    public class VariablesCheck
    {
        //ID's are unique properties. This method checks if a new ID already exists, throws a custom exception and informs the user of the issue without stopping the program.
        public static int AddNewId(String _id, Estate _selectedEstate, EstateManager _estates)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(_id, "[^0-9]"))
            {
                throw new StringNotIntException();
            }

            int ID = Int32.Parse(_id);

            if(_selectedEstate != null) { 
                if (_selectedEstate.Id == ID)
                {
                    return ID;
                }
            }

            for (int i = 0; i < _estates.Count; i++)
            {
                if (_estates.GetAt(i).Id == ID)
                {

                    throw new DuplicateIDException("ID cannot be a duplicate");
                }
            }
            return ID;
        }

        internal static int CheckIfNumberFieldHasLetters(String _v)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(_v, "[^0-9]"))
            {
                throw new StringNotIntException();
            }
            return Int32.Parse(_v);
        }
    }
}
