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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public int idAcc = 0;
        public bool check = false;
        public string Username = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    dbAccountDataContext db = new dbAccountDataContext();
                    var query = db.Accounts.Where(w => w.Username == this.txtUsername.Text).FirstOrDefault();
                    if (query == null)
                    {
                        MessageBox.Show("Username not correct");
                    }
                    else if (query.Password != this.txtPassword.Text)
                    {
                        MessageBox.Show("Password not correct");
                    }
                    else
                    {
                        MessageBox.Show("Login succefull");
                        this.check = true;
                        this.Username = query.Username;
                        this.idAcc = query.Id;
                        this.Close();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                      
            }
            else
            {
                MessageBox.Show("Username and password must not empty");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
