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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public string fileName = "";
        public int idAcc = 0;
        public string text = "";
        public bool check = false;
        public string pass = "";

        private void Form8_Shown(object sender, EventArgs e)
        {
            if(fileName == "Untitled")
            {
                this.txtFileName.Text = fileName + ".txt";
            }
            else
            {
                this.txtFileName.Text = fileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtFileName.Text != "")
            {
                try
                {
                    dbAccountDataContext db = new dbAccountDataContext();
                    var query = db.Files.Where(w => w.Filename == this.txtFileName.Text).Where(p => p.account_id == idAcc).FirstOrDefault();
                    if (query == null)
                    {
                        File f = new File();
                        f.Filename = this.txtFileName.Text;
                        f.account_id = idAcc;
                        if (f.Filename[f.Filename.Length - 1] == 'P' && pass !="")
                        {
                            f.Data = encryptData(text);
                        }
                        else
                        {
                            f.Data = Encoding.ASCII.GetBytes(text);
                        }
                        db.Files.InsertOnSubmit(f);
                        db.SubmitChanges();
                        MessageBox.Show("Save file to account successful");
                        fileName = this.txtFileName.Text;
                        check = true;
                        this.Close();
                    }
                    else
                    {
                        savePrompt();
                        if (DialogResult == DialogResult.Yes)
                        {
                            db.Files.DeleteOnSubmit(query);
                            db.SubmitChanges();
                            File f = new File();
                            f.Filename = this.txtFileName.Text;
                            f.account_id = idAcc;
                            if (f.Filename[f.Filename.Length - 1] == 'P' && pass != "")
                            {
                                f.Data = encryptData(text);
                            }
                            else
                            {
                                f.Data = Encoding.ASCII.GetBytes(text);
                            }
                            db.Files.InsertOnSubmit(f);
                            db.SubmitChanges();
                            MessageBox.Show("Save file to account successful");
                            fileName = this.txtFileName.Text;
                            check = true;
                            this.Close();
                            
                        }
                        else if (DialogResult == DialogResult.No)
                            return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("File name must not empty");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savePrompt()
        {
            DialogResult = MessageBox.Show("File already exits. Do you want to replace it?",
                "NotePad",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }

        private byte[] encryptData(string data)
        {
            byte[] abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            byte[,] table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }

            byte[] textData = Encoding.ASCII.GetBytes(data);
            byte[] passwordTmp = Encoding.ASCII.GetBytes(pass);
            byte[] keys = new byte[textData.Length];
            for (int i = 0; i < textData.Length; i++)
                keys[i] = passwordTmp[i % passwordTmp.Length];


            byte[] result = new byte[textData.Length];
            for (int i = 0; i < textData.Length; i++)
            {
                byte value = textData[i];
                byte key = keys[i];
                int valueIndex = -1, keyIndex = -1;
                for (int j = 0; j < 256; j++)
                    if (abc[j] == value)
                    {
                        valueIndex = j;
                        break;
                    }
                for (int j = 0; j < 256; j++)
                    if (abc[j] == key)
                    {
                        keyIndex = j;
                        break;
                    }
                result[i] = table[keyIndex, valueIndex];
            }
            return result;
        }


    }
}
