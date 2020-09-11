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
        public static Estate GetEstateByID(int ID, Estate[] Estates)
        {
            for (int i = 0; i < Estates.Length; i++)
            {
                if (Estates[i].Id == ID)
                {
                    return Estates[i];
                }
            }
            return null;
        }

        //Get the Estates position within the Estate List by its ID
        public static int GetEstateSearchListPositionByEstateID(int ID, Estate[] Estates)
        {
            for (int i = 0; i < Estates.Length; i++)
            {
                if (Estates[i].Id == ID)
                {
                    return i;
                }
            }
            return -1;
        }

        //Get the ID of an estate from the value of the selected item within the Estate display list
        public static int GetEstateIdFromEstateSearchList(String s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s.ElementAt(i) != ' ')
                {
                    res += s.ElementAt(i);
                }
                else
                {
                    break;
                }
            }

            return Int32.Parse(res);
        }

        //Get the Estate object from the index of the Estate Display List.
        public static Estate GetEstateFromList(int listIndex, String[] EstateListItems, Estate[] Estates)
        {
            return GetEstateByID(GetEstateIdFromEstateSearchList(EstateListItems[listIndex]), Estates);
        }
    }
}
