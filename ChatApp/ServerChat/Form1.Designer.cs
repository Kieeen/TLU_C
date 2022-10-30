namespace ServerChat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendServer = new System.Windows.Forms.Button();
            this.txtMessagerServer = new System.Windows.Forms.TextBox();
            this.txtMainServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendServer
            // 
            this.btnSendServer.Location = new System.Drawing.Point(829, 512);
            this.btnSendServer.Name = "btnSendServer";
            this.btnSendServer.Size = new System.Drawing.Size(150, 46);
            this.btnSendServer.TabIndex = 25;
            this.btnSendServer.Text = "Send";
            this.btnSendServer.UseVisualStyleBackColor = true;
            this.btnSendServer.Click += new System.EventHandler(this.btnSendServer_Click);
            // 
            // txtMessagerServer
            // 
            this.txtMessagerServer.Location = new System.Drawing.Point(191, 453);
            this.txtMessagerServer.Multiline = true;
            this.txtMessagerServer.Name = "txtMessagerServer";
            this.txtMessagerServer.Size = new System.Drawing.Size(788, 53);
            this.txtMessagerServer.TabIndex = 24;
            // 
            // txtMainServer
            // 
            this.txtMainServer.Location = new System.Drawing.Point(191, 170);
            this.txtMainServer.Multiline = true;
            this.txtMainServer.Name = "txtMainServer";
            this.txtMainServer.Size = new System.Drawing.Size(788, 253);
            this.txtMainServer.TabIndex = 23;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(481, 125);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(120, 39);
            this.txtPort.TabIndex = 22;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(191, 125);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(200, 39);
            this.txtHost.TabIndex = 21;
            this.txtHost.Text = "127.0.0.1";
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(829, 121);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(150, 46);
            this.btnStopServer.TabIndex = 20;
            this.btnStopServer.Text = "Stop";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Host:";
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(673, 121);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(150, 46);
            this.btnStartServer.TabIndex = 26;
            this.btnStartServer.Text = "Start";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 712);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.btnSendServer);
            this.Controls.Add(this.txtMessagerServer);
            this.Controls.Add(this.txtMainServer);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSendServer;
        private TextBox txtMessagerServer;
        private TextBox txtMainServer;
        private TextBox txtPort;
        private TextBox txtHost;
        private Button btnStopServer;
        private Label label2;
        private Label label1;
        private Button btnStartServer;
    }
}