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
        double num1 = 0;
        double num2 = 0;
        string operation = "";
        string value = "";
        double res = 0;
        bool click_math_operation = false;

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

            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if (textBoxеTablo.Text.Length > 0)
            {
                e.Handled = false;
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
            if (!textBoxеTablo.Text.Contains(",")) // ! - не. Contains = проверяет есть ли в текстовом поле символ "."
            {
                textBoxеTablo.Text += ",";
            }




        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length > 0)
            {
                string val = textBoxеTablo.Text;


                textBoxеTablo.Text = "";
                for (int i = 0; i < val.Length - 1; i++)
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
            click_math_operation = true;
            num1 = Convert.ToDouble(textBoxеTablo.Text);
            textBoxеTablo.Text = "";


        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (click_math_operation == false)
            {
                num1 = Convert.ToDouble(textBoxеTablo.Text);
            }
            else
            {
                num2 = Convert.ToDouble(textBoxеTablo.Text);
            }


            switch (operation)
            {
                case "+":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        res = num1 / num2;
                    else
                        MessageBox.Show("Деление на ноль невозможно!");
                    break;
            }

            textBoxеTablo.Text = res.ToString();
            click_math_operation = false;

            //num1 = res;
            //num2 = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operation = "-";
            click_math_operation = true;
            num1 = Convert.ToDouble(textBoxеTablo.Text);
            textBoxеTablo.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operation = "*";
            click_math_operation = true;
            num1 = Convert.ToDouble(textBoxеTablo.Text);
            textBoxеTablo.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operation = "/";
            click_math_operation = true;
            num1 = Convert.ToDouble(textBoxеTablo.Text);
            textBoxеTablo.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxеTablo.Text = "";
            num1 = 0;
            num2 = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBoxеTablo.Text.Length > 0)
            {
                string val = textBoxеTablo.Text;
                int i = 0;

                if (val.Contains('-'))
                {
                    val = "";
                    val += textBoxеTablo.Text;
                    i = 1;

                }
                else
                {
                    val = "-";
                    val += textBoxеTablo.Text;
                    i = 0;
                }

                textBoxеTablo.Text = "";
                for (; i < val.Length; i++)
                {

                    textBoxеTablo.Text += val[i].ToString();
                }
            }
        }


    }
}
