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
        public Form1()
        {
            InitializeComponent();
            InitializeBotConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();

            DateTime today = DateTime.Now;
            metroLabel1.Text = string.Format("{0:F}", today);
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
