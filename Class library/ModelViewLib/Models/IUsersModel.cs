using ModelViewLib.modelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
    public interface IUsersModel
    {
        List<User> UpUserData();
        bool Register(User user);

    }
}
