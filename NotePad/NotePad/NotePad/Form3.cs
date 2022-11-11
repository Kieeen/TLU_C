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
    public partial class Form3 : Form
    {
        
        Form1 form1;
        EditOperation editOperation;
        FindNextSearch qry = new FindNextSearch();
        public RichTextBox Editor = new RichTextBox();
        public FindNextSearch Qry { get { return qry; } set { qry = value; } }

        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            rBtnDown.Checked = true;
            btnFindNext.Enabled = false;
            editOperation = form1.EditOperation;
            qry.Success = false;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            btnFindNext.Enabled = (txtFind.Text.Length > 0) ? true : false;
            UpdateSearchQuery();
        }

        public void UpdateSearchQuery()
        {
            qry.SearchString = txtFind.Text;
            qry.Direction = rBtnUp.Checked ? "UP" : "DOWN";
            qry.MatchCase = chkMatchCase.Checked;
            qry.Content = Editor.Text;
            qry.Position = Editor.SelectionStart;
        }

        private void chkMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchQuery();
        }

        private void rBtnUp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchQuery();
        }

        private void rBtnDown_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchQuery();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            UpdateSearchQuery();
            FindNextResult result = editOperation.FindNext(qry);
            if (result.SearchStatus)
                Editor.Select(result.SelectionStart, txtFind.Text.Length);
            else
                MessageBox.Show("Couldn't find " + "\"" + txtFind.Text + "\"");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
