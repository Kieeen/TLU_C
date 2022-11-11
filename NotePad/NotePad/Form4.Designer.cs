namespace NotePad
{
    partial class Form4
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.RichTextBox();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.RichTextBox();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnDown = new System.Windows.Forms.RadioButton();
            this.rBtnUp = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(338, 136);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(338, 17);
            this.btnFindNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 22);
            this.btnFindNext.TabIndex = 8;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Find What";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(81, 17);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(230, 23);
            this.txtFind.TabIndex = 6;
            this.txtFind.Text = "";
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(9, 141);
            this.chkMatchCase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(83, 17);
            this.chkMatchCase.TabIndex = 11;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Replace With";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(81, 54);
            this.txtReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(230, 23);
            this.txtReplace.TabIndex = 12;
            this.txtReplace.Text = "";
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(338, 97);
            this.btnReplaceAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 22);
            this.btnReplaceAll.TabIndex = 14;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(338, 56);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 22);
            this.btnReplace.TabIndex = 15;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnDown);
            this.groupBox1.Controls.Add(this.rBtnUp);
            this.groupBox1.Location = new System.Drawing.Point(160, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 51);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // rBtnDown
            // 
            this.rBtnDown.AutoSize = true;
            this.rBtnDown.Location = new System.Drawing.Point(74, 29);
            this.rBtnDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtnDown.Name = "rBtnDown";
            this.rBtnDown.Size = new System.Drawing.Size(53, 17);
            this.rBtnDown.TabIndex = 1;
            this.rBtnDown.TabStop = true;
            this.rBtnDown.Text = "Down";
            this.rBtnDown.UseVisualStyleBackColor = true;
            // 
            // rBtnUp
            // 
            this.rBtnUp.AutoSize = true;
            this.rBtnUp.Location = new System.Drawing.Point(4, 29);
            this.rBtnUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtnUp.Name = "rBtnUp";
            this.rBtnUp.Size = new System.Drawing.Size(39, 17);
            this.rBtnUp.TabIndex = 0;
            this.rBtnUp.TabStop = true;
            this.rBtnUp.Text = "Up";
            this.rBtnUp.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 167);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.chkMatchCase);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Replace";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtFind;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnDown;
        private System.Windows.Forms.RadioButton rBtnUp;

    }
}