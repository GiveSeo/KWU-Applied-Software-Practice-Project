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
using MetroFramework.Controls;
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
        private string[] messages;
        int messageindex;
        TcpClient client;
        private NetworkStream m_networkstream;
        User cur_user;
        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];
        List<Team> teams = new List<Team>();
        List<User> users = new List<User>();
        private int selectmonth = 7;
        private int selectyear = 2024;
        private int specificDay = 25;
        private string ChatLogFolderPath; // 채팅 로그 폴더 경로
        private string ChatLogFilePath; // 채팅 로그 파일 경로
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
            label9.Text = messages[6];
            Thread readThread = new Thread(new ThreadStart(ReadData));
            ChatLogFolderPath = Path.Combine(@"C:\Users\Public\Documents", cur_user.GetId());
            if (!Directory.Exists(ChatLogFolderPath))
            {
                Directory.CreateDirectory(ChatLogFolderPath);
            }
            string date = DateTime.Now.ToString("yyMMdd"); // 현재 날짜 불러오기
            ChatLogFilePath = Path.Combine(ChatLogFolderPath, $"chatlog{date}.txt"); // 채팅 로그 파일 경로 설정
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
                        if(p.type ==PacketType.CHAT_EVERY||p.type == PacketType.CHAT_WISPHER||p.type == PacketType.CHAT_TEAM) // 팀 채팅 패킷 추가
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
            label.Text = string.Format("{0:F}", today);
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

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                flowLayoutPanel1.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
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

            if (month > 12)
            {
                month = 1;
                year++;
            }


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

            for (int i = 1; i <= days; i++)
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
                    foreach(Tuple<string,bool> l in t.GetGoals_Achieve())
                    {
                        if(l.Item1 == s.Item1)
                        {
                            ListViewItem s2 = new ListViewItem(t.GetID().ToString());
                            s2.SubItems.Add(s.Item1);
                            if (l.Item2)
                                s2.SubItems.Add("0");
                            else
                                s2.SubItems.Add("X");
                            Goallsv.Items.Add(s2);
                        }
                    }
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
            TeamCreateForm tcf = new TeamCreateForm(teams,cur_user);
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
                {
                    del.GetGoals().RemoveAt(i);
                    del.GetGoals_Achieve().RemoveAt(i);
                }
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
            Chat c = new Chat(cur_user, "", txbmsg.Text, -1);
            c.type= PacketType.CHAT_EVERY;
            Packet.Serialize(c).CopyTo(this.sendBuffer, 0);
            this.Send();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.m_networkstream = this.client.GetStream();
            Packet s = new Packet();
            s.type = PacketType.LOGOUT;
            Packet.Serialize(s).CopyTo(this.sendBuffer, 0);
            this.Send();
            File.AppendAllText(ChatLogFilePath, textBoxLog.Text); // 채팅 로그를 파일에 저장
        }
        private void LoadLogButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) // 파일 목록 열기
            {
                openFileDialog.InitialDirectory = ChatLogFolderPath;
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) //채팅 로그를 새 메시지 박스에 띄움
                {
                    string filePath = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(filePath);
                    MessageBox.Show(fileContent, "Chat Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void Whispher_Click(object sender, EventArgs e)
        {
            Chat c = new Chat(cur_user, txb_whis.Text, txbmsg.Text, -1);
            c.type = PacketType.CHAT_WISPHER;
            Packet.Serialize(c).CopyTo(this.sendBuffer, 0);
            this.Send();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            messageindex = (messageindex + 1) % messages.Length;

            label9.Text = messages[messageindex];
        }

        private void Goallsv_Click(object sender, EventArgs e)
        {
            foreach(Team a in teams)
            {
                foreach(Tuple<string, DateTime> s in a.GetGoals())
                {
                    if(Goallsv.FocusedItem.SubItems[1].Text == s.Item1)
                    {
                        DateTime today = DateTime.Now;

                        label.Text = string.Format("{0:F}", today);

                        selectyear = s.Item2.Year;
                        selectmonth = s.Item2.Month;
                        specificDay = s.Item2.Day;

                        if (selectmonth == today.Month && selectyear == today.Year && specificDay == today.Day)
                        {
                            MessageBox.Show("오늘은 프로젝트 데드라인입니다!!");
                        }

                        DateTime targetDate = new DateTime(selectyear, selectmonth, specificDay);

                        // 현재 날짜 가져오기
                        DateTime currentDate = DateTime.Now;

                        // 남은 일수 계산
                        int daysLeft = (targetDate - currentDate).Days + 1;

                        // 라벨에 남은 일수 표시
                        metroLabel5.Text = $"데드라인까지 {daysLeft}일 남았습니다.";
                    }

                }
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
             
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (Goallsv.FocusedItem == null)
                return;
            int change_team_id = Int32.Parse(Goallsv.FocusedItem.SubItems[0].Text);
            string chage_goal = Goallsv.FocusedItem.SubItems[1].Text;
            Team cha = null;
            foreach (Team t in teams)
            {
                if (t.GetID() == change_team_id)
                    cha = t;
            }
            cha.ChangeAchieve(chage_goal);
            this.m_networkstream = this.client.GetStream();
            cha.type = PacketType.EDIT;
            Packet.Serialize(cha).CopyTo(this.sendBuffer, 0);
            this.Send();
            MessageBox.Show("목표 달성 여부 변경");
            this.m_networkstream.Flush();
            list_view_set();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            label.Text = string.Format("{0:F}", today);
        }

        private void Team_Click(object sender, EventArgs e) // 팀 채팅 버튼 추가
        {
            if(!int.TryParse(txb_team.Text, out _))
            {
                MessageBox.Show("올바른 팀 아이디(숫자)를 입력해주세요!");
                return;
            } 
            Chat c = new Chat(cur_user, "", txbmsg.Text, Convert.ToInt32(txb_team.Text));
            c.type = PacketType.CHAT_TEAM;
            Packet.Serialize(c).CopyTo(this.sendBuffer, 0);
            this.Send();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            month--;

            if (month < 1)
            {
                month = 12;
                year--;
            }

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

            for (int i = 1; i <= days; i++)
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
    }
}
