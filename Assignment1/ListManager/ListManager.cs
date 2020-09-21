using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.ListManager
{
    public class ListManager<T> : IListManager<T>
    {
        readonly List<T> m_list;
        public int Count { get {return m_list.Count();}}

        public ListManager()
        {
            m_list = new List<T>();
        }

        public bool Add(T aType)
        {
            m_list.Add(aType);
            return true;
        }

        public bool BinaryDeSerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool BinarySerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool ChangeAt(T aType, int anIndex)
        {
            m_list[anIndex] = aType;
            return true;
        }

        public bool CheckIndex(int index)
        {
            if(index >= 0 && index < Count)
            {
                return true;
            }
            else { return false; }
        }

        public void DeleteAll()
        {
            m_list.Clear();
        }

        public bool DeleteAt(int anIndex)
        {
            m_list.RemoveAt(anIndex);
            return true;
        }

        public T GetAt(int anIndex)
        {
            return m_list[anIndex];
        }

        //Change this to return information we care about
        public string[] ToStringArray()
        {
            String[] res = new string[m_list.Count];

            for(int i = 0; i < m_list.Count; i++)
            {
                res[i] = m_list[i].ToString();
            }
            return res;
        }

        //Change this to return information we care about
        public List<string> ToStringList()
        {
            List<string> res = new List<string>();

            for (int i = 0; i < m_list.Count; i++)
            {
                res[i] = m_list[i].ToString();
            }
            return res;
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
