using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Buildings;

namespace Assignment1.ListManager
{
    public class CountryDictionary
    {
        Dictionary<Countries, List<Estate>> CDic;

        public CountryDictionary()
        {
            CDic = new Dictionary<Countries, List<Estate>>();
        }

        public bool Contains(Countries country)
        {
            return CDic.ContainsKey(country);
        }

        public List<Estate> Get(Countries country)
        {
            return CDic[country];
        }

        public void Add(Countries country, Estate estate)
        {
            if (CDic.ContainsKey(country))
            {
                CDic[country].Add(estate);
            }
            else
            {
                List<Estate> res = new List<Estate>();
                res.Add(estate);
                CDic.Add(country, res);
            }
        }

        public void Change(Countries country, Estate estate)
        {
            /*
            if (CDic.ContainsKey(country))
            {
                CDic.Remove(country);
                CDic.Add(country, estate);
            }
            */
        }

        public void Delete(Countries country)
        {
            CDic.Remove(country);
        }
    }
}
