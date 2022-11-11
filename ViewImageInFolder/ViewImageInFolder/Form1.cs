using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewImageInFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSlectFolder_Click(object sender, EventArgs e)
        {
            /*PictureBox pic1 = new PictureBox();
            pic1.ImageLocation = "C:\\Users\\sv\\Pictures\\AnhDep\\duongtrencao.jpg";
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.Size = new Size(300, 200);
            this.panImages.Panel2.Controls.Add(pic1);


            PictureBox pic2 = new PictureBox();
            pic2.Location = new Point(310, 000);
            pic2.ImageLocation = "C:\\Users\\sv\\Pictures\\AnhDep\\chuatranquoc.jpg";
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.Size = new Size(300, 200);
            this.panImages.Panel2.Controls.Add(pic2);*/
            FolderBrowserDialog f = new FolderBrowserDialog();
            //f.ShowDialog();
            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(f.SelectedPath))
            {
                string[] files = Directory.GetFiles(f.SelectedPath);
                int i = 0;
                foreach (var s in files)
                {
                    int h = i / 3;
                    int c = i % 3;


                    PictureBox pic = new PictureBox();
                    pic.ImageLocation = s;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Size = new Size(300, 300);

                    pic.Location = new Point(50+c*300 + c*50, 50+h*300 + h*50);

                    this.panImages.Panel2.Controls.Add(pic);
                    i++;
                }
                //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }

        }
    }
}
