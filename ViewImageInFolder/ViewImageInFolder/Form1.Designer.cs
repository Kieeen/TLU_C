namespace ViewImageInFolder
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
            this.panImages = new System.Windows.Forms.SplitContainer();
            this.btnSlectFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panImages)).BeginInit();
            this.panImages.Panel1.SuspendLayout();
            this.panImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panImages
            // 
            this.panImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panImages.Location = new System.Drawing.Point(0, 0);
            this.panImages.Name = "panImages";
            this.panImages.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panImages.Panel1
            // 
            this.panImages.Panel1.Controls.Add(this.btnSlectFolder);
            this.panImages.Size = new System.Drawing.Size(608, 392);
            this.panImages.SplitterDistance = 71;
            this.panImages.TabIndex = 0;
            // 
            // btnSlectFolder
            // 
            this.btnSlectFolder.Location = new System.Drawing.Point(238, 22);
            this.btnSlectFolder.Name = "btnSlectFolder";
            this.btnSlectFolder.Size = new System.Drawing.Size(144, 23);
            this.btnSlectFolder.TabIndex = 0;
            this.btnSlectFolder.Text = "Select Folder";
            this.btnSlectFolder.UseVisualStyleBackColor = true;
            this.btnSlectFolder.Click += new System.EventHandler(this.btnSlectFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 392);
            this.Controls.Add(this.panImages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panImages.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panImages)).EndInit();
            this.panImages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer panImages;
        private System.Windows.Forms.Button btnSlectFolder;
    }
}

