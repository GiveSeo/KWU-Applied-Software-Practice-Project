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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client
{
    
    public partial class Temp : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private StreamReader reader;
        private StreamWriter writer;

        private string user_name; // 사용자 이름
        private string user_id; // 사용자 아이디
        private string user_pw; // 사용자 패스워드
        private string ChatLogFolderPath; // 채팅 로그 폴더 경로
        private string ChatLogFilePath; // 채팅 로그 파일 경로

        public Temp(TcpClient t, string userid, string userpw, string username)
        {
            InitializeComponent(); 
            // 사용자 정보 설정
            client = t; 
            user_id = userid; 
            user_pw = userpw;
            user_name = username;
            label_Name.Text = user_name; // 사용자 이름 표시 라벨
            // 채팅 로그 폴더 경로 설정 및 폴더 없을 시 생성
            ChatLogFolderPath = Path.Combine(@"C:\Users\Public\Documents", user_id);
            if (!Directory.Exists(ChatLogFolderPath))
            {
                Directory.CreateDirectory(ChatLogFolderPath);
            }
            string date = DateTime.Now.ToString("yyMMdd"); // 현재 날짜 불러오기
            ChatLogFilePath = Path.Combine(ChatLogFolderPath, $"chatlog_{date}.txt"); // 채팅 로그 파일 경로 설정
            ConnectToChatServer(); // 자동으로 서버에 연결
        }

        private void Temp_FormClosed(object sender, FormClosedEventArgs e) // 폼이 닫힐 시 
        {
            File.WriteAllText(ChatLogFilePath, ChatTextBox.Text); // 채팅 로그를 파일에 저장
            client.Close();
            this.Owner.Close();
        }

        private void ConnectToChatServer() // 서버 연결 함수
        {
            try
            {
                // 서버에 연결
                client = new TcpClient("127.0.0.1", 13002);
                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);

                writer.WriteLine(user_name); // 유저 이름을 채팅 서버로 보냄
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

        private void SendButton_Click(object sender, EventArgs e) // Send 버튼 클릭 시
        {
            if (client != null && client.Connected) // 서버와 연결된 상태일 경우
            {
                byte[] buffer1 = Encoding.UTF8.GetBytes(user_name + ": " + MessageTextBox.Text + Environment.NewLine);
                stream.Write(buffer1, 0, buffer1.Length); // 이름 포함 메시지를 전달
                byte[] buffer2 = Encoding.UTF8.GetBytes(textBox_Whisper.Text + Environment.NewLine);
                stream.Write(buffer2, 0, buffer2.Length); // 귓속말 사용자도 전달, 없어도 보냄
                MessageTextBox.Clear();
            }
        }

        private void ReceiveMessages() // 서버로 부터 메시지를 받는 함수
        {
            byte[] buffer = new byte[1024]; // 메시지 버퍼 설정
            while (client != null && client.Connected)
            {
                try
                {
                    if (stream == null)
                        stream = client.GetStream();

                    while (stream.DataAvailable)
                    {
                        int bytesRead = stream.Read(buffer, 0, buffer.Length); // 서버 메시지 읽음
                        if (bytesRead > 0)
                        {
                            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                            AppendMessage(message); // 메시지를 채팅창에 표시
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

        private void AppendMessage(string message) // 채팅창에 메시지 표시 함수
        {
            if (ChatTextBox.InvokeRequired)
            {
                ChatTextBox.BeginInvoke(new MethodInvoker(() =>
                {
                    ChatTextBox.AppendText(message + Environment.NewLine); // 메시지 삽입
                }));
            }
            else
            {
                ChatTextBox.AppendText(message + Environment.NewLine); // 메시지 삽입
            }
        }

        private void LoadLogButton_Click(object sender, EventArgs e) // 채팅 로그 불러오는 버튼
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) // 파일 목록 열기
            {
                openFileDialog.InitialDirectory = ChatLogFolderPath;
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) //채팅 로그를 새 메시지 박스에 띄움
                {
                    string filePath = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(filePath);
                    MessageBox.Show(fileContent, "Chat Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
