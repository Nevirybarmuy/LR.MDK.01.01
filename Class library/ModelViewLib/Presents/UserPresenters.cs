using ModelViewLib.Models;
using ModelViewLib.modelViews;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Presents
{
    public class UserPresent
    {
        private IUsersModel model_;
        private IUsersView view_;

        public UserPresent(IUsersModel model, IUsersView view)
        {
            model_ = model;
            view_ = view;
            List<User> usersModel = model_.UpUserData();
            view_.ShowUsers(usersModel);
        }
        
    }
}
