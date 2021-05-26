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
            Chain_Text("0");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            Chain_Text("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            Chain_Text("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            Chain_Text("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            Chain_Text("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            Chain_Text("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            Chain_Text("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            Chain_Text("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            Chain_Text("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            Chain_Text("9");
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Chain_Text("+");
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TextB1.Text = "";
        }

        private void Btn_Minus_Click(object sender, EventArgs e)
        {
            Chain_Text("-");
        }

        private void Btn_Percentage_Click(object sender, EventArgs e)
        {
            Chain_Text("%");
        }

        private void Btn_Multiply_Click(object sender, EventArgs e)
        {
            Chain_Text("*");
        }

        private void Btn_Divide_Click(object sender, EventArgs e)
        {
            Chain_Text("/");
        }

        private void Equals_Click(object sender, EventArgs e)
        {

        }
    }
}
