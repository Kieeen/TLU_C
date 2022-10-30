namespace ClientChat
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
            this.btnSendClient = new System.Windows.Forms.Button();
            this.txtMessagerClient = new System.Windows.Forms.TextBox();
            this.txtMainClient = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnConnectClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendClient
            // 
            this.btnSendClient.Location = new System.Drawing.Point(863, 496);
            this.btnSendClient.Name = "btnSendClient";
            this.btnSendClient.Size = new System.Drawing.Size(150, 46);
            this.btnSendClient.TabIndex = 25;
            this.btnSendClient.Text = "Send";
            this.btnSendClient.UseVisualStyleBackColor = true;
            this.btnSendClient.Click += new System.EventHandler(this.btnSendClient_Click);
            // 
            // txtMessagerClient
            // 
            this.txtMessagerClient.Location = new System.Drawing.Point(225, 437);
            this.txtMessagerClient.Multiline = true;
            this.txtMessagerClient.Name = "txtMessagerClient";
            this.txtMessagerClient.Size = new System.Drawing.Size(788, 53);
            this.txtMessagerClient.TabIndex = 24;
            // 
            // txtMainClient
            // 
            this.txtMainClient.Location = new System.Drawing.Point(225, 154);
            this.txtMainClient.Multiline = true;
            this.txtMainClient.Name = "txtMainClient";
            this.txtMainClient.Size = new System.Drawing.Size(788, 253);
            this.txtMainClient.TabIndex = 23;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(515, 109);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(120, 39);
            this.txtPort.TabIndex = 22;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(225, 109);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(200, 39);
            this.txtHost.TabIndex = 21;
            this.txtHost.Text = "127.0.0.1";
            // 
            // btnConnectClient
            // 
            this.btnConnectClient.Location = new System.Drawing.Point(863, 105);
            this.btnConnectClient.Name = "btnConnectClient";
            this.btnConnectClient.Size = new System.Drawing.Size(150, 46);
            this.btnConnectClient.TabIndex = 20;
            this.btnConnectClient.Text = "Connect";
            this.btnConnectClient.UseVisualStyleBackColor = true;
            this.btnConnectClient.Click += new System.EventHandler(this.btnConnectClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Host:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 618);
            this.Controls.Add(this.btnSendClient);
            this.Controls.Add(this.txtMessagerClient);
            this.Controls.Add(this.txtMainClient);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnConnectClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSendClient;
        private TextBox txtMessagerClient;
        private TextBox txtMainClient;
        private TextBox txtPort;
        private TextBox txtHost;
        private Button btnConnectClient;
        private Label label2;
        private Label label1;
    }
}