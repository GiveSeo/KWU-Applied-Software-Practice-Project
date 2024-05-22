using MetroFramework.Forms;
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
    public partial class TeamManageForm : MetroForm
    {
        public delegate void DataPassedHandler(int teamid, List<string> goals);
        public event DataPassedHandler onGoalDataPassed;
        List<string> goals = new List<string>();
        public TeamManageForm()
        {
            InitializeComponent();
        }

        private void TeamManageForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem s = new ListViewItem(txtGoal.Text);
            goals.Add(txtGoal.Text);
            txtGoal.Text = "";
            lsvGoal.Items.Add(s);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            onGoalDataPassed?.Invoke(Int32.Parse(txbTeamId.Text), goals);
            this.Close();
        }
    }
}
