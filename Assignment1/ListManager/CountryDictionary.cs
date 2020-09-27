using System.Collections.Generic;
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

        public void Add(Estate estate)
        {
            if (CDic.ContainsKey(estate.Address.country))
            {
                CDic[estate.Address.country].Add(estate);
            }
            else
            {
                List<Estate> res = new List<Estate>();
                res.Add(estate);
                CDic.Add(estate.Address.country, res);
            }
        }

        public void Change(Countries country, List<Estate> estates)
        {
            CDic.Remove(country);
            CDic.Add(country, estates);
        }

        public void Remove(Estate estate)
        {
            CDic[estate.Address.country].Remove(estate);
        }

        public void Replace(Estate changeFrom, Estate changeTo)
        {
            if(changeFrom.Address.country == changeTo.Address.country)
            {
                List<Estate> res = CDic[changeFrom.Address.country];
                for(int i = 0; i < res.Count; i++)
                {
                    if(res[i] == changeFrom)
                    {
                        res[i] = changeTo;
                        break;
                    }
                }
            }
            else
            {
                Remove(changeFrom);
                Add(changeTo);
            }
        }

        public void Delete(Countries country)
        {
            CDic.Remove(country);
        }
    }
}