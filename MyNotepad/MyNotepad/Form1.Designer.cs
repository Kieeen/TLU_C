namespace MyNotepad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdNew = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSave = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFont = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNew,
            this.cmdOpen,
            this.cmdSave,
            this.cmdSaveAs,
            this.cmdExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // cmdNew
            // 
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(152, 22);
            this.cmdNew.Text = "New";
            // 
            // cmdOpen
            // 
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(152, 22);
            this.cmdOpen.Text = "Open";
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(152, 22);
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdSaveAs
            // 
            this.cmdSaveAs.Name = "cmdSaveAs";
            this.cmdSaveAs.Size = new System.Drawing.Size(152, 22);
            this.cmdSaveAs.Text = "Save as";
            // 
            // cmdExit
            // 
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(152, 22);
            this.cmdExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdFont});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cmdFont
            // 
            this.cmdFont.Name = "cmdFont";
            this.cmdFont.Size = new System.Drawing.Size(152, 22);
            this.cmdFont.Text = "Font";
            this.cmdFont.Click += new System.EventHandler(this.cmdFont_Click);
            // 
            // txtMain
            // 
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.Location = new System.Drawing.Point(0, 24);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(701, 392);
            this.txtMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 416);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "My Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdNew;
        private System.Windows.Forms.ToolStripMenuItem cmdOpen;
        private System.Windows.Forms.ToolStripMenuItem cmdSave;
        private System.Windows.Forms.ToolStripMenuItem cmdSaveAs;
        private System.Windows.Forms.ToolStripMenuItem cmdExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdFont;
        private System.Windows.Forms.TextBox txtMain;
    }
}

