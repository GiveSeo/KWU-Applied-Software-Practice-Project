using Myclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class TeamAddForm : Form
    {
        Temp owner;
        TcpClient client;
        NetworkStream stream;
        User cur_user;
        List<User> users;
        List<Team> teams;
        public TeamAddForm(Temp t, TcpClient c, NetworkStream s, User u, List<User> us, List<Team> ts)
        {
            InitializeComponent();
            owner = t;
            client = c;
            stream = s;
            cur_user = u;
            users = us;
            teams = ts;
        }

        private void TeamAddForm_Load(object sender, EventArgs e)
        {
            foreach (User u in users)
            {
                if (u != cur_user)
                    checkedListBox1.Items.Add(u);
            }
        }

        private void make_btn_Click(object sender, EventArgs e)
        {
            Team new_team = new Team(teams.Count, cur_user, textBox1.Text);
            new_team.AddPeople(checkedListBox1.CheckedItems.Count);
            teams.Add(new_team);
            foreach (User u in checkedListBox1.CheckedItems)
                u.AddTeamId(new_team.GetID());
            owner.UpdateTeams(teams);
            owner.UpdateUserTeamId(new_team.GetID());
            owner.UpdateList();
            new_team.type = PacketType.ADDTEAM;
            byte[] buffer = Packet.Serialize(new_team);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            MessageBox.Show("팀 생성 완료");
            this.Close();
        }
    }
}
