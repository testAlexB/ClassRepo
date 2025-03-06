using System;
using System.Collections.Generic;

namespace TreeView
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateBirth { get; set; }

        public static Dictionary<string, string> Aliases = new Dictionary<string, string>()
        {
            { nameof(Name), "Имя"},
            { nameof(Surname), "Фамилия"},
            {nameof(DateBirth), "Дата рождения" }
        };
    }
}
