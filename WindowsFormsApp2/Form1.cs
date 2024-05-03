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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private NetworkStream m_networkstream;
        private TcpClient m_client;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bConnect = false;

        public Project m_project;
        public Member m_member;

        public void Send()
        {
            this.m_networkstream.Write(this.sendBuffer,0,this.sendBuffer.Length);
            this.m_networkstream.Flush();

            for(int i = 0; i < 1024 * 4; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.m_client = new TcpClient();
            try
            {
                this.m_client.Connect(this.txt_ip.Text, 7777);
            }
            catch
            {
                MessageBox.Show("접속 에러");
                return;
            }
            this.m_bConnect = true;
            this.m_networkstream = this.m_client.GetStream();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_client.Close();
            this.m_networkstream.Close();
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            if (!this.m_bConnect)
            {
                return;
            }
            Member mem = new Member();
            List<string> sr = new List<string>();
            sr.Add("1234");
            mem.m = new Members(txt_memberid.Text,txt_memberpw.Text,sr);
            mem.Type = (int)PacketType.멤버;

            Packet.Serialize(mem).CopyTo(this.sendBuffer, 0);
            this.Send();

        }

        private void btn_project_Click(object sender, EventArgs e)
        {
            if (!this.m_bConnect)
            {
                return;
            }
            Project pj = new Project(); 
            Projects pj1 = new Projects();
            pj1.ProjectId = txt_ProjectId1.Text;
            pj1.adminId = txt_adminId1.Text;
            Projects pj2 = new Projects();
            pj2.ProjectId = txt_ProjectId2.Text;
            pj2.adminId = txt_adminId2.Text;
            pj.m.Add(pj1);pj.m.Add(pj2);
            pj.Type = (int)PacketType.프로젝트;

            Packet.Serialize(pj).CopyTo(this.sendBuffer, 0);
            this.Send();
        }
    }
}
