using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._1
{
    public partial class Form1 : Form
    {
        public static int age;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(DateTime.Now.Year);
            age = Convert.ToInt32(textBox1.Text);
            if (checkBox1.Checked == true) {
                age = year - age + 100;
            }
            else
            {
                age = year - age + 99;
            }
            new Form2().ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
