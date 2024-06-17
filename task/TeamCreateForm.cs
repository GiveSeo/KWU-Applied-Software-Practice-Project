using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Myclass;

namespace task
{
    public partial class TeamCreateForm : MetroFramework.Forms.MetroForm
    {
        public User admin;
        public delegate void DataPassedHandler(Team t);
        public event DataPassedHandler DataPassed;
        List<string> teamMemId = new List<string>();
        List<Team> teams = new List<Team>();
        List<User> users = new List<User>();
        public TeamCreateForm(List<Team> t,List<User> usrs, User u)
        {
            admin = u;
            teams = t;
            users = usrs;
            InitializeComponent();
        }

        private void TeamCreateForm_Load(object sender, EventArgs e)
        {
            lsvMemId.View = View.Details;
            lsvMemId.Columns.Add("UserId", 300);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMemId.Text.Equals(string.Empty) || txtPname.Text.Equals(string.Empty)|| txtMemId.Text.Equals(string.Empty))
            {
                MessageBox.Show("빈 칸이 존재합니다.");
                return;
            }
            foreach(ListViewItem k in lsvMemId.Items)
            {
                if (k.SubItems[0].Text == txtMemId.Text)
                {
                    MessageBox.Show("이미 같은 이름을 가진 조원이 존재합니다.");
                    return;
                }
            }
            if (admin.GetId() == txtMemId.Text)
            {
                MessageBox.Show("본인은 멤버로 포함할 수 없습니다.");
                return;
            }
            bool is_exist_user = false;
            foreach(User u in users)
            {
                if(txtMemId.Text == u.GetId())
                {
                    is_exist_user = true;
                }
            }
            if (!is_exist_user)
            {
                MessageBox.Show("해당 id를 가진 USER가 존재하지 않습니다.");
                return;
            }
            ListViewItem s = new ListViewItem(txtMemId.Text);
            txtMemId.Text = string.Empty;
            lsvMemId.Items.Add(s);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Team is_already_exist = null;
            foreach(Team j in teams)
            {
                if (Int32.Parse(txtTeamId.Text) == j.GetID())
                    is_already_exist = j;
            }
            if (is_already_exist != null)
            {
                MessageBox.Show("해당 id를 가진 Team이 이미 존재합니다. 다른 아이디를 시도해 주세요");
                return;
            }
            int teamid = Int32.Parse(txtTeamId.Text);
            foreach (ListViewItem s in lsvMemId.Items)
            {
                teamMemId.Add((s.SubItems[0].Text));
            }
            Team t = new Team(Int32.Parse(txtTeamId.Text), admin, txtPname.Text, teamMemId); //new team Create
            DataPassed?.Invoke(t);
            this.Close();
        }

        private void lsvMemId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
