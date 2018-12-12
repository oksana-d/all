using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace lab3._1
{
    public partial class Form1 : Form
    {
        private static string resultstring = "";

        private void Remove1(string str)
        {
            if (resultstring.Contains("&ndash;"))
            {
                resultstring = str.Replace("&ndash;", "");
                Remove1(resultstring);
            }
        }

        private void Remove2(string str)
        {
            if (resultstring.Contains("<strong>"))
            {
                resultstring = str.Replace("<strong>", "");
                Remove2(resultstring);
            }
        }

        private void Remove3(string str)
        {
            if (resultstring.Contains("</strong>"))
            {
                resultstring = str.Replace("</strong>", "");
                Remove3(resultstring);
            }
        }

        private void Remove4(string str)
        {
            if (resultstring.Contains("&nbsp;"))
            {
                resultstring = str.Replace("&nbsp;", "");
                Remove4(resultstring);
            }
        }

        private void Remove5(string str)
        {
            if (resultstring.Contains("&raquo;"))
            {
                resultstring = str.Replace("&raquo;", "");
                Remove5(resultstring);
            }
        }

        private void Remove6(string str)
        {
            if (resultstring.Contains("&laquo;"))
            {
                resultstring = str.Replace("&laquo;", "");
                Remove6(resultstring);
            }
        }

        public Form1()
        {
            InitializeComponent();
            string url = "https://www.znu.edu.ua/cms/index.php?action=news/view&start=0&site_id=27&lang=ukr";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
            string content = sr.ReadToEnd();
            sr.Close();
            string titlePattern = @"(?<=title=)(.*)(?=><img)";
            string annotPattern = @"(?<=><p>)(.*)(?=</p></div>)";
            string result1 = "";
            string result = ""; 
            foreach (Match match in Regex.Matches(content, annotPattern))
            {
                result = result + match.Value + '\n' + '\t';
                match.NextMatch();
            }
            resultstring = result;
            Remove1(result);
            Remove2(resultstring);
            Remove3(resultstring);
            Remove4(resultstring);
            Remove5(resultstring);
            Remove6(resultstring);
            string[] array = resultstring.Split('\t');
            int i = 0;
            //foreach (Match match in Regex.Matches(content, titlePattern))
            //{
            //    result1 = '\t' + match.Value + '\n';
            //    richTextBox1.Text = richTextBox1.Text + result1 + array[i];
            //    match.NextMatch();
            //    i++;
            //}
            richTextBox1.Text = content;
        }
    }
}


