using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Image_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.ShowDialog();
            if (f.FileName != "")
            {
                picLeft.SizeMode = PictureBoxSizeMode.StretchImage ;
                picLeft.ImageLocation = f.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
