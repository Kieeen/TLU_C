using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TicTacToeV1
{
    public partial class Form2 : Form
    {
        private char playerChar;
        private char opponentChar;
        private bool checkState = false;
        private string[,] table = new string[35, 35];
        private Button[,] btn = new Button[35, 35];
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private Socket socket;
        private TcpListener server = null;
        private TcpClient client;

        public Form2(bool isHost, string ip = null)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;
            if (isHost)
            {
                drawTable();
                playerChar = 'X';
                opponentChar = 'O';
                server = new TcpListener(System.Net.IPAddress.Any, 9999);
                server.Start();
                socket = server.AcceptSocket();
            }
            else
            {
                drawTable();
                playerChar = 'O';
                opponentChar = 'X';
                try
                {
                    client = new TcpClient(ip, 9999);
                    socket = client.Client;
                    MessageReceiver.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }

        }

        private void drawTable()
        {
            for (int i = 0; i < 27; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    table[i, j] = "";
                    btn[i, j] = new Button();
                    btn[i, j].Name = i.ToString() + "_" + j.ToString();
                    btn[i, j].Location = new Point(j * 20, i * 20);
                    btn[i, j].Size = new Size(20, 20);
                    //btn[i, j].ForeColor = Color.Blue;
                    this.splitContainer1.Panel2.Controls.Add(btn[i, j]);
                    btn[i, j].Click += b_Click;
                }
            }
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (checkState == true)
            {
                return;
            }
            freezeBoard();
            lbTurn.Text = "Opponent's Turn!";
            receiveMove();
            if (checkState == false)
            {
                lbTurn.Text = "Your Turn!";
                unfreezeBoard();
            }   
        }

        private void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingData = new byte[10];
            sendingData = aEncoding.GetBytes(b.Name);
            socket.Send(sendingData);
            b.Text = playerChar.ToString();
            string[] value = b.Name.Split(new char[] { '_' });
            int i = Convert.ToInt16(value[0]);
            int j = Convert.ToInt16(value[1]);
            table[i, j] = playerChar.ToString();
            if (checkDraw() == true)
            {
                checkState = true;
                lbTurn.Text = "DRAW!";
                //MessageBox.Show("DRAW");
            }
            else if (checkRow(i, j, table[i, j]) == true || checkColumm(i, j, table[i, j]) == true ||
                checkLC(i, j, table[i, j]) == true || checkRC(i, j, table[i, j]) == true)
            {
                checkState = true;
                lbTurn.Text = "You Win!";
                //MessageBox.Show("You Win!");
                freezeBoard();
            }
            MessageReceiver.RunWorkerAsync();
        }


        private void unfreezeBoard()
        {
            for (int i = 0; i < 27; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (btn[i, j].Text == "")
                        btn[i, j].Enabled = true;
                }
            }
        }

        private void receiveMove()
        {
            try
            {
                byte[] receivedData = new byte[10];
                socket.Receive(receivedData);
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedName = aEncoding.GetString(receivedData);
                string[] value = receivedName.Split(new char[] { '_' });
                int i = Convert.ToInt16(value[0]);
                int j = Convert.ToInt16(value[1]);
                btn[i, j].Text = opponentChar.ToString();
                table[i, j] = opponentChar.ToString();
                if (checkDraw() == true)
                {
                    checkState = true;
                    lbTurn.Text = "DRAW!";
                    //MessageBox.Show("DRAW");
                }
                else if (checkRow(i, j, table[i, j]) == true || checkColumm(i, j, table[i, j]) == true ||
                    checkLC(i, j, table[i, j]) == true || checkRC(i, j, table[i, j]) == true)
                {
                    checkState = true;
                    lbTurn.Text = "You Lost!";
                    //MessageBox.Show("You Lost!");
                    //freezeBoard();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void freezeBoard()
        {
            for (int i = 0; i < 27; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    btn[i, j].Enabled = false;
                }
            }
        }

 
        private bool checkRow(int x, int y, string value)
        {
            int count = 1;
            //int left = 4;
            //int right = 4;
            //check row left
            for (int j = y - 1; j >= (y - 4); j--)
            {
                if (j >= 0)
                {
                    if (table[x, j] == value)
                        count++;
                    else
                        break;
                }
            }
            //check row right
            for (int j = y + 1; j <= (y + 4); j++)
            {
                if (table[x, j] == value)
                    count++;
                else
                    break;
            }
            if (count == 5)
                return true;
            return false;
        }

        private bool checkColumm(int x, int y, string value)
        {
            int count = 1;
            //int left = 4;
            //int right = 4;
            //check columm up
            for (int i = x - 1; i >= (x - 4); i--)
            {
                if (i >= 0)
                {
                    if (table[i, y] == value)
                        count++;
                    else
                        break;
                }
            }
            //check columm down
            for (int i = x + 1; i <= (x + 4); i++)
            {
                if (table[i, y] == value)
                    count++;
                else
                    break;
            }
            if (count == 5)
                return true;
            return false;
        }

        //left cross - cheo trai 
        private bool checkLC(int x, int y, string value)
        {
            int count = 1;
            //check up
            int i = x - 1;
            int j = y - 1;
            while (i >= 0 && j >= 0)
            {
                if (table[i, j] == value)
                    count++;
                else
                    break;
                i--;
                j--;
            }
            //check down
            i = x + 1;
            j = y + 1;
            while (i <= (x + 4) && j <= (y + 4))
            {
                if (table[i, j] == value)
                    count++;
                else
                    break;
                i++;
                j++;
            }

            if (count == 5)
                return true;
            return false;
        }

        private bool checkRC(int x, int y, string value)
        {
            int count = 1;
            //check up
            int i = x - 1;
            int j = y + 1;
            while (i >= 0 && j <= (y + 4))
            {
                if (table[i, j] == value)
                    count++;
                else
                    break;
                i--;
                j++;
            }
            //check down
            i = x + 1;
            j = y - 1;
            while (i <= (x + 4) && j >= 0)
            {
                if (table[i, j] == value)
                    count++;
                else
                    break;
                i++;
                j--;
            }

            if (count == 5)
                return true;
            return false;
        }

        private bool checkDraw()
        {
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table.Length; j++)
                {
                    if (table[i, j] == "")
                        return false;
                }
            }
            return true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();
            if (server != null)
                server.Stop();
        }


    }  
}
