namespace NotePad
{
    partial class Form3
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
            this.txtFind = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnUp = new System.Windows.Forms.RadioButton();
            this.rBtnDown = new System.Windows.Forms.RadioButton();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(101, 10);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(305, 27);
            this.txtFind.TabIndex = 0;
            this.txtFind.Text = "";
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find What";
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(444, 10);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(90, 27);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(444, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnDown);
            this.groupBox1.Controls.Add(this.rBtnUp);
            this.groupBox1.Location = new System.Drawing.Point(206, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // rBtnUp
            // 
            this.rBtnUp.AutoSize = true;
            this.rBtnUp.Location = new System.Drawing.Point(6, 36);
            this.rBtnUp.Name = "rBtnUp";
            this.rBtnUp.Size = new System.Drawing.Size(47, 21);
            this.rBtnUp.TabIndex = 0;
            this.rBtnUp.TabStop = true;
            this.rBtnUp.Text = "Up";
            this.rBtnUp.UseVisualStyleBackColor = true;
            this.rBtnUp.CheckedChanged += new System.EventHandler(this.rBtnUp_CheckedChanged);
            // 
            // rBtnDown
            // 
            this.rBtnDown.AutoSize = true;
            this.rBtnDown.Location = new System.Drawing.Point(98, 36);
            this.rBtnDown.Name = "rBtnDown";
            this.rBtnDown.Size = new System.Drawing.Size(64, 21);
            this.rBtnDown.TabIndex = 1;
            this.rBtnDown.TabStop = true;
            this.rBtnDown.Text = "Down";
            this.rBtnDown.UseVisualStyleBackColor = true;
            this.rBtnDown.CheckedChanged += new System.EventHandler(this.rBtnDown_CheckedChanged);
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(12, 91);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(104, 21);
            this.chkMatchCase.TabIndex = 5;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            this.chkMatchCase.CheckedChanged += new System.EventHandler(this.chkMatchCase_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 150);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Name = "Form3";
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnDown;
        private System.Windows.Forms.RadioButton rBtnUp;
        private System.Windows.Forms.CheckBox chkMatchCase;
    }
}