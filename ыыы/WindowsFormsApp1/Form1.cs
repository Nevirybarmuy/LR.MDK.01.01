using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            ListBox.Items.Add("in");
            ListBox.Items.Add("is");
            ListBox.Items.Add("were");
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListBox.SelectedIndex;
            MessageBox.Show(Convert.ToString(index));

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var fileContent = string.Empty;
                var filePatics = string.Empty;

                openFileDialog.InitialDirectory = "D:\\";
                openFileDialog.Filter = "image files (*.JPG)|*.JPG";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePatics = openFileDialog.FileName;
                    ListBox.Items.Add(filePatics);
                }
            }
        }
    }
}
