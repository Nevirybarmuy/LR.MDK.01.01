using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextComponent
{
    public partial class Form1: Form
    {
        int RandomNumber_;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            RandomNumber_ = rnd.Next(1, 101);
        }

        private void Proverka_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(NumberXX.Text);
            if (Number > RandomNumber_)
            {
                MessageBox.Show("Загаданное число меньше ");
            }
            if (Number < RandomNumber_)
            {
                MessageBox.Show("Загаданное число больше");
            }
            if (Number == RandomNumber_)
            {
                MessageBox.Show("Угадали? ");
            }
        }
    }
}