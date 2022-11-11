namespace NotePad
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
            this.cmdNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSave = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSaveWithPass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdFind = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFont = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdWordWarp = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRestoreDefaultZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.voiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdManVoice = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdWomanVoice = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.staStrip = new System.Windows.Forms.StatusStrip();
            this.staMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.staZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.staStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.voiceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNew,
            this.cmdNewWindow,
            this.cmdOpen,
            this.cmdSave,
            this.cmdSaveAs,
            this.cmdSaveWithPass,
            this.toolStripSeparator1,
            this.cmdExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // cmdNew
            // 
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.cmdNew.Size = new System.Drawing.Size(305, 26);
            this.cmdNew.Text = "New";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdNewWindow
            // 
            this.cmdNewWindow.Name = "cmdNewWindow";
            this.cmdNewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.cmdNewWindow.Size = new System.Drawing.Size(305, 26);
            this.cmdNewWindow.Text = "New Window";
            this.cmdNewWindow.Click += new System.EventHandler(this.cmdNewWindow_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.cmdOpen.Size = new System.Drawing.Size(305, 26);
            this.cmdOpen.Text = "Open";
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.cmdSave.Size = new System.Drawing.Size(305, 26);
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdSaveAs
            // 
            this.cmdSaveAs.Name = "cmdSaveAs";
            this.cmdSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.cmdSaveAs.Size = new System.Drawing.Size(305, 26);
            this.cmdSaveAs.Text = "Save As";
            this.cmdSaveAs.Click += new System.EventHandler(this.cmdSaveAs_Click);
            // 
            // cmdSaveWithPass
            // 
            this.cmdSaveWithPass.Name = "cmdSaveWithPass";
            this.cmdSaveWithPass.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.cmdSaveWithPass.Size = new System.Drawing.Size(305, 26);
            this.cmdSaveWithPass.Text = "Save With Password";
            this.cmdSaveWithPass.Click += new System.EventHandler(this.cmdSaveWithPass_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(302, 6);
            // 
            // cmdExit
            // 
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(305, 26);
            this.cmdExit.Text = "Exit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AutoSize = false;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdUndo,
            this.toolStripSeparator2,
            this.cmdCut,
            this.cmdCopy,
            this.cmdPaste,
            this.cmdDelete,
            this.toolStripSeparator4,
            this.cmdFind,
            this.cmdReplace,
            this.toolStripSeparator3,
            this.cmdSelectAll,
            this.cmdTimeDate});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cmdUndo
            // 
            this.cmdUndo.AutoSize = false;
            this.cmdUndo.Name = "cmdUndo";
            this.cmdUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cmdUndo.Size = new System.Drawing.Size(224, 26);
            this.cmdUndo.Text = "Undo";
            this.cmdUndo.Click += new System.EventHandler(this.cmdUndo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // cmdCut
            // 
            this.cmdCut.AutoSize = false;
            this.cmdCut.Name = "cmdCut";
            this.cmdCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cmdCut.Size = new System.Drawing.Size(224, 26);
            this.cmdCut.Text = "Cut";
            this.cmdCut.Click += new System.EventHandler(this.cmdCut_Click);
            // 
            // cmdCopy
            // 
            this.cmdCopy.AutoSize = false;
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cmdCopy.Size = new System.Drawing.Size(224, 26);
            this.cmdCopy.Text = "Copy";
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // cmdPaste
            // 
            this.cmdPaste.AutoSize = false;
            this.cmdPaste.Name = "cmdPaste";
            this.cmdPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.cmdPaste.Size = new System.Drawing.Size(224, 26);
            this.cmdPaste.Text = "Paste";
            this.cmdPaste.Click += new System.EventHandler(this.cmdPaste_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoSize = false;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmdDelete.Size = new System.Drawing.Size(224, 26);
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(195, 6);
            // 
            // cmdFind
            // 
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.cmdFind.Size = new System.Drawing.Size(198, 26);
            this.cmdFind.Text = "Find";
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // cmdReplace
            // 
            this.cmdReplace.Name = "cmdReplace";
            this.cmdReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.cmdReplace.Size = new System.Drawing.Size(198, 26);
            this.cmdReplace.Text = "Replace";
            this.cmdReplace.Click += new System.EventHandler(this.cmdReplace_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // cmdSelectAll
            // 
            this.cmdSelectAll.AutoSize = false;
            this.cmdSelectAll.Name = "cmdSelectAll";
            this.cmdSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.cmdSelectAll.Size = new System.Drawing.Size(224, 26);
            this.cmdSelectAll.Text = "Select All";
            this.cmdSelectAll.Click += new System.EventHandler(this.cmdSelectAll_Click);
            // 
            // cmdTimeDate
            // 
            this.cmdTimeDate.AutoSize = false;
            this.cmdTimeDate.Name = "cmdTimeDate";
            this.cmdTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.cmdTimeDate.Size = new System.Drawing.Size(224, 26);
            this.cmdTimeDate.Text = "Time/Date";
            this.cmdTimeDate.Click += new System.EventHandler(this.cmdTimeDate_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Checked = true;
            this.formatToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdFont,
            this.cmdColor,
            this.cmdWordWarp});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // cmdFont
            // 
            this.cmdFont.Name = "cmdFont";
            this.cmdFont.Size = new System.Drawing.Size(159, 26);
            this.cmdFont.Text = "Font";
            this.cmdFont.Click += new System.EventHandler(this.cmdFont_Click);
            // 
            // cmdColor
            // 
            this.cmdColor.Name = "cmdColor";
            this.cmdColor.Size = new System.Drawing.Size(159, 26);
            this.cmdColor.Text = "Color";
            this.cmdColor.Click += new System.EventHandler(this.cmdColor_Click);
            // 
            // cmdWordWarp
            // 
            this.cmdWordWarp.Checked = true;
            this.cmdWordWarp.CheckOnClick = true;
            this.cmdWordWarp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmdWordWarp.Name = "cmdWordWarp";
            this.cmdWordWarp.Size = new System.Drawing.Size(159, 26);
            this.cmdWordWarp.Text = "Word Warp";
            this.cmdWordWarp.CheckedChanged += new System.EventHandler(this.cmdWordWarp_CheckedChanged);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.cmdStatusBar});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdZoomIn,
            this.cmdZoomOut,
            this.cmdRestoreDefaultZoom});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // cmdZoomIn
            // 
            this.cmdZoomIn.Name = "cmdZoomIn";
            this.cmdZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.cmdZoomIn.Size = new System.Drawing.Size(281, 26);
            this.cmdZoomIn.Text = "Zoom In";
            this.cmdZoomIn.Click += new System.EventHandler(this.cmdZoomIn_Click);
            // 
            // cmdZoomOut
            // 
            this.cmdZoomOut.Name = "cmdZoomOut";
            this.cmdZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.cmdZoomOut.Size = new System.Drawing.Size(281, 26);
            this.cmdZoomOut.Text = "Zoom Out";
            this.cmdZoomOut.Click += new System.EventHandler(this.cmdZoomOut_Click);
            // 
            // cmdRestoreDefaultZoom
            // 
            this.cmdRestoreDefaultZoom.Name = "cmdRestoreDefaultZoom";
            this.cmdRestoreDefaultZoom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.cmdRestoreDefaultZoom.Size = new System.Drawing.Size(281, 26);
            this.cmdRestoreDefaultZoom.Text = "Restore Default Zoom";
            this.cmdRestoreDefaultZoom.Click += new System.EventHandler(this.cmdRestoreDefaultZoom_Click);
            // 
            // cmdStatusBar
            // 
            this.cmdStatusBar.Checked = true;
            this.cmdStatusBar.CheckOnClick = true;
            this.cmdStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmdStatusBar.Name = "cmdStatusBar";
            this.cmdStatusBar.Size = new System.Drawing.Size(150, 26);
            this.cmdStatusBar.Text = "Status Bar";
            this.cmdStatusBar.CheckedChanged += new System.EventHandler(this.cmdStatusBar_CheckedChanged);
            // 
            // voiceToolStripMenuItem
            // 
            this.voiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdManVoice,
            this.cmdWomanVoice});
            this.voiceToolStripMenuItem.Name = "voiceToolStripMenuItem";
            this.voiceToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.voiceToolStripMenuItem.Text = "Voice";
            // 
            // cmdManVoice
            // 
            this.cmdManVoice.Name = "cmdManVoice";
            this.cmdManVoice.Size = new System.Drawing.Size(135, 26);
            this.cmdManVoice.Text = "Man";
            this.cmdManVoice.Click += new System.EventHandler(this.cmdManVoice_Click);
            // 
            // cmdWomanVoice
            // 
            this.cmdWomanVoice.Name = "cmdWomanVoice";
            this.cmdWomanVoice.Size = new System.Drawing.Size(135, 26);
            this.cmdWomanVoice.Text = "Woman";
            this.cmdWomanVoice.Click += new System.EventHandler(this.cmdWomanVoice_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdViewHelp});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // cmdViewHelp
            // 
            this.cmdViewHelp.Name = "cmdViewHelp";
            this.cmdViewHelp.Size = new System.Drawing.Size(152, 26);
            this.cmdViewHelp.Text = "View Help";
            this.cmdViewHelp.Click += new System.EventHandler(this.cmdViewHelp_Click);
            // 
            // txtMain
            // 
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMain.Location = new System.Drawing.Point(0, 28);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(857, 503);
            this.txtMain.TabIndex = 1;
            this.txtMain.Text = "";
            this.txtMain.SelectionChanged += new System.EventHandler(this.txtMain_SelectionChanged);
            this.txtMain.TextChanged += new System.EventHandler(this.txtMain_TextChanged);
            this.txtMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.txtMain_MouseWheel);
            // 
            // staStrip
            // 
            this.staStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staMain,
            this.staZoom});
            this.staStrip.Location = new System.Drawing.Point(0, 505);
            this.staStrip.Name = "staStrip";
            this.staStrip.Size = new System.Drawing.Size(857, 26);
            this.staStrip.TabIndex = 2;
            this.staStrip.Text = "statusStrip1";
            // 
            // staMain
            // 
            this.staMain.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.staMain.Name = "staMain";
            this.staMain.Size = new System.Drawing.Size(77, 20);
            this.staMain.Text = "Ln 1, Col 1";
            // 
            // staZoom
            // 
            this.staZoom.Name = "staZoom";
            this.staZoom.Size = new System.Drawing.Size(45, 21);
            this.staZoom.Text = "100%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 531);
            this.Controls.Add(this.staStrip);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Untitled - NotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.staStrip.ResumeLayout(false);
            this.staStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdNew;
        private System.Windows.Forms.ToolStripMenuItem cmdNewWindow;
        private System.Windows.Forms.ToolStripMenuItem cmdOpen;
        private System.Windows.Forms.ToolStripMenuItem cmdSave;
        private System.Windows.Forms.ToolStripMenuItem cmdSaveAs;
        private System.Windows.Forms.ToolStripMenuItem cmdSaveWithPass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmdExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.RichTextBox txtMain;
        private System.Windows.Forms.StatusStrip staStrip;
        private System.Windows.Forms.ToolStripStatusLabel staMain;
        private System.Windows.Forms.ToolStripMenuItem cmdUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmdCut;
        private System.Windows.Forms.ToolStripMenuItem cmdCopy;
        private System.Windows.Forms.ToolStripMenuItem cmdPaste;
        private System.Windows.Forms.ToolStripMenuItem cmdDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmdSelectAll;
        private System.Windows.Forms.ToolStripMenuItem cmdTimeDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cmdReplace;
        private System.Windows.Forms.ToolStripMenuItem cmdFind;
        private System.Windows.Forms.ToolStripMenuItem cmdFont;
        private System.Windows.Forms.ToolStripMenuItem cmdColor;
        private System.Windows.Forms.ToolStripMenuItem cmdWordWarp;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdZoomIn;
        private System.Windows.Forms.ToolStripMenuItem cmdZoomOut;
        private System.Windows.Forms.ToolStripMenuItem cmdRestoreDefaultZoom;
        private System.Windows.Forms.ToolStripStatusLabel staZoom;
        private System.Windows.Forms.ToolStripMenuItem cmdViewHelp;
        private System.Windows.Forms.ToolStripMenuItem voiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdManVoice;
        private System.Windows.Forms.ToolStripMenuItem cmdWomanVoice;
        private System.Windows.Forms.ToolStripMenuItem cmdStatusBar;
    }
}

