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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTeamCreate_Click(object sender, EventArgs e)
        {
            TeamCreateForm tcf = new TeamCreateForm();
            tcf.Show();
        }

        private void btnTeamManage_Click(object sender, EventArgs e)
        {

        }

        private void btnTeamDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
