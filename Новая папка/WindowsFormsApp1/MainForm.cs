using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FileNameListBox.Items.Add("in");
            FileNameListBox.Items.Add("is");
            FileNameListBox.Items.Add("were");
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = FileNameListBox.SelectedIndex;
            MessageBox.Show(Convert.ToString(index));
        }

        private void LoadBut_Click(object sender, EventArgs e)
        {

        }
    }
}
