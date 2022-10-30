using SimpleTCP;
using System.Net;
using System.Text;
namespace ServerChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        SimpleTcpClient client;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();

            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message m) // For Loop get message
        {
            txtMainServer.Invoke((MethodInvoker)delegate ()
            {
                txtMainServer.Text += m.MessageString;
            });
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
 
            IPAddress ip = IPAddress.Parse(txtHost.Text);
            server.Start(ip, Convert.ToInt32(txtPort.Text));
            if (server.IsStarted)
            {
                txtMainServer.Text += "Server start...";
                btnStartServer.Enabled = false;
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }
        
        private void btnSendServer_Click(object sender, EventArgs e)
        {
            string message = "\r\nServer chat: " + txtMessagerServer.Text;
            txtMessagerServer.Text += message;
            //client.WriteLineAndGetReply(message, TimeSpan.FromSeconds(2));
        }
    }
}