using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using Myclass;

namespace task
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        TcpClient client = null;
        NetworkStream stream;

        public Form2()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (id_textbox.Text.Equals(string.Empty)||pw_textbox.Text.Equals(string.Empty))
            {
                MessageBox.Show("빈 칸이 있습니다.");
                return;
            }

            // metroButton2_Click
            client = new TcpClient("127.0.0.1", 13000);
            stream = client.GetStream();
            User u = new User(id_textbox.Text, pw_textbox.Text);
            u.type = PacketType.LOGIN;
            byte[] writebuffer = Packet.Serialize(u);
            stream.Write(writebuffer, 0, writebuffer.Length);
            stream.Flush();
            byte[] readbuffer = new byte[Packet.length];
            stream.Read(readbuffer, 0, readbuffer.Length);
            User uu = (User)Packet.Deserialize(readbuffer);
            if (uu.type != PacketType.OK)
            {
                MessageBox.Show("로그인 실패");
                stream.Close();
                client.Close();
                return;
            }
            else
            {
                stream.Read(readbuffer, 0, readbuffer.Length);
                List<User> ul = (List<User>)Packet.Deserialize(readbuffer);
                writebuffer = Packet.Serialize(new Packet(PacketType.OK));
                stream.Write(writebuffer, 0, writebuffer.Length);
                stream.Flush();
                stream.Read(readbuffer, 0, readbuffer.Length);
                List<Team> tl = (List<Team>)Packet.Deserialize(readbuffer);
                Form1 t = new Form1(client, stream, uu, ul, tl);
                t.Owner = this;
                this.Visible = false;
                t.Show();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (id_signup.Text.Equals(string.Empty) || name_signup.Text.Equals(string.Empty) || password_signup.Text.Equals(string.Empty))
            {
                MessageBox.Show("빈 칸이 있습니다.");
                return;
            }
            if (client == null)
                client = new TcpClient("127.0.0.1", 13000);
            stream = client.GetStream();
            User u = new User(name_signup.Text, id_signup.Text, password_signup.Text);//User u = new User(name_textbox.Text, id_textbox.Text, pw_textbox.Text);
            u.type = PacketType.SIGNUP;
            byte[] writebuffer = Packet.Serialize(u);
            stream.Write(writebuffer, 0, writebuffer.Length);
            stream.Flush();
            byte[] readbuffer = new byte[Packet.length];
            stream.Read(readbuffer, 0, readbuffer.Length);
            Packet p = (Packet)Packet.Deserialize(readbuffer);
            if (p.type != PacketType.OK)
                MessageBox.Show("회원가입 실패");
            else
            {
                MessageBox.Show("회원가입 성공");id_signup.Text= string.Empty;name_signup.Text = string.Empty;password_signup.Text = string.Empty;
            }
        }
    }
}
