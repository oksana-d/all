using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
        }

        private StringBuilder Shuffle(StringBuilder str)
        {
            Random rnd = new Random();
            int len = str.Length;
            char c;
            for(int i = len - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i);
                c = str[i];
                str[i] = str[j];
                str[j] = c;
            }
            return str;
        }

        private bool Test(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if(!Char.IsDigit(str[i]))
                {
                    MessageBox.Show("Количество символов пароля должно быть целым положительным числом. Пример: 4, 10, 17, 66." ,"Error");
                    return false;
                }
            }

            if (Convert.ToInt32(str) < 4)
            {
                MessageBox.Show("Пароль не может быть короче 4 символов.", "Error");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Test(textBox1.Text) == true)
            {
                int num = Convert.ToInt32(textBox1.Text);
                string s = "qwertyuiopasdfghjklzxcvbnm";
                string S = "QWERTYUIOPASDFGHJKLZXCVBNM";
                string p = "_";
                string z = "0123456789";
                string password = "";

                Random rnd = new Random();
                password += s[rnd.Next(s.Length)];
                password += S[rnd.Next(S.Length)];
                password += p[rnd.Next(p.Length)];
                password += z[rnd.Next(z.Length)];

                for (int i = 0; i < num - 4; i++)
                {

                    switch (rnd.Next(3))
                    {
                        case 0:
                            password += s[rnd.Next(s.Length)];
                            break;
                        case 1:
                            password += S[rnd.Next(S.Length)];
                            break;
                        case 2:
                            password += z[rnd.Next(z.Length)];
                            break;
                    }
                }

                StringBuilder pas = new StringBuilder(password);
                pas = Shuffle(pas);
                password = pas.ToString();
                label2.Text = "Ваш пароль:";
                label3.Text = password;
            }
        }

    }
}
