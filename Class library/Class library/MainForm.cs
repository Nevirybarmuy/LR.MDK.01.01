using ModelViewLib.Models;
using ModelViewLib.modelViews;
using ModelViewLib.Presents;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UsersTableView tableView = new UsersTableView();
            Controls.Add(tableView);
            tableView.Dock = DockStyle.Top;
            UserPresent user = new UserPresent(new MemoryUsersModel(), tableView);
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить человека?", MessageBoxButtons.YesNo, MessageBoxIcon.Question = DialogResult.Yes)
        {
                List<User> selectedUsers = UsersView.GetSelectedUsers();
                presenter_RemoveUsers(selectedUsers);
            }
        }
    }
}
