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
using Myclass;

namespace Client
{
    
    public partial class Temp : Form
    {
        TcpClient client;
        User cur_user;
        public Temp(TcpClient t, User cur_user)
        {
            InitializeComponent();
            client = t;
            this.cur_user = cur_user;
        }

        private void Temp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Close();
        }
    }
}
