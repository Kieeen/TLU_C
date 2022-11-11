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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public string oldFileName = "";
        public int accId = 0;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewName.Text == "")
            {
                MessageBox.Show("File name must not empty");
            }
            else
            {
                try
                {
                    dbAccountDataContext db = new dbAccountDataContext();
                    var query = db.Files.Where(p => p.Filename == txtNewName.Text).Where(p => p.account_id == accId).FirstOrDefault();
                    if(query == null)
                    {
                        File f = db.Files.Where(p => p.Filename == txtOldName.Text).Where(p => p.account_id == accId).FirstOrDefault();
                        f.Filename = txtNewName.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Change file name to " + txtNewName.Text + " successful!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("File name already exits!");
                    }      
                }catch(Exception ex){
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Form9_Shown(object sender, EventArgs e)
        {
            this.txtOldName.Text = oldFileName;
            this.txtOldName.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
