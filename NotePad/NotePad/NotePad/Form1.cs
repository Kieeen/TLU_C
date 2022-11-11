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
using System.Speech.Synthesis;

namespace NotePad
{
    public partial class Form1 : Form
    {
        EditOperation editOperation;
        Form3 form3;
        Form4 form4;
        public EditOperation EditOperation { get { return editOperation; } set { editOperation = value; } }

        public Form1()
        {
            InitializeComponent();
            editOperation = new EditOperation();
            this.txtMain.HideSelection = false;

        }

        private int idAcc = 0;
        private string oldFileNameInAcc = "";
        private bool checkLogin = false;
        private bool checkSignin = false;
        private bool checkOpenToAcc = true;
        private bool checkSaveToAcc = false;
        public string accName = "";
        private string path ="";
        private string pass = "";
        private string tail = " - NotePad";
        private int countSizeChange = 0;
        private OpenFileDialog ofd;
        private SaveFileDialog sfd;
        private FontDialog fd;
        private ColorDialog cd;
        private bool checkSave()
        {
            if(!this.txtMain.Modified)
                return true;
            return false;
        }

        private bool checkPass()
        {
            if (pass != "")
                return true;
            return false;
        }

        private void newFile()
        {
            pass = "";
            checkSaveToAcc = false;
            checkOpenToAcc = false;
            this.txtMain.Text = string.Empty;
            path = string.Empty;
            this.Text = "Untitled" + tail;
        }

