using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                if (a % 2 == 0)
                {

                    label2.Text = "Введенное число: чётное";
                }
                else if (a % 2 == 1)
                {
                    label2.Text = "Введенное число: нечётное";
                }

                if (textBox1.Text == "0")
                {
                    label2.Text = "Введенное число: равно нулю";
                }
            }
            catch 
            {
                MessageBox.Show("Введите число");
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
