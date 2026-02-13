using ModelViewLib.modelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
    public class MemoryUsersModel : IUsersModel
    {
        List<User> users = new List<User>();
        public MemoryUsersModel()
        {
          users.Add(new User { Login = "abc", Password = "123", Name = "Vasiliy"});
            users.Add(new User { Login = "fgh", Password = "234", Name = "LubaKoza" });
            users.Add(new User { Login = "Kyrilshik", Password = "567", Name = "TemaSportik" });
        }
        public bool Register(User user)
        {
            int CountLength = users.Count;
            users.Add(user);
            return CountLength < users.Count();
        }
        public List<User> UpUserData()
        {
            return users;
        }
    }

}
