using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class TeamCreateForm : MetroFramework.Forms.MetroForm
    {
        public delegate void DataPassedHandler(int teamid, List<int> teamMemId);
        public event DataPassedHandler DataPassed;
        List<int> teamMemId = new List<int>();
        public TeamCreateForm()
        {
            InitializeComponent();
            lsvMemId.View = View.Details;
            lsvMemId.Columns.Add("UserId",300);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int teamid = Int32.Parse(txtTeamId.Text);
            foreach(ListViewItem s in lsvMemId.Items) 
            {
                teamMemId.Add(Int32.Parse(s.SubItems[0].Text));
            }
            DataPassed?.Invoke(Int32.Parse(txtTeamId.Text), teamMemId);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem s = new ListViewItem(txtMemId.Text);
            txtMemId.Text = "";
            lsvMemId.Items.Add(s);
        }
    }
}
