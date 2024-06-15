using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClassLibrary1;
using Microsoft.Bot.Connector.DirectLine;
using Myclass;


namespace task
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int month, year;
        private DirectLineClient _directLineClient;
        private string _conversationId;
        private string _watermark;
        TcpClient client;
        private NetworkStream m_networkstream;
        User cur_user;
        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];
        List<Team> teams = new List<Team>();
        List<User> users = new List<User>();
        public Form1(TcpClient t,NetworkStream m_networkstream, User cur_user, List<User> users,List<Team> teams)
        {
            InitializeComponent();
            InitializeBotConnection();
            client = t;
            this.m_networkstream = m_networkstream;
            this.cur_user = cur_user;
            this.users = users;
            this.teams = teams;
            list_view_set();
            Thread readThread = new Thread(new ThreadStart(ReadData));
            readThread.IsBackground = true;
            readThread.Start();

        }
        private void ReadData()
        {
            int bytesRead;

            while (true)
            {
                try
                {
                    // 네트워크 스트림에서 데이터 읽기
                    bytesRead = m_networkstream.Read(readBuffer, 0, readBuffer.Length);
                    if (bytesRead > 0)
                    {
                        Packet p = (Packet)Packet.Deserialize(readBuffer);
                        if(p.type ==PacketType.CHAT_EVERY||p.type == PacketType.CHAT_WISPHER)
                        {
                            Chat c = (Chat)p;
                            string message = c.GetUser().GetName() + " : " + c.GetMessage();
                            AppendText(message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 예외 처리 (연결이 끊어지거나 오류 발생 시)
                    AppendText("Error: " + ex.Message);
                    break;
                }
            }
        }
        private void AppendText(string text)
        {
            if (textBoxLog.InvokeRequired)
            {
                textBoxLog.Invoke(new Action<string>(AppendText), text);
            }
            else
            {
                textBoxLog.AppendText(text + Environment.NewLine);
            }
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
        private void list_view_set()
        {
            Teamlsv.Items.Clear();
            Memlsv.Items.Clear();
            Goallsv.Items.Clear();

            foreach(Team t in teams) // teamlsv add
            {
                ListViewItem s = new ListViewItem(t.GetID().ToString());
                s.SubItems.Add(t.GetProject());
                s.SubItems.Add(t.GetPeople().ToString());
                Teamlsv.Items.Add(s);
            }
            foreach (Team t in teams)
            {
                foreach(Tuple<string,DateTime> s in t.GetGoals())// goallsv add
                {
                    ListViewItem s2 = new ListViewItem(t.GetID().ToString());
                    s2.SubItems.Add(s.Item1);
                    Goallsv.Items.Add(s2);
                }
            }
            foreach (Team t in teams)
            {
               foreach (string id in t.GetMemid())// goallsv add
               {
                    ListViewItem s = new ListViewItem(t.GetID().ToString());
                    s.SubItems.Add(id.ToString());
                    Memlsv.Items.Add(s);
               }
            }
        }
        private void btn_Manage_Click(object sender, EventArgs e)
        {
            TeamManageForm tmf = new TeamManageForm(teams);
            tmf.DataPassed += new TeamManageForm.DataPassedHandler(OnManageDataPassed);
            tmf.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Teamlsv.FocusedItem == null)
                return;
            int del_team_id = Int32.Parse(Teamlsv.FocusedItem.SubItems[0].Text);
            Team del=null;
            foreach(Team t in teams)
            {
                if (t.GetID() == del_team_id)
                    del = t;
            }
            this.m_networkstream = this.client.GetStream();
            del.type = PacketType.DELETE;
            Packet.Serialize(del).CopyTo(this.sendBuffer, 0);
            this.Send();
            MessageBox.Show("팀 삭제");
            this.m_networkstream.Flush();
            teams.Remove(del);
            list_view_set();
        }
        private void OnDataPassed(Team t)
        {
            teams.Add(t);
            list_view_set();

            this.m_networkstream = this.client.GetStream();
            t.type = PacketType.ADD;
            Packet.Serialize(t).CopyTo(this.sendBuffer, 0);
            this.Send();
            MessageBox.Show("팀 보내기");
            this.m_networkstream.Flush();
        }
        private void OnManageDataPassed(Team t)
        {
            list_view_set();
            this.m_networkstream = this.client.GetStream();
            t.type = PacketType.EDIT;
            Packet.Serialize(t).CopyTo(this.sendBuffer, 0);
            this.Send();
            MessageBox.Show("팀 수정 보내기");
            this.m_networkstream.Flush();
        }
        public void Send()
        {
            this.m_networkstream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkstream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            TeamCreateForm tcf = new TeamCreateForm(cur_user);
            tcf.DataPassed += new TeamCreateForm.DataPassedHandler(OnDataPassed);
            tcf.Show();
        }

        private void btnDeleteGoal_Click(object sender, EventArgs e)
        {
            if (Goallsv.FocusedItem == null)
                return;
            int del_team_id = Int32.Parse(Goallsv.FocusedItem.SubItems[0].Text);
            string del_goal = Goallsv.FocusedItem.SubItems[1].Text;
            Team del = null;
            foreach (Team t in teams)
            {
                if (t.GetID() == del_team_id)
                    del = t;
            }
            for(int i=del.GetGoals().Count - 1; i >= 0; i--)
            {
                if (del_goal == del.GetGoals()[i].Item1)
                    del.GetGoals().RemoveAt(i);
            }
            this.m_networkstream = this.client.GetStream();
            del.type = PacketType.EDIT;
            Packet.Serialize(del).CopyTo(this.sendBuffer, 0);
            this.Send();
            MessageBox.Show("목표 삭제");
            this.m_networkstream.Flush();
            list_view_set();
        }

        private void SendToEvery_Click(object sender, EventArgs e)
        {
            Chat c = new Chat(cur_user, 1, txbmsg.Text);
            c.type= PacketType.CHAT_EVERY;
            Packet.Serialize(c).CopyTo(this.sendBuffer, 0);
            this.Send();
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
