using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string GetPass
        {
            get { return txtPass.Text; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != "")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter your password","NotePad");
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPass.Text != "")
                {
                    this.Close();
                }
            }
        }
    }
}
