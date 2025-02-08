using System;
using System.Collections.Generic;

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
            _data.Add("string_1");
            _data.Add("string_2");

            SuccessLoadedData.Invoke();
        }

        public event Action SuccessLoadedData;
    }
}
