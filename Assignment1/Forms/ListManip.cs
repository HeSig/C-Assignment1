using Assignment1.ListManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Forms
{
    public class ListManip
    {
        //Get Estate instance by its ID;
        public static Estate GetEstateByID(int _ID, EstateManager _Estates)
        {
            for (int i = 0; i < _Estates.Count; i++)
            {
                if (_Estates.GetAt(i).Id == _ID)
                {
                    return _Estates.GetAt(i);
                }
            }
            return null;
        }

        //Get the Estates position within the Estate List by its ID
        public static int GetEstateSearchListPositionByEstateID(int _ID, EstateManager _Estates)
        {
            for (int i = 0; i < _Estates.Count; i++)
            {
                if (_Estates.GetAt(i).Id == _ID)
                {
                    return i;
                }
            }
            return -1;
        }

        //Get the ID of an estate from the value of the selected item within the Estate display list
        public static int GetEstateIdFromEstateSearchList(String _s)
        {
            string res = "";
            for (int i = 0; i < _s.Length; i++)
            {
                if (_s.ElementAt(i) != ' ')
                {
                    res += _s.ElementAt(i);
                }
                else
                {
                    break;
                }
            }

            return Int32.Parse(res);
        }

        //Get the Estate object from the index of the Estate Display List.
        public static Estate GetEstateFromList(int _listIndex, String[] _EstateListItems, EstateManager _Estates)
        {
            string estateListItem = "";
            if (_listIndex < 0)
            {
                return null;
            }
            else
            {
                estateListItem = _EstateListItems[_listIndex];
            }
            return GetEstateByID(GetEstateIdFromEstateSearchList(estateListItem), _Estates);
        }
    }
}
