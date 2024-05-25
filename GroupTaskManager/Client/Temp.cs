﻿using System;
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
        NetworkStream stream;
        User cur_user;
        List<User> users;
        List<Team> teams;
        public Temp(TcpClient t, NetworkStream s, User u, List<User> ul, List<Team> tl)
        {
            InitializeComponent();
            client = t;
            stream = s;
            cur_user = u;
            users = ul.ToList<User>();
            teams = tl.ToList<Team>();
        }

        private void Temp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Close();
        }

        private void Temp_Load(object sender, EventArgs e)
        {
            List<int> teamids = cur_user.GetTeamIds();
            foreach (int i in teamids)
            {
                foreach (Team t in teams)
                {
                    if(t.GetID() == i)
                        team_listbox.Items.Add(i);
                }
            }
            name_label.Text += cur_user.GetName();
        }

        private void teamadd_btn_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Packet p = new Packet(PacketType.LOGOUT);
            byte[] writebuffer = Packet.Serialize(p);
            stream.Write(writebuffer, 0, writebuffer.Length);
            byte[] readbuffer = new byte[Packet.length];
            stream.Read(readbuffer, 0, readbuffer.Length);
            p=(Packet)Packet.Deserialize(readbuffer);
            if (p.type == PacketType.OK)
            {
                stream.Close();
                client.Close();
                this.Close();
            }
        }
    }
}
