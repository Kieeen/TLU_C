using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotePad
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            LoadFileList();
        }

        private void LoadFileList()
        {
            dbAccountDataContext db = new dbAccountDataContext();
            var query = from b in db.Files.Where(p => p.account_id == idAcc)
                        select new
                        {
                            b.Filename
                        };
            dtgFileList.DataSource = query;
        }

        public int idAcc = 0;
        public string pass;
        public bool checkOpen = false;
        public bool checkSave = false;
        public string text = "";
        public string name = "";
        private string test = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(idAcc.ToString());
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != "")
                {
                    try
                    {
                        dbAccountDataContext db = new dbAccountDataContext();   
                        var query = db.Files.Where(w => w.Filename == Path.GetFileName(ofd.FileName)).Where(p => p.account_id == idAcc).FirstOrDefault();
                        if (query == null)
                        {
                            File f = new File();
                            f.Filename = Path.GetFileName(ofd.FileName);
                            f.account_id = idAcc;
                            if (f.Filename[f.Filename.Length - 1] == 'P')
                            {
                                Form2 f2 = new Form2();
                                f2.ShowDialog();
                                pass = f2.GetPass;
                                if (pass == "")
                                    return;
                                else
                                {
                                    //MessageBox.Show(pass);
                                    f.Data = ReadAllBytes(ofd.FileName);
                                } 
                            }
                            else
                            {
                                f.Data = CovertToBytes(ofd.FileName);
                            }
                            db.Files.InsertOnSubmit(f);
                            db.SubmitChanges();
                            MessageBox.Show("Add file successful");
                        }
                        else
                        {
                            savePrompt();
                            if (DialogResult == DialogResult.Yes)
                            {
                                db.Files.DeleteOnSubmit(query);
                                db.SubmitChanges();
                                File f = new File();
                                f.Filename = Path.GetFileName(ofd.FileName);
                                f.account_id = idAcc;
                                if (f.Filename[f.Filename.Length - 1] == 'P')
                                {
                                    Form2 f2 = new Form2();
                                    f2.ShowDialog();
                                    pass = f2.GetPass;
                                    if (pass == "")
                                        return;
                                    else
                                    {
                                        f.Data = ReadAllBytes(ofd.FileName);
                                    }
                                }
                                else
                                {
                                    f.Data = CovertToBytes(ofd.FileName);
                                }
                                db.Files.InsertOnSubmit(f);
                                db.SubmitChanges();
                                MessageBox.Show("Add file successful");
                            }
                            else if (DialogResult == DialogResult.No)
                                return;             
                        }
                        LoadFileList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private byte[] CovertToBytes(string fileName)
        {
            string content = "";
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string l = sr.ReadLine();
                content += l + "\r\n";
            }
            byte[] contents = Encoding.ASCII.GetBytes(content);
            return contents;
        }

        private void savePrompt()
        {
            DialogResult = MessageBox.Show("File already exits. Do you want to replace it?",
                "NotePad",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }

        private void savePrompt1()
        {
            DialogResult = MessageBox.Show("This file is not saved!. Do you want to continue?",
                "NotePad",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string[] partName = name.Split(new char[] { ' ' });
            //MessageBox.Show(partName[1]);
            //MessageBox.Show(fileName);
            if(partName.Length >= 2 && partName[1] == "*")
            {
                savePrompt1();
                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string fileName = dtgFileList.CurrentRow.Cells[0].Value.ToString();
                        dbAccountDataContext db = new dbAccountDataContext();
                        var query = db.Files.Where(w => w.Filename == fileName).Where(p => p.account_id == idAcc).FirstOrDefault();
                        byte[] data = query.Data.ToArray();
                        if(fileName[fileName.Length - 1] == 'P')
                        {
                            Form2 f2 = new Form2();
                            f2.ShowDialog();
                            this.pass = f2.GetPass;
                            if (pass == "")
                                return;
                            else
                            {
                                text = Encoding.Default.GetString(decryptData(data));
                            }
                        }
                        else
                        {
                            text = System.Text.Encoding.Default.GetString(data);
                        }
                        name = fileName;
                        checkOpen = true;
                        checkSave = true;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (DialogResult == DialogResult.No)
                    return;
            }
            else
            {
                try
                {
                    string fileName = dtgFileList.CurrentRow.Cells[0].Value.ToString();
                    dbAccountDataContext db = new dbAccountDataContext();
                    var query = db.Files.Where(w => w.Filename == fileName).Where(p => p.account_id == idAcc).FirstOrDefault();
                    byte[] data = query.Data.ToArray();
                    if (fileName[fileName.Length - 1] == 'P')
                    {
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                        pass = f2.GetPass;
                        if (pass == "")
                            return;
                        else
                        {
                            text = Encoding.Default.GetString(decryptData(data));
                        }
                    }
                    else
                    {
                        text = System.Text.Encoding.Default.GetString(data);
                    }
                    name = fileName;
                    checkOpen = true;
                    checkSave = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dbAccountDataContext db = new dbAccountDataContext();
                string fileName = dtgFileList.CurrentRow.Cells[0].Value.ToString();
                var query = db.Files.Where(w => w.Filename == fileName).Where(p => p.account_id == idAcc).FirstOrDefault();
                db.Files.DeleteOnSubmit(query);
                db.SubmitChanges();
                LoadFileList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] partName = name.Split(new char[] {' '});
            string[] fileName = partName[0].Split(new char[] { '*' });
            Form8 f8 = new Form8();
            f8.fileName = fileName[0];
            f8.idAcc = idAcc;
            f8.pass = pass;
            f8.text = text;
            f8.ShowDialog();
            checkSave = f8.check;
            if (checkSave == true)
            {
                name = f8.fileName;
            }
            LoadFileList();
            //MessageBox.Show(fileName[0]);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbAccountDataContext db = new dbAccountDataContext();
            var query = from b in db.Files.Where(p => p.Filename.Contains(txtSearch.Text)).Where(p => p.account_id == idAcc)
                        select new
                        {
                            b.Filename
                        };
            dtgFileList.DataSource = query;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeFileName_Click(object sender, EventArgs e)
        {
            string oldFileName = dtgFileList.CurrentRow.Cells[0].Value.ToString();
            Form9 f9 = new Form9();
            f9.oldFileName = oldFileName;
            f9.accId = idAcc;
            f9.ShowDialog();
            LoadFileList();
        }



        private byte[] encryptData(byte[] data)
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

            byte[] textData = data;
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

        private byte[] decryptData(byte[] data)
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

            byte[] Content = data;
            byte[] passwordTmp = Encoding.ASCII.GetBytes(pass);
            byte[] keys = new byte[Content.Length];
            for (int i = 0; i < Content.Length; i++)
                keys[i] = passwordTmp[i % passwordTmp.Length];

            byte[] result = new byte[Content.Length];
            for (int i = 0; i < Content.Length; i++)
            {
                byte value = Content[i];
                byte key = keys[i];
                int valueIndex = -1, keyIndex = -1;
                for (int j = 0; j < 256; j++)
                    if (abc[j] == key)
                    {
                        keyIndex = j;
                        break;
                    }
                for (int j = 0; j < 256; j++)
                    if (table[keyIndex, j] == value)
                    {
                        valueIndex = j;
                        break;
                    }
                result[i] = abc[valueIndex];
            }
            return result;
        }

        private byte[] ReadAllBytes(string fileName)
        {
            byte[] buffer = null;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
            }
            return buffer;
        }

        private void Form7_Shown(object sender, EventArgs e)
        {
            LoadFileList();
        }
    }
}
