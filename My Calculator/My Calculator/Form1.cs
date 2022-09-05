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
   
    public partial class MyCalculator : Form
    {
        private int so1 = 0;
                int so2 = 0;
        public MyCalculator()
        {
            InitializeComponent();
        }

        private void nut0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                txtDisplay.Text = "0";
            }
           
        }

        private void AddToTextDisplay(string p)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = p;
            }
            else
            {
                txtDisplay.Text += p;
            }
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void nut1_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("1");
        }

        private void nut2_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("2");
        }
        private void nut3_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("3");
        }

        private void nut4_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("4");
        }

        private void nut5_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("5");
        }

        private void nut6_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("6");
        }

        private void nut7_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("7");
        }

        private void nut8_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("8");
        }

        private void nut9_Click(object sender, EventArgs e)
        {
            AddToTextDisplay("9");
        }

        private void nutC_Click(object sender, EventArgs e)
        {
            so1 = int.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
        }

        private void NutOk_Click(object sender, EventArgs e)
        {
            so2 = int.Parse(txtDisplay.Text);
            int kq = so1 + so2;
            txtDisplay.Text = kq.ToString();
        }

        private void NutCl_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void NutCham_Click(object sender, EventArgs e)
        {
            AddToTextDisplay(".");
        }

      
    }
}
