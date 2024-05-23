using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;
using System.Windows.Forms.VisualStyles;
using Myclass;

namespace task
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private NetworkStream m_networtstream;
        private TcpClient m_client;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bConnect = false;
        public Team m_loginClass;

        List<Team> teams = new List<Team>();
        public Form1()
        {
            InitializeComponent();
        }
        private void OnDataPassed(int teamid , List<int> teamMemId)
        {
            ListViewItem s = new ListViewItem(teamid.ToString());
            s.SubItems.Add(teamMemId.Count.ToString());
            TeamListView.Items.Add(s);
            Team new_team = new Team(teamid, null, null);
            new_team.instruction = 1;
            teams.Add(new_team);
            this.m_client  = new TcpClient();
            try
            {
                    this.m_client.Connect("127.0.0.1", 7777);
            }
            catch
            {
                MessageBox.Show("서버와의 연결이 불안정 합니다.");
                return;
            }
            this.m_bConnect = true;
            this.m_networtstream = this.m_client.GetStream();
            new_team.type = (int)PacketType.NOTHING;
            Packet.Serialize(new_team).CopyTo(this.sendBuffer, 0);
            this.Send();
        }
        private void onGoalDataPassed(int teamid, List<string> goal)
        {
            Team new_team = null;
            foreach(Team s in teams)
            {
                if(teamid == s.id)
                {
                    new_team = s;
                    foreach(string str in goal)
                    {
                        s.goals.Add(str);
                        ListViewItem k = new ListViewItem(teamid.ToString());
                        k.SubItems.Add(str);
                        GoalListView.Items.Add(k);
                    }
                }
            }
            if(new_team!=null)
                new_team.instruction = 2;//edit
            this.m_networtstream = this.m_client.GetStream();
            new_team.type = (int)PacketType.NOTHING;
            Packet.Serialize(new_team).CopyTo(this.sendBuffer, 0);
            this.Send();

        }
        public void Send()
        {
            this.m_networtstream.Write(this.sendBuffer, 0,this.sendBuffer.Length);
            this.m_networtstream.Flush();

            for(int i = 0; i < 1024 * 4; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTeamCreate_Click(object sender, EventArgs e)
        {
            TeamCreateForm tcf = new TeamCreateForm();
            tcf.DataPassed += new TeamCreateForm.DataPassedHandler(OnDataPassed);
            tcf.Show();
        }

        private void btnTeamManage_Click(object sender, EventArgs e)
        {
            TeamManageForm tmf = new TeamManageForm();
            tmf.onGoalDataPassed += new TeamManageForm.DataPassedHandler(onGoalDataPassed);
            tmf.Show();
        }

        private void btnTeamDelete_Click(object sender, EventArgs e)
        {
            int del_team_id = Int32.Parse(TeamListView.FocusedItem.SubItems[0].Text);
            TeamListView.FocusedItem.Remove();
            Team new_team = new Team(del_team_id, null, null);
            new_team.instruction = 3;
            this.m_networtstream = this.m_client.GetStream();
            new_team.type = (int)PacketType.NOTHING;
            Packet.Serialize(new_team).CopyTo(this.sendBuffer, 0);
            this.Send();
        }
    }
}
