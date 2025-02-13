﻿using System;
using System.Collections.Generic;

namespace SimpleMVP.Views
{
    public interface IStringView
    {
        void Show(List<string> data);

        event Action<bool> SortingEvent;
    }
}
