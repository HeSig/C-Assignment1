using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.ListManager
{
    public class EstateManager : ListManager<Estate>
    {
        public void DeleteEstate(Estate estate)
        {
            for(int i = 0; i < Count; i++)
            {
                if(GetAt(i) == estate)
                {
                    DeleteAt(i);
                }
            }
        }
    }


}
