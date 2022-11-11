using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaRo
{
    public partial class Form1 : Form
    {
        string LuotDi = "X";
        public Form1()
        {
            InitializeComponent();
            int N = 30;
            for(int i = 0; i<N; i++)
                for(int j=0; j<N; j++)
                {
                    Button b = new Button();
                    b.Location = new Point(50+j*25, 50+i*25);
                    b.Size = new Size(25, 25);
                    b.Text = "";
                    this.Controls.Add(b);
                    b.Click += b_Click;
                }
            
        }

        void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text != "")
            {
                MessageBox.Show("Làm cái trò gì đấy!");
                return;
            }
            b.Text = LuotDi;
            if (LuotDi == "X")
                LuotDi = "O";
            else
                LuotDi = "X";
        }
    }
}
