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

namespace MyNotepad
{
    public partial class Form1 : Form
    {
        string fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdFont_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowDialog();
            txtMain.Font = f.Font;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                SaveFileDialog f = new SaveFileDialog();
                DialogResult r = f.ShowDialog();
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = f.FileName;
                    this.Text = fileName;
                    SaveToFile(fileName);
                }
            }
        }

        private void SaveToFile(string fileName)
        {
            StreamWriter s = new StreamWriter(fileName);
            s.Write(txtMain.Text);
            s.Close();
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            if (fileName != "")
            {
                DialogResult r = MessageBox.Show("Bạn có muốn lưu file hiện tại không?", "Lưu ý", MessageBoxButtons.YesNoCancel);
                
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveToFile(fileName);                    
                }
                else if (r == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }
            OpenFileDialog f = new OpenFileDialog();
            DialogResult r1 = f.ShowDialog();
            if (r1 == System.Windows.Forms.DialogResult.OK)
            {
                fileName = f.FileName;
                this.Text = fileName;
                ReadFromFile(fileName);
            }
        }

        private void ReadFromFile(string fileName)
        {
            StreamReader s = new StreamReader(fileName);
            txtMain.Text = "";
            while (!s.EndOfStream)
                txtMain.Text += s.ReadLine() + "\r\n";
            s.Close();
        }
    }
}