        private void newWindow()
        {
            //pass = "";
            //checkSaveToAcc = false;
            //checkOpenToAcc = false;
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void saveFile()
        {
            if(checkSaveToAcc == true)
            {
                string[] partName = this.Text.Split(new char[] { ' ' });
                string[] fileName = partName[0].Split(new char[] { '*' });
                if (fileName[0] == "Untitled")
                {
                    fileName[0] = "Untitled.txt";
                }
                try
                {
                    dbAccountDataContext db = new dbAccountDataContext();
                    //if(oldFileNameInAcc == fileName[0])
                    //{
                        //var query = db.Files.Where(w => w.Filename == fileName[0]).Where(p => p.account_id == idAcc).FirstOrDefault();
                        //db.Files.DeleteOnSubmit(query);
                        //db.SubmitChanges();
                        File f = db.Files.Where(w => w.Filename == fileName[0]).Where(p => p.account_id == idAcc).FirstOrDefault();
                        //f.Filename = fileName[0];
                        //f.account_id = idAcc;
                        if (f.Filename[f.Filename.Length - 1] == 'P' && pass != "")
                        {
                            f.Data = encryptData(this.txtMain.Text);
                        }
                        else
                        {
                            f.Data = Encoding.ASCII.GetBytes(this.txtMain.Text);
                        }
                        //db.Files.InsertOnSubmit(f);
                        db.SubmitChanges();

                    //}
                    //else if(oldFileNameInAcc != fileName[0])
                    //{
                    //    var query = db.Files.Where(w => w.Filename == oldFileNameInAcc).Where(p => p.account_id == idAcc).FirstOrDefault();
                    //    db.Files.DeleteOnSubmit(query);
                    //    db.SubmitChanges();
                    //    File f = new File();
                    //    f.Filename = fileName[0];
                    //    f.account_id = idAcc;
                    //    if (f.Filename[f.Filename.Length - 1] == 'P' && pass != "")
                    //    {
                    //        f.Data = encryptData(this.txtMain.Text);
                    //    }
                    //    else
                    //    {
                    //        f.Data = Encoding.ASCII.GetBytes(this.txtMain.Text);
                    //    }
                    //    db.Files.InsertOnSubmit(f);
                    //    db.SubmitChanges();

                    //    oldFileNameInAcc = fileName[0];
                    //}
                    //if (!string.IsNullOrEmpty(path))
                    //{
                    //    if (fileName[0][fileName[0].Length -1] == 'P')
                    //    {
                    //        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                    //        fs.Write(encryptData(txtMain.Text), 0, encryptData(txtMain.Text).Length);
                    //        fs.Close();
                    //        this.Text = Path.GetFileName(path) + tail;
                    //        this.txtMain.Modified = false;
                    //    }
                    //    else
                    //    {
                    //        StreamWriter sw = new StreamWriter(path);
                    //        sw.Write(txtMain.Text);
                    //        sw.Close();
                    //    }
                    //}
                    this.Text = fileName[0] + tail;
                    this.txtMain.Modified = false;
                    MessageBox.Show("Save file to account successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (string.IsNullOrEmpty(path))
            {
                sfd = new SaveFileDialog();
                sfd.FileName = "Untitled";
                sfd.Filter = "Text Documents (*.txt)|*.txt|PDF file (*.pdf)|*.pdf |Word File (*.doc)|*.doc|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK) {
                    if (sfd.FileName != "")
                    {
                        path = sfd.FileName;
                        StreamWriter sw = new StreamWriter(sfd.FileName);
                        sw.Write(txtMain.Text);
                        sw.Close();
                        this.Text = Path.GetFileName(path) + tail;
                        this.txtMain.Modified = false;
                    }
                }
                
            }
            else
            {
                string[] partName = this.Text.Split(new char[] { ' ' });
                string[] fileName = partName[0].Split(new char[] { '.' });
                if (fileName[1] == "P")
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                    fs.Write(encryptData(txtMain.Text), 0, encryptData(txtMain.Text).Length);
                    fs.Close();
                    this.Text = Path.GetFileName(path) + tail;
                    this.txtMain.Modified = false;
                }
                else
                {
                    StreamWriter sw = new StreamWriter(path);
                    sw.Write(txtMain.Text);
                    sw.Close();
                    this.Text = Path.GetFileName(path) + tail;
                    this.txtMain.Modified = false;
                }
            }
            
        }

        private void openFile()
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Text Documents (*.txt)|*.txt|Text Documents With Password (*.P)|*.P|PDF file (*.pdf)|*.pdf |Word File (*.doc)|*.doc|All files (*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //txtMain.Text = "";
                pass = "";
                checkSaveToAcc = false;
                checkOpenToAcc = false;
                if (ofd.FileName != "")
                {
                    path = ofd.FileName;
                    string fileName = Path.GetFileName(path);
                    string[] partName = fileName.Split(new char[] { '.' });
                    //MessageBox.Show(partName[partName.Length - 1]);
                    if (partName[partName.Length - 1] == "P")
                    {
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                        pass = f2.GetPass;
                        if (pass == "")
                            return;
                        else
                        {
                            string fileContent = Encoding.Default.GetString(decryptData(path));
                            txtMain.Text = fileContent;
                            this.Text = Path.GetFileName(path) + tail;
                        }
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(ofd.FileName);
                        while (!sr.EndOfStream)
                        {
                            string l = sr.ReadLine();
                            txtMain.Text += l + "\r\n";
                        }
                        sr.Close();
                        this.Text = Path.GetFileName(path) + tail;
                    }
                }
            }
            
        }

        private void savePrompt()
        {
            DialogResult = MessageBox.Show("Do you want to save current file?",
                "NotePad",
                MessageBoxButtons.YesNoCancel,
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

        private byte[] decryptData(string pathFile)
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

            byte[] fileContent = ReadAllBytes(pathFile);
            byte[] passwordTmp = Encoding.ASCII.GetBytes(pass);
            byte[] keys = new byte[fileContent.Length];
            for (int i = 0; i < fileContent.Length; i++)
                keys[i] = passwordTmp[i % passwordTmp.Length];

            byte[] result = new byte[fileContent.Length];
            for (int i = 0; i < fileContent.Length; i++)
            {
                byte value = fileContent[i];
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

        private void txtMain_TextChanged(object sender, EventArgs e)
        {
            if (this.txtMain.Modified && !string.IsNullOrEmpty(path))
                this.Text = Path.GetFileName(path) + " *" + tail;
            else if (this.txtMain.Modified && string.IsNullOrEmpty(path) && checkOpenToAcc == false)
                this.Text = "Untitled *" + tail;
            else if (this.txtMain.Modified && string.IsNullOrEmpty(path) && checkOpenToAcc == true)
            {
                string[] partName = this.Text.Split(new char[] { ' ' });
                this.Text = partName[0].ToString() + " *" + tail;
            }
                
        }

        private void txtMain_SelectionChanged(object sender, EventArgs e)
        {
            int pos = this.txtMain.SelectionStart;
            int line = this.txtMain.GetLineFromCharIndex(pos) + 1;
            int col = pos - this.txtMain.GetFirstCharIndexOfCurrentLine() + 1;
            this.staMain.Text = "Ln " + line + ", Col " + col;
        }


        // Ctrl + N
        private void cmdNew_Click(object sender, EventArgs e)
        {
            if (!checkSave())
            {
                savePrompt();
                if (DialogResult == DialogResult.Yes)
                {
                    saveFile();
                    newFile();
                }
                else if (DialogResult == DialogResult.No)
                    newFile();
                else
                    return;
            }
            newFile();
        }

        //Ctrl + Shift + N
        private void cmdNewWindow_Click(object sender, EventArgs e)
        {
            newWindow();
        }

        //Ctrl + O
        private void cmdOpen_Click(object sender, EventArgs e)
        {
            if (!checkSave())
            {
                savePrompt();
                if (DialogResult == DialogResult.Yes)
                {
                    saveFile();
                    openFile();
                }
                else if (DialogResult == DialogResult.No)
                    openFile();
            }
            else
            {
                if (!checkPass())
                    openFile();
                else
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                    fs.Write(encryptData(txtMain.Text), 0, encryptData(txtMain.Text).Length);
                    fs.Close();
                    MessageBox.Show("File save with password succefull", "NotePad");
                    openFile();
                }
            }

            
        }

        private void savePrompt1()
        {
            DialogResult = MessageBox.Show("File already exits. Do you want to replace it?",
                "NotePad",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }

        //Ctrl + S
        private void cmdSave_Click(object sender, EventArgs e)
        {
           saveFile();
        }

        //Ctrl + Shift + S
        private void cmdSaveAs_Click(object sender, EventArgs e)
        {
            if(checkSaveToAcc == true)
            {
                saveFile();
            }
            sfd = new SaveFileDialog();
            sfd.FileName = "Untitled";
            sfd.Filter = "Text Documents (*.txt)|*.txt|PDF file (*.pdf)|*.pdf |Word File (*.doc)|*.doc|All files (*.*)|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName != "")
                {
                    path = sfd.FileName;
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.Write(txtMain.Text);
                    sw.Close();
                    this.Text = Path.GetFileName(path) + tail;
                }
                checkSaveToAcc = false;
                this.txtMain.Modified = false;
            }    
        }

        //Ctrl + Shift + P
        private void cmdSaveWithPass_Click(object sender, EventArgs e)
        {

            if (!checkPass())
            {
                savePrompt();
                if (DialogResult == DialogResult.Yes)
                {
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    pass = f2.GetPass;
                    if (pass == "")
                        return;
                    else
                    {
                        sfd = new SaveFileDialog();
                        sfd.FileName = "Untitled";
                        sfd.Filter = "Text Documents With Password (*.P)|*.P|All files (*.*)|*.*";
                        if(sfd.ShowDialog() == DialogResult.OK)
                        {
                            if (sfd.FileName != "")
                            {
                                path = sfd.FileName;
                                //File.WriteAllBytes(sfd.FileName, encryptData(txtMain.Text));
                                //this.Text = Path.GetFileName(path) + tail;
                                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                                fs.Write(encryptData(txtMain.Text), 0, encryptData(txtMain.Text).Length);
                                fs.Close();
                                this.Text = Path.GetFileName(path) + tail;
                                this.txtMain.Modified = false;
                            }
                        }        
                    }
                }
                else if (DialogResult == DialogResult.No)
                    return;
            }
            else
            {
                if(path != "")
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                    fs.Write(encryptData(txtMain.Text), 0, encryptData(txtMain.Text).Length);
                    fs.Close();
                    this.Text = Path.GetFileName(path) + tail;
                    this.txtMain.Modified = false;
                }
                else
                {
                    savePrompt();
                    if (DialogResult == DialogResult.Yes)
                    {
                        sfd = new SaveFileDialog();
                        sfd.FileName = "Untitled";
                        sfd.Filter = "Text Documents With Password (*.P)|*.P|All files (*.*)|*.*";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            if (sfd.FileName != "")
                            {
                                path = sfd.FileName;
                                //File.WriteAllBytes(sfd.FileName, encryptData(txtMain.Text));
                                //this.Text = Path.GetFileName(path) + tail;
                                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                                fs.Write(encryptData(txtMain.Text), 0, encryptData(txtMain.Text).Length);
                                fs.Close();
                                this.Text = Path.GetFileName(path) + tail;
                                this.txtMain.Modified = false;
                            }
                        }
                        
                    }
                    else if (DialogResult == DialogResult.No)
                        return;
                }
                
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (!checkSave())
            {
                savePrompt();
                if (DialogResult == DialogResult.Yes)
                {
                    saveFile();
                }
                else if (DialogResult == DialogResult.Cancel)
                    Application.Exit();
            }
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!checkSave())
            {
                savePrompt();
                if (DialogResult == DialogResult.Yes)
                {
                    saveFile();
                }
                else if (DialogResult == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void cmdUndo_Click(object sender, EventArgs e)
        {
            txtMain.Undo();
        }

        private void cmdRedo_Click(object sender, EventArgs e)
        {
            txtMain.Redo();
        }

        private void cmdCut_Click(object sender, EventArgs e)
        {
            txtMain.Cut();
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            txtMain.Copy();
        }

        private void cmdPaste_Click(object sender, EventArgs e)
        {
            txtMain.Paste();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            txtMain.Text = txtMain.Text.Remove(txtMain.SelectionStart, txtMain.SelectionLength);
        }

        private void cmdSelectAll_Click(object sender, EventArgs e)
        {
            txtMain.SelectAll();
        }

        private void cmdTimeDate_Click(object sender, EventArgs e)
        {
            txtMain.Text = txtMain.Text.Insert(txtMain.SelectionStart, DateTime.Now.ToString());
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            if (form3 == null)
            {
                form3 = new Form3(this);
                form3.Editor = this.txtMain;
                form3.Show();
                form3 = null;
            }
        }

        private void cmdReplace_Click(object sender, EventArgs e)
        {
            if (form4 == null)
            {
                form4 = new Form4();
                form4.Editor = this.txtMain;
                form4.editOperation = this.editOperation;
                form4.Show();
                form4 = null;
            }
        }

        private void cmdFont_Click(object sender, EventArgs e)
        {
            fd = new FontDialog();
            fd.Font = txtMain.Font;
            fd.ShowDialog();
            txtMain.Font = fd.Font;
        }

        private void cmdColor_Click(object sender, EventArgs e)
        {
            cd = new ColorDialog();
            cd.Color = txtMain.SelectionColor;
            cd.ShowDialog();
            txtMain.SelectionColor = cd.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtMain.WordWrap = cmdWordWarp.Checked;
            this.staStrip.Visible = cmdStatusBar.Checked;
            
        }

        private void cmdWordWarp_CheckedChanged(object sender, EventArgs e)
        {
            this.txtMain.WordWrap = cmdWordWarp.Checked;
        }

        private void cmdStatusBar_CheckedChanged(object sender, EventArgs e)
        {
            this.staStrip.Visible = cmdStatusBar.Checked;
        }

        

        private void cmdZoomIn_Click(object sender, EventArgs e)
        {
            if (this.staZoom.Text !="500%")
            {
                txtMain.ZoomFactor = txtMain.ZoomFactor + 0.1f;
                countSizeChange += 1;
                int zoom = countSizeChange * 10 + 100;
                this.staZoom.Text = zoom + "%";
            }
        }

        private void cmdZoomOut_Click(object sender, EventArgs e)
        {
            if (this.staZoom.Text !="10%")
            {
                txtMain.ZoomFactor = txtMain.ZoomFactor - 0.1f;
                countSizeChange -= 1;
                int zoom = countSizeChange* 10 + 100;
                this.staZoom.Text = zoom + "%";
            }
        }

        private void cmdRestoreDefaultZoom_Click(object sender, EventArgs e)
        {
            if (this.txtMain.ZoomFactor != 1.0f)
            {
                this.txtMain.ZoomFactor = 1.0f;
                this.staZoom.Text = "100%";
            }
            //this.txtMain.ZoomFactor = 1.0f;
            //this.staZoom.Text = "100%";
            //MessageBox.Show(Convert.ToString(this.txtMain.ZoomFactor));
        }

        private void txtMain_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((ModifierKeys & Keys.Control) == Keys.Control && e.Delta > 0)
            {
                if (this.staZoom.Text != "500%")
                {
                    countSizeChange += 1;
                    int zoom = countSizeChange * 10 + 100;
                    this.staZoom.Text = zoom + "%";
                }
            }

            if ((ModifierKeys & Keys.Control) == Keys.Control && e.Delta < 0)
            {
                if (this.staZoom.Text != "10%")
                {
                    countSizeChange -= 1;
                    int zoom = countSizeChange * 10 + 100;
                    this.staZoom.Text = zoom + "%";
                }
            }
                
        }



        private void cmdViewHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=get+help+with+notepad");
        }

        private void cmdManVoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMain.SelectedText))
                MessageBox.Show("Nothing to say", "Notbad say:");
            else
            {
                SpeechSynthesizer voice = new SpeechSynthesizer();
                voice.SelectVoiceByHints(VoiceGender.Male);
                voice.SpeakAsync(txtMain.SelectedText);
            }
        }

