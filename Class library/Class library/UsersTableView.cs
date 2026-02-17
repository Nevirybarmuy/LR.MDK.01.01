using ModelViewLib.modelViews;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_library
{
    class UsersTableView : DataGridView, UsersView
    {
        public void ShowUsers(List<User> users)
        {
            DataSource = users;
        }
        
    }
}
