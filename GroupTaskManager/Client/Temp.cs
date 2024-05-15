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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.Threading;

namespace Client
{
    
    public partial class Temp : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;

        public Temp(TcpClient t)
        {
            InitializeComponent();
            client = t;
        }

        private void Temp_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
            this.Owner.Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            try
            {
                client.Connect("127.0.0.1", 13002);
                stream = client.GetStream();
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버에 연결할 수 없습니다: " + ex.Message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(MessageTextBox.Text + Environment.NewLine);
                stream.Write(buffer, 0, buffer.Length);
                MessageTextBox.Clear();
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            while (client != null && client.Connected)
            {
                try
                {
                    if (stream == null)
                        stream = client.GetStream();

                    while (stream.DataAvailable)
                    {
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead > 0)
                        {
                            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                            AppendMessage(message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    AppendMessage("오류: " + ex.Message);
                    break;
                }
            }
        }

        private void AppendMessage(string message)
        {
            if (ChatTextBox.InvokeRequired)
            {
                ChatTextBox.BeginInvoke(new MethodInvoker(() =>
                {
                    ChatTextBox.AppendText(message + Environment.NewLine);
                }));
            }
            else
            {
                ChatTextBox.AppendText(message + Environment.NewLine);
            }
        }

    }
}
