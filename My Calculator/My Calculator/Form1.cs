using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class Form1 : Form
    {
        private int so1 = 0;
        private int so2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
                txtDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("1");
        }

        

        private void btn2_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("9");
        }
        private void AddToTextDisplay(string p)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = p;
            else
                txtDisplay.Text += p;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            so1 = int.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            so2 = int.Parse(txtDisplay.Text);
            int kq = so1 + so2;
            txtDisplay.Text = kq.ToString();
        }
    }
}
