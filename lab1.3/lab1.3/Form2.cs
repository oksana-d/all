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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int i = 1, k = 0;
            string d = "";
            label1.Text = Convert.ToString(Form1.num);

            while (i <= Form1.num)
            {
                if (Form1.num % i == 0)
                {
                    d += Convert.ToString(i) + " ";
                    k++;
                }
                i++;
            }

            label3.Text = Convert.ToString(k);
            label2.Text = d;
        }
    }
}
