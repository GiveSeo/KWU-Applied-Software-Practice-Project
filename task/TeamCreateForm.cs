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
        public TeamCreateForm(User u)
        {
            admin = u;
            InitializeComponent();
        }

        private void TeamCreateForm_Load(object sender, EventArgs e)
        {
            lsvMemId.View = View.Details;
            lsvMemId.Columns.Add("UserId", 300);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem s = new ListViewItem(txtMemId.Text);
            txtMemId.Text = string.Empty;
            lsvMemId.Items.Add(s);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
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
