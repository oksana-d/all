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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num2 = Convert.ToInt32(textBox1.Text);
            if (num2 != 0)
            {
                if (Form1.num % num2 == 0)
                {
                    label2.Text = "Первое число делится на второе";
                }
                else label2.Text = "Первое число не делится на второе";
                if (num2 % Form1.num == 0)
                {
                    label3.Text = "Второе число делится на первое";
                }
                else label3.Text = "Второе число не делится на первое";
            } else label2.Text = "Деление на 0";
        }

        private void Form2_Load(object sender, EventArgs e)
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