        private void cmdWomanVoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMain.SelectedText))
                MessageBox.Show("Nothing to say", "Notbad say:");
            else
            {
                SpeechSynthesizer voice = new SpeechSynthesizer();
                voice.SelectVoiceByHints(VoiceGender.Female);
                voice.SpeakAsync(txtMain.SelectedText);
            }
        }

        private void cmdSignin_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
            checkSignin = f5.check;
            if(checkSignin == true)
            {
                Form6 f6 = new Form6();
                f6.ShowDialog();
                this.checkLogin = f6.check;
                accName = f6.Username;
                idAcc = f6.idAcc;
                if (this.checkLogin == true)
                {
                    cmdSignin.Enabled = false;
                    cmdLogin.Enabled = false;
                    cmdLogout.Enabled = true;
                    cmdAccFile.Enabled = true;
                    lbAccName.Text = "Hi, " + accName;
                }
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.checkLogin = f6.check;
            accName = f6.Username;
            idAcc = f6.idAcc;
            if (this.checkLogin == true)
            {
                cmdSignin.Enabled = false;
                cmdLogin.Enabled = false;
                cmdLogout.Enabled = true;
                cmdAccFile.Enabled = true;
                lbAccName.Text = "Hi, " + accName;
            }

        }

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            if (checkSaveToAcc == true)
            {
                string[] partName = this.Text.Split(new char[] { ' ' });
                string[] fileName = partName[0].Split(new char[] { '*' });
                if (fileName[0] == "Untitled")
                {
                    fileName[0] = "Untitled.txt";
                }
                try
                {
                    dbAccountDataContext db = new dbAccountDataContext();
                    var query = db.Files.Where(w => w.Filename == fileName[0]).Where(p => p.account_id == idAcc).FirstOrDefault();
                    db.Files.DeleteOnSubmit(query);
                    db.SubmitChanges();
                    File f = new File();
                    f.Filename = fileName[0];
                    f.account_id = idAcc;
                    if (f.Filename[f.Filename.Length - 1] == 'P' && pass != "")
                    {
                        f.Data = encryptData(this.txtMain.Text);
                    }
                    else
                    {
                        f.Data = Encoding.ASCII.GetBytes(this.txtMain.Text);
                    }
                    db.Files.InsertOnSubmit(f);
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            checkLogin = false;
            checkSaveToAcc = false;
            checkOpenToAcc = false;
            oldFileNameInAcc = "";
            accName = "";
            lbAccName.Text = "";
            pass = "";
            idAcc = 0;
            cmdSignin.Enabled = true;
            cmdLogin.Enabled = true;
            cmdLogout.Enabled = false;
            cmdAccFile.Enabled = false;
            MessageBox.Show("Logout successful");
        }

        private void cmdAccFile_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.text = txtMain.Text;
            f7.name = Text;
            f7.idAcc = idAcc;
            f7.pass = pass;
            f7.ShowDialog();
            txtMain.Text = f7.text;
            oldFileNameInAcc = f7.name;
            string[] partName = f7.name.Split(new char[] { ' ' });
            if(partName.Length > 1 && partName[partName.Length -1] == "NotePad")
            {
                this.Text = f7.name;
            }
            else
            {
                this.Text = f7.name + tail;
            }
            pass = f7.pass;
            checkOpenToAcc = f7.checkOpen;
            checkSaveToAcc = f7.checkSave;
        }
    }
}
