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

namespace Client
{
    public partial class Login_form : Form
    {
        TcpClient client;
        NetworkStream stream;
        StreamReader reader;
        StreamWriter writer;
        public Login_form()
        {
            InitializeComponent();
            client = null;
            stream = null;
            reader = null;
            writer = null;
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            SignUp_form s = new SignUp_form();
            s.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            client = new TcpClient("127.0.0.1", 13001);
            stream = client.GetStream();
            writer = new StreamWriter(stream);
            writer.WriteLine(id_textbox.Text + ',' + pw_textbox.Text);
            writer.Flush();
            reader = new StreamReader(stream);
            string s = reader.ReadLine();
            if (s.Equals("ss"))
            {
                string name = reader.ReadLine(); // 로그인 성공 시 서버에서 이름 받아옴 
                Temp t = new Temp(client, id_textbox.Text, pw_textbox.Text, name);
                t.Show(); // 채팅 폼 시작
                this.Visible = false;
            }
            else
                MessageBox.Show("login failed");
            reader.Close();
            stream.Close();
        }
    }
}
