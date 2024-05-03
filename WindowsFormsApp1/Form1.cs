using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private NetworkStream m_networkstream;
        private TcpListener m_listener;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bClientOn = false;

        private Thread m_thread;

        public Member m_member;
        public Project m_project;

        public void RUN()
        {
            this.m_listener = new TcpListener(7777);
            this.m_listener.Start();

            if (!this.m_bClientOn)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.txt_server_state.AppendText("클라이언트 접속 대기중\n");
                }));
            }
            
            TcpClient client = this.m_listener.AcceptTcpClient();

            if (client.Connected)
            {
                this.m_bClientOn = true;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.txt_server_state.AppendText("클라이언트 접속");
                }));
                m_networkstream = client.GetStream();
            }

            int nRead = 0;
            while (this.m_bClientOn)
            {
                try
                {
                    nRead = 0;
                    nRead = this.m_networkstream.Read(readBuffer, 0, 1024 * 4);
                }
                catch
                {
                    this.m_bClientOn = false;
                    this.m_networkstream = null;
                }

                Packet packet = (Packet)Packet.Desserialize(this.readBuffer);

                switch((int)packet.Type)
                {
                    case (int)PacketType.멤버:
                        {
                            this.m_member = (Member)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                this.txt_server_state.AppendText("멤버 패킷 전송 성공" + "멤버 이름" + this.m_member.m.id + "멤버 비밀번호" + this.m_member.m.password);
                            }));
                            break;
                        }
                    case (int)PacketType.프로젝트:
                        this.m_project = (Project)Packet.Desserialize(this.readBuffer);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            this.txt_server_state.AppendText("프로젝트 패킷 전송 성공");
                            foreach (Projects p in this.m_project.m)
                            {
                                this.txt_server_state.AppendText("프로젝트 아이디" + p.ProjectId);
                            }
                        }));
                        break;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.m_thread = new Thread(new ThreadStart(RUN));
            this.m_thread.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_listener.Stop();
            this.m_networkstream.Close();
            this.m_thread.Abort();
        }
    }
}
