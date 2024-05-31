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
    public partial class TeamManageForm : MetroFramework.Forms.MetroForm
    {
        List<Team> teams;
        public delegate void DataPassedHandler(Team t);
        public event DataPassedHandler DataPassed;
        public TeamManageForm(List<Team> t)
        {
            teams = t;
            InitializeComponent();
            lsvGoal.View = View.Details;
            lsvGoal.Columns.Add("Goal", 100);
            lsvGoal.Columns.Add("Dead Line", 400);
        }

        private void TeamManageFrom_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lsvitem = new ListViewItem(txtGoal.Text);
            lsvitem.SubItems.Add(datePicker.Value.ToString("yyyy-MM-dd"));
            lsvGoal.Items.Add(lsvitem);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Team s = null;
            foreach(Team team in teams)
            {
                if(team.GetID().ToString()==txtTeamId.Text)
                    s = team;
            }
            if (s == null)
            {
                MessageBox.Show("해당 id를 가진 Team이 존재하지 않습니다.");
                this.Close();
            }
            foreach (ListViewItem k in lsvGoal.Items)
            {
                s.AddGoal(k.SubItems[0].Text);
            }
            DataPassed?.Invoke(s);
            this.Close();
        }
    }
}
