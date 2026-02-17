using ModelViewLib.modelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Views
{
    public interface UsersView
    {
        void ShowUsers(List<User> users);
    }
}
