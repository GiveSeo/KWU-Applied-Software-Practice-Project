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

namespace Client
{
    public partial class SignUp_form : Form
    {
        TcpClient client;
        NetworkStream stream;
        StreamWriter writer;
        public SignUp_form()
        {
            InitializeComponent();
            client = null;
            stream = null;
            writer = null;
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            client = new TcpClient("127.0.0.1", 13000);
            stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream);
            string s = name_textbox.Text + ',' + id_textbox.Text + ',' + pw_textbox.Text;
            writer.WriteLine(s);
            writer.Close();
            stream.Close();
            client.Close();
            MessageBox.Show("success");
            this.Close();
        }
    }
}
