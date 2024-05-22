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
using System.Data.SqlClient;

namespace Client
{
    
    public partial class Temp : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private StreamReader reader;
        private StreamWriter writer;

        private string user_name;
        private string user_id;
        private string user_pw;
        private string ChatLogFolderPath = @"C:\Users\Public\Documents";
        private string ChatLogFilePath;

        public Temp(TcpClient t, string userid, string userpw, string username)
        {
            InitializeComponent();
            client = t;
            user_id = userid;
            user_pw = userpw;
            user_name = username;
            ChatLogFilePath = Path.Combine(ChatLogFolderPath, user_id + ".txt");
            label_Name.Text = user_name;
            if (File.Exists(ChatLogFilePath))
            {
                ChatTextBox.Text = File.ReadAllText(ChatLogFilePath);
            }
            ConnectToChatServer();
        }

        private void Temp_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(ChatLogFilePath, ChatTextBox.Text);
            client.Close();
            this.Owner.Close();
        }

        private void ConnectToChatServer()
        {
            try
            {
                // 서버에 연결
                client = new TcpClient("127.0.0.1", 13002);
                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);

                writer.WriteLine(user_name);
                writer.Flush();

                // 서버와 연결되었다는 메시지를 채팅 로그에 표시
                AppendMessage("Connected to server." + "Hello, " + user_name);

                // 채팅을 처리하는 쓰레드 시작
                Thread chatThread = new Thread(ReceiveMessages);
                chatThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to server: {ex.Message}");
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                byte[] buffer1 = Encoding.UTF8.GetBytes(user_name + ": " + MessageTextBox.Text + Environment.NewLine);
                stream.Write(buffer1, 0, buffer1.Length);
                byte[] buffer2 = Encoding.UTF8.GetBytes(textBox_Whisper.Text + Environment.NewLine);
                stream.Write(buffer2, 0, buffer2.Length);
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
