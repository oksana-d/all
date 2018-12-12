using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._3
{
    public partial class Form1 : Form
    {
        public static int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(textBox1.Text);
            new Form2().ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
