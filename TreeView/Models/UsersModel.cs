using System.Collections.Generic;

namespace TreeView.Models
{
    public class UsersModel
    {
        public List<User> Users { get; }

        public UsersModel()
        {
            Users = new List<User>();

            Users.Add(new User { Name = "Иван", 
                Surname = "Иванов", 
                DateBirth = new System.DateTime(1996, 11, 1) });
        }
    }
}
