using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleMVP.Models
{
    public class ConcreteStringModel : IStringModel
    {

        private List<string> _data = new List<string>();

        public List<string> GetData()
        {
            return _data;
        }

        public void LoadData()
        {
            _data.Add("string_2");
            _data.Add("string_1");

            SuccessLoadedData.Invoke();
        }

        public void SortData(bool sortingOrder)
        {
            if(sortingOrder)
            {
                _data.Sort(SortByNameAscending);
            }
            else
            {
                _data.Sort(SortByNameDescending);
            }

            SuccessLoadedData.Invoke();
        }

        private int SortByNameAscending(string name1, string name2)
        {
            return name1.CompareTo(name2);
        }

        private int SortByNameDescending(string name1, string name2)
        {
            return SortByNameAscending(name1, name2) * -1;
        }

        public event Action SuccessLoadedData;
    }
}
