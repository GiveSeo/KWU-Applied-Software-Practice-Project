using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using Myclass;


namespace ServerApp
{
    public partial class Form1 : Form
    {
        private NetworkStream m_networkstream;
        private TcpListener m_listener;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bClientOn = false;

        private Thread m_thread;

        public Team m_team;
        public void RUN()
        {
            this.m_listener = new TcpListener(7777);
            this.m_listener.Start();

            if (!this.m_bClientOn)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.textBox1.AppendText("클라이언트 접속 대기 중\n");
                }));
            }

            TcpClient client = this.m_listener.AcceptTcpClient();

            if (client.Connected)
            {
                this.m_bClientOn = true;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.textBox1.AppendText("클라이언트 접속\n");
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

                Packet packet = (Packet)Packet.Deserialize(this.readBuffer);

                this.m_team = (Team)Packet.Deserialize(this.readBuffer);
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.textBox1.AppendText("데이터 전송 성공");
                    if(m_team.instruction == 1)
                    {
                        ListViewItem s = new ListViewItem(m_team.id.ToString());
                        Teamlv.Items.Add(s);
                    }
                    else if(m_team.instruction == 3) {
                        foreach(ListViewItem It in Teamlv.Items)
                        {
                            if(m_team.id == Int32.Parse(It.SubItems[0].Text))
                            {
                                Teamlv.Items.Remove(It);
                            }
                        }
                    }
                }));
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Teamlv.View = View.Details;
            Teamlv.Columns.Add("Teamid", 100);
            this.m_thread = new Thread(new ThreadStart(RUN));
            this.m_thread.Start();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
