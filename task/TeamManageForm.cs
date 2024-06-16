using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            if (txtGoal.Equals(string.Empty) || txtTeamId.Equals(string.Empty))
                return;
            ListViewItem lsvitem = new ListViewItem(txtGoal.Text);
            lsvitem.SubItems.Add(datePicker.Value.ToString("yyyy-MM-dd"));
            lsvGoal.Items.Add(lsvitem);
            datePicker.Value = DateTime.Now;
            txtGoal.Text = string.Empty;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(lsvGoal.Items==null) 
                return;
            Team s = null;
            foreach(Team team in teams)
            {
                if(team.GetID().ToString()==txtTeamId.Text)
                    s = team;
            }
            if (s == null)
            {
                MessageBox.Show("해당 id를 가진 Team이 존재하지 않습니다.");
                return;
            }
            foreach (ListViewItem k in lsvGoal.Items)
            {
                s.AddGoal(new Tuple<string, DateTime>(k.SubItems[0].Text, DateTime.ParseExact(k.SubItems[1].Text, "yyyy-MM-dd", CultureInfo.InvariantCulture)));
                s.AddGoal_Achieve(new Tuple<string, bool>(k.SubItems[0].Text, false));
            }
            DataPassed?.Invoke(s);
            this.Close();
        }
    }
}
