using System;
using System.Collections.Generic;

namespace SimpleMVP.Models
{
    public interface IStringModel
    {
        void LoadData();
        List<string> GetData();

        event Action SuccessLoadedData;
    }
}
