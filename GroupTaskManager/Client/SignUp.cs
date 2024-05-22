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
using Myclass;

namespace Client
{
    public partial class SignUp_form : Form
    {
        public SignUp_form()
        {
            InitializeComponent();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient("127.0.0.1", 13000);
            NetworkStream stream = client.GetStream();
            User u = new User(name_textbox.Text, id_textbox.Text, pw_textbox.Text);
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
                MessageBox.Show("회원가입 성공");
            stream.Close();
            client.Close();
            this.Close();
        }
    }
}
