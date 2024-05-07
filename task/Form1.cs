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


namespace task
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int month, year;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();

            DateTime today = DateTime.Now;
            metroLabel1.Text = string.Format("{0:F}", today);
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for(int i = 1; i<dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                flowLayoutPanel1.Controls.Add(ucblank);
            }

            for(int i = 1;i<days;i++)
            {
                UserControlday ucday = new UserControlday();
                ucday.days(i);
                flowLayoutPanel1.Controls.Add(ucday);
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();

            month++;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;


            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                flowLayoutPanel1.Controls.Add(ucblank);
            }

            for (int i = 1; i < days; i++)
            {
                UserControlday ucday = new UserControlday();
                ucday.days(i);
                flowLayoutPanel1.Controls.Add(ucday);
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            month--;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;


            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                flowLayoutPanel1.Controls.Add(ucblank);
            }

            for (int i = 1; i < days; i++)
            {
                UserControlday ucday = new UserControlday();
                ucday.days(i);
                flowLayoutPanel1.Controls.Add(ucday);
            }
        }
    }
}
