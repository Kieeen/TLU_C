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
    public partial class Form4 : Form
    {
        public EditOperation editOperation;
        FindNextSearch qry = new FindNextSearch();
        public RichTextBox Editor = new RichTextBox();
        public FindNextSearch Qry { get { return qry; } set { qry = value; } }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DisableButtons();
            rBtnDown.Checked = true;
        }

        private void DisableButtons()
        {
            if (txtFind.Text.Length == 0)
            {
                btnFindNext.Enabled = btnReplace.Enabled = btnReplaceAll.Enabled = false;
            }
            else
            {
                btnFindNext.Enabled = btnReplace.Enabled = btnReplaceAll.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateSearchQuery()
        {
            qry.SearchString = txtFind.Text;
            qry.Direction = rBtnUp.Checked ? "UP" : "DOWN";
            qry.MatchCase = chkMatchCase.Checked;
            qry.Content = Editor.Text;
            qry.Position = Editor.SelectionStart;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            DisableButtons();
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            UpdateSearchQuery();
            FindNextResult result = editOperation.FindNext(this.qry);
            if (result.SearchStatus)
                this.Editor.Select(result.SelectionStart, txtFind.Text.Length);
            else
                MessageBox.Show("Couldn't find " + "\"" + txtFind.Text + "\"");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (Editor.SelectionLength == 0)
                btnFindNext.PerformClick();
            Editor.SelectedText = txtReplace.Text;
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            Editor.Text = Editor.Text.Replace(txtFind.Text, txtReplace.Text);
        }





       

    }
}
