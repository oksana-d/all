using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._2
{
    public partial class Form1 : Form
    {
        public static int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           num = Convert.ToInt32(textBox1.Text);
            if(num % 2 == 0)
            {
                label2.Text="Число является четным";
            } 
            else label2.Text = "Число не является четным";
            if (num % 4 == 0)
            {
                label3.Text = "Число делится на 4";
            }
            else label3.Text = "Число не делится на 4";
            new Form2().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
        }
    }
}
