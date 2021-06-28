using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float Number = 0;

        public string Operands;

        private void Chain_Text(string calc_text)
        {
            if (TextB1.Text == "")
            {
                TextB1.Text = calc_text;
            }  
            else
            {
                TextB1.Text=TextB1.Text+calc_text;
            }
        }
       
        private void button_0_Click(object sender, EventArgs e)
        {
            if (TextB1.Text == "0" || TextB1.Text == "NA")
            {
                TextB1.Text = "0";
            }
            else
            {
                Chain_Text("0");
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (TextB1.Text=="0"||TextB1.Text=="NA")
            {
                TextB1.Text = "1";
            }
            else
            {
                Chain_Text("1");
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (TextB1.Text == "0" || TextB1.Text == "NA")
            {
                TextB1.Text = "2";
            }
            else
            {
                Chain_Text("2");
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (TextB1.Text == "0" || TextB1.Text == "NA")
            {
                TextB1.Text = "3";
            }
            else
            {
                Chain_Text("3");
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (TextB1.Text == "0" || TextB1.Text == "NA")
            {
                TextB1.Text = "4";
            }
            else
            {
                Chain_Text("4");
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (TextB1.Text == "0" || TextB1.Text == "NA")
            {
                TextB1.Text = "5";
            }
            else
            {
                Chain_Text("5");
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (TextB1.Text == "0" || TextB1.Text == "NA")
            {
                TextB1.Text = "6";
            }
            else
            {
                Chain_Text("6");
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (TextB1.Text == "0" || TextB1.Text == "NA")
            {
                TextB1.Text = "7";
            }
            else
            {
                Chain_Text("7");
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (TextB1.Text == "0" || TextB1.Text == "NA")
            {
                TextB1.Text = "8";
            }
            else
            {
                Chain_Text("8");
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (TextB1.Text == "0" || TextB1.Text == "NA")
            {
                TextB1.Text = "9";
            }
            else
            {
                Chain_Text("9");
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Number = float.Parse(TextB1.Text);
            TextB1.Text="0";
            Operands = "+";
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TextB1.Text = "0";
        }

        private void Btn_Minus_Click(object sender, EventArgs e)
        {
            Number = float.Parse(TextB1.Text);
            TextB1.Text = "0";
            Operands = "-";
        }

        private void Btn_Percentage_Click(object sender, EventArgs e)
        {
            Chain_Text("%");
        }

        private void Btn_Multiply_Click(object sender, EventArgs e)
        {
            Number = float.Parse(TextB1.Text);
            TextB1.Text = "0";
            Operands = "*";
        }

        private void Btn_Divide_Click(object sender, EventArgs e)
        {
            Number = float.Parse(TextB1.Text);
            TextB1.Text = "0";
            Operands = "/";
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            if (Operands == "+")
            {
                TextB1.Text = (Number + float.Parse(TextB1.Text)).ToString();
            }
            if (Operands == "-")
            {
                TextB1.Text = (Number - float.Parse(TextB1.Text)).ToString();
            }
            if (Operands == "*")
            {
                TextB1.Text = (Number * float.Parse(TextB1.Text)).ToString();
            }
            if (Operands == "/")
            {
                if (TextB1.Text=="0")
                {
                    TextB1.Text = "NA";
                }
                else
                {
                    TextB1.Text = (Number / float.Parse(TextB1.Text)).ToString();
                }
            }
        }

        private void Btn_Decimal_Click(object sender, EventArgs e)
        {
            Chain_Text(".");
        }

        private void TextB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            if (TextB1.Text.Length==1)
            {
                TextB1.Text = "0";
            }
            else
            {
                TextB1.Text= TextB1.Text.Remove(TextB1.Text.Length -1);
            }
        }

        private void btnsqr_Click(object sender, EventArgs e)
        {
            TextB1.Text = Math.Pow(double.Parse(TextB1.Text), 2).ToString();
        }

        private void btnsqert_Click(object sender, EventArgs e)
        {
            TextB1.Text = Math.Sqrt(double.Parse(TextB1.Text)).ToString();
        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            TextB1.Text = Math.PI.ToString();
        }

        private void btncube_Click(object sender, EventArgs e)
        {
            TextB1.Text = Math.Pow(double.Parse(TextB1.Text), 3).ToString();
        }

        private void btne_Click(object sender, EventArgs e)
        {
            TextB1.Text = Math.Exp(1).ToString();
        }
    }
}
