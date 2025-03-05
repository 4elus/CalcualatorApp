using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcualatorApp
{
    public partial class Form1 : Form
    {
        int num1 = 0;
        int num2 = 0;
        string operation = "";
        string value = "";
        int res = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxеTablo_KeyPress(object sender, KeyPressEventArgs e)
        {

           

            if (value.Contains('.'))
            {
                e.Handled = true;
            }

            if  (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            value += e.KeyChar;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length == 1 && textBoxеTablo.Text == "0")
            {
                textBoxеTablo.Text = "0";
            }
            else
            {
                textBoxеTablo.Text += "0";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length == 1 && textBoxеTablo.Text == "0")
            {
                textBoxеTablo.Text = "1";
            }
            else
            {
                textBoxеTablo.Text += "1";
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length == 1 && textBoxеTablo.Text == "0")
            {
                textBoxеTablo.Text = "2";
            }
            else
            {
                textBoxеTablo.Text += "2";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length == 1 && textBoxеTablo.Text == "0")
            {
                textBoxеTablo.Text = "3";
            }
            else
            {
                textBoxеTablo.Text += "3";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length == 1 && textBoxеTablo.Text == "0")
            {
                textBoxеTablo.Text = "6";
            }
            else
            {
                textBoxеTablo.Text += "6";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length == 1 && textBoxеTablo.Text == "0")
            {
                textBoxеTablo.Text = "5";
            }
            else
            {
                textBoxеTablo.Text += "5";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length == 1 && textBoxеTablo.Text == "0")
            {
                textBoxеTablo.Text = "4";
            }
            else
            {
                textBoxеTablo.Text += "4";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length == 1 && textBoxеTablo.Text == "0")
            {
                textBoxеTablo.Text = "7";
            }
            else
            {
                textBoxеTablo.Text += "7";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length == 1 && textBoxеTablo.Text == "0")
            {
                textBoxеTablo.Text = "8";
            }
            else
            {
                textBoxеTablo.Text += "8";
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length == 1 && textBoxеTablo.Text == "0")
            {
                textBoxеTablo.Text = "9";
            }
            else
            {
                textBoxеTablo.Text += "9";
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!textBoxеTablo.Text.Contains(".")) // ! - не. Contains = проверяет есть ли в текстовом поле символ "."
            {
                textBoxеTablo.Text += ".";
            }

           

 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length > 0)
            {
                string val = textBoxеTablo.Text;


                textBoxеTablo.Text = "";
                for (int i = 0; i < val.Length-1; i++)
                {
                   
                    textBoxеTablo.Text += val[i].ToString();
                }

               // textBoxеTablo.Text = textBoxеTablo.Text.Replace(textBoxеTablo.Text.Last().ToString(), ""); // Replace заменят старый символ, на новый указанный 
                if (textBoxеTablo.Text.Length == 0)
                    textBoxеTablo.Text = "0";
            }
            else
                textBoxеTablo.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = Convert.ToInt32(textBoxеTablo.Text);
            textBoxеTablo.Text = "";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (num2 == 0)
            {
                num2 = Convert.ToInt32(textBoxеTablo.Text);
            }
          
            if (operation == "+")
            {
                res += num1 + num2;
                num1 = 0;
            }

            if (operation == "-")
            {
                res += num1 - num2;
                num1 = 0;
            }

            textBoxеTablo.Text = res.ToString();
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = Convert.ToInt32(textBoxеTablo.Text);
            textBoxеTablo.Text = "";
        }
    }
}
