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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Myclass;

namespace Client
{
    public partial class Login_form : Form
    {
        TcpClient client;
        NetworkStream stream;
        public Login_form()
        {
            InitializeComponent();
            client = null;
            stream = null;
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            SignUp_form s = new SignUp_form();
            s.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            client = new TcpClient("127.0.0.1", 13000);
            stream = client.GetStream();
            User u = new User(string.Empty, id_textbox.Text, pw_textbox.Text);
            u.type = PacketType.LOGIN;
            byte[] writebuffer = Packet.Serialize(u);
            stream.Write(writebuffer, 0, writebuffer.Length);
            stream.Flush();
            byte[] readbuffer = new byte[Packet.length];
            stream.Read(readbuffer, 0, readbuffer.Length);
            User uu = (User)Packet.Deserialize(readbuffer);
            if (uu.type != PacketType.OK)
                MessageBox.Show("로그인 실패");
            else
            {
                Temp t = new Temp(client, uu);
                t.Owner = this;
                t.Show();
                this.Visible = false;
            }
            stream.Close();
        }
    }
}
