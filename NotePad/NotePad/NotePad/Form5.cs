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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public bool check = false;
        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text!= "" && txtPassword.Text != "")
            {
                try
                {
                    dbAccountDataContext db = new dbAccountDataContext();
                    Account acc = new Account();

                    var query = db.Accounts.Where(w => w.Username == this.txtUsername.Text).FirstOrDefault();
                    if (query != null)
                    {
                        MessageBox.Show("Username exits");
                    }
                    else
                    {
                        acc.Username = txtUsername.Text;
                        acc.Password = txtPassword.Text;

                        db.Accounts.InsertOnSubmit(acc);
                        db.SubmitChanges();

                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        check = true;
                        MessageBox.Show("Sign in successful!");
                        this.Close();
                    }
                   
                }
                catch(Exception ex)
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

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
