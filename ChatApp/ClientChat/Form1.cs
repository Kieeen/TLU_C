using SimpleTCP;
using System.Text;

namespace ClientChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
          
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }
        private void Client_DataReceived(object? sender, SimpleTCP.Message m)
        {
            txtMainClient.Invoke((MethodInvoker)delegate ()
            {
                txtMainClient.Text += m.MessageString;
            });

        }

        private void btnSendClient_Click(object sender, EventArgs e)
        {
            string message = "\r\nClient chat: " + txtMessagerClient.Text;
            txtMainClient.Text += message;
            client.WriteLineAndGetReply(message, TimeSpan.FromSeconds(2));
        }

        private void btnConnectClient_Click(object sender, EventArgs e)
        {
            btnConnectClient.Enabled = false;
            client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
            txtMainClient.Text += "Server connected"; 
        }
    }
}