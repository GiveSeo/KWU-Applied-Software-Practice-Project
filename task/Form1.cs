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
using Microsoft.Bot.Connector.DirectLine;


namespace task
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int month, year;
        private DirectLineClient _directLineClient;
        private string _conversationId;
        private string _watermark;
        private string[] messages;
        private int messageindex;

        //테스트를 위해 임의 설정한 날짜(프로젝트 합칠 때 이 변수들에 목표 설정할 때 입력했던 날짜 값이 들어갈 수 있도록 하면 됨)
        private int selectmonth=7; 
        private int selectyear=2024;
        private int specificDay=25;

        public Form1()
        {
            InitializeComponent();
            InitializeBotConnection();

            messages = new string[]
            {
                "내 인생이 성공한 것은 어느 때라도 반드시 15분 전에 도착한 덕분이다.",
                "변명 중에서도 가장 어리석고 못난 변명은 \"시간이 없어서\"라는 변명이다.",
                "승자는 시간을 관리하며 살고, 패자는 시간에 끌려 산다.",
                "세월은 모두에게 공평하게 주어진 자본금이다. 이 자본을 잘 이용한 사람에겐 승리가 있다.",
                "가장 중요한 때는 현재다. 왜냐하면, 사람이 자신을 통제할 수 있는 것이 현재이기 때문이다.",
                "시간을 단축시키는 것은 활동이요, 시간을 견디지 못하게 하는 것은 안일함이다.",
                "제일 많이 바쁜 사람이 제일 많은 시간을 가진다."
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();

            timer1.Enabled = true;
            timer2.Enabled = true;
            label9.Text = messages[6];
            DateTime today = DateTime.Now;

            metroLabel1.Text = string.Format("{0:F}", today);

           
            if(selectmonth == today.Month && selectyear == today.Year && specificDay == today.Day)
            {
                MessageBox.Show("오늘은 프로젝트 데드라인입니다!!");
            }

            DateTime targetDate = new DateTime(selectyear, selectmonth, specificDay);

            // 현재 날짜 가져오기
            DateTime currentDate = DateTime.Now;

            // 남은 일수 계산
            int daysLeft = (targetDate - currentDate).Days+1;

            // 라벨에 남은 일수 표시
            metroLabel5.Text = $"데드라인까지 {daysLeft}일 남았습니다.";
        }

        private void InitializeBotConnection()
        {
            string directLineSecret = "ggejVBnjLpc.Joq2vKXTjZzBL4vUfoZZiFYc5P4BlWGqu9-2lStnnLg";
            _directLineClient = new DirectLineClient(directLineSecret);
            StartConversation();
        }

        private async void StartConversation()
        {
            var conversation = await _directLineClient.Conversations.StartConversationAsync();
            _conversationId = conversation.ConversationId;
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

                if (i == specificDay && month == selectmonth && year == selectyear)
                {
                    ucday.SetColor(Color.Red);
                }

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

                if (i == specificDay && month == selectmonth && year == selectyear)
                {
                    ucday.SetColor(Color.Red);
                }

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

                if (i == specificDay && month == selectmonth && year == selectyear)
                {
                    ucday.SetColor(Color.Red);
                }

                flowLayoutPanel1.Controls.Add(ucday);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            string userInput = textBoxInput.Text;
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                textBoxOutput.AppendText("\n");
                textBoxOutput.AppendText("User: " + userInput + Environment.NewLine);
                await SendMessageToBot(userInput);
                textBoxInput.Clear();
            }
        }

        private async Task SendMessageToBot(string message)
        {
            if (string.IsNullOrWhiteSpace(message)) return;

            var activity = new Activity
            {
                From = new ChannelAccount("User"),
                Text = message,
                Type = ActivityTypes.Message
            };

            await _directLineClient.Conversations.PostActivityAsync(_conversationId, activity);

            await ReceiveMessagesFromBot();
        }

        private async Task ReceiveMessagesFromBot()
        {
            var activitySet = await _directLineClient.Conversations.GetActivitiesAsync(_conversationId, _watermark);
            var activities = activitySet.Activities;
            _watermark = activitySet.Watermark;

            foreach (var activity in activities.Where(a => a.From.Id != "User"))
            {
                textBoxOutput.AppendText("Bot: " + activity.Text + Environment.NewLine);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            metroLabel1.Text = string.Format("{0:F}", today);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            messageindex = (messageindex + 1) % messages.Length;

            label9.Text = messages[messageindex];
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
