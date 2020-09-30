using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.ListManager
{
    public class EstateManager : ListManager<Estate>
    {
        CountryDictionary cd;
        public EstateManager(): base()
        {
            cd = new CountryDictionary();
        }

        public void DeleteEstate(Estate estate)
        {
            for(int i = 0; i < Count; i++)
            {
                if(GetAt(i) == estate)
                {
                    DeleteAt(i);
                }
            }
            cd.Remove(estate);
        }

        new public void ChangeAt(Estate estate, int selectedEstate)
        {
            Estate res = base.GetAt(selectedEstate);
            base.ChangeAt(estate, selectedEstate);
            cd.Replace(res, estate);
        }

        new public bool Add(Estate aType)
        {
            base.Add(aType);

            cd.Add(aType);
            return true;
        }

        public CountryDictionary GetCountryDictionary()
        {
            return cd;
        }

    }
}
