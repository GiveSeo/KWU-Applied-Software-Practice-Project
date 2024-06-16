namespace task
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteGoal = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.buttonSend = new MetroFramework.Controls.MetroButton();
            this.textBoxInput = new MetroFramework.Controls.MetroTextBox();
            this.textBoxOutput = new MetroFramework.Controls.MetroTextBox();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Memlsv = new MetroFramework.Controls.MetroListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.lbl = new System.Windows.Forms.Label();
            this.txb_whis = new System.Windows.Forms.TextBox();
            this.txbmsg = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Whispher = new MetroFramework.Controls.MetroButton();
            this.SendToEvery = new MetroFramework.Controls.MetroButton();
            this.textBoxLog = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Goallsv = new MetroFramework.Controls.MetroListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Teamlsv = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label = new MetroFramework.Controls.MetroLabel();
            this.btn_Delete = new MetroFramework.Controls.MetroTile();
            this.btn_Manage = new MetroFramework.Controls.MetroTile();
            this.btn_Create = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.label9);
            this.metroPanel1.Controls.Add(this.btnDeleteGoal);
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.Goallsv);
            this.metroPanel1.Controls.Add(this.Teamlsv);
            this.metroPanel1.Controls.Add(this.label);
            this.metroPanel1.Controls.Add(this.btn_Delete);
            this.metroPanel1.Controls.Add(this.btn_Manage);
            this.metroPanel1.Controls.Add(this.btn_Create);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1720, 970);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(991, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // btnDeleteGoal
            // 
            this.btnDeleteGoal.ActiveControl = null;
            this.btnDeleteGoal.Location = new System.Drawing.Point(421, 48);
            this.btnDeleteGoal.Name = "btnDeleteGoal";
            this.btnDeleteGoal.Size = new System.Drawing.Size(107, 45);
            this.btnDeleteGoal.TabIndex = 0;
            this.btnDeleteGoal.Text = "목표 제거";
            this.btnDeleteGoal.UseSelectable = true;
            this.btnDeleteGoal.Click += new System.EventHandler(this.btnDeleteGoal_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(424, 141);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1267, 799);
            this.metroTabControl1.TabIndex = 11;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.buttonSend);
            this.metroTabPage1.Controls.Add(this.textBoxInput);
            this.metroTabPage1.Controls.Add(this.textBoxOutput);
            this.metroTabPage1.Controls.Add(this.metroTile6);
            this.metroTabPage1.Controls.Add(this.metroTile7);
            this.metroTabPage1.Controls.Add(this.metroTile5);
            this.metroTabPage1.Controls.Add(this.metroTile4);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1259, 757);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "목표 관리";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(519, 461);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "metroButton1";
            this.buttonSend.UseSelectable = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxInput
            // 
            // 
            // 
            // 
            this.textBoxInput.CustomButton.Image = null;
            this.textBoxInput.CustomButton.Location = new System.Drawing.Point(295, 2);
            this.textBoxInput.CustomButton.Name = "";
            this.textBoxInput.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.textBoxInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxInput.CustomButton.TabIndex = 1;
            this.textBoxInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxInput.CustomButton.UseSelectable = true;
            this.textBoxInput.CustomButton.Visible = false;
            this.textBoxInput.Lines = new string[0];
            this.textBoxInput.Location = new System.Drawing.Point(257, 392);
            this.textBoxInput.MaxLength = 32767;
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.PasswordChar = '\0';
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInput.SelectedText = "";
            this.textBoxInput.SelectionLength = 0;
            this.textBoxInput.SelectionStart = 0;
            this.textBoxInput.ShortcutsEnabled = true;
            this.textBoxInput.Size = new System.Drawing.Size(337, 44);
            this.textBoxInput.TabIndex = 7;
            this.textBoxInput.UseSelectable = true;
            this.textBoxInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxOutput
            // 
            // 
            // 
            // 
            this.textBoxOutput.CustomButton.Image = null;
            this.textBoxOutput.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.textBoxOutput.CustomButton.Name = "";
            this.textBoxOutput.CustomButton.Size = new System.Drawing.Size(279, 279);
            this.textBoxOutput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxOutput.CustomButton.TabIndex = 1;
            this.textBoxOutput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxOutput.CustomButton.UseSelectable = true;
            this.textBoxOutput.CustomButton.Visible = false;
            this.textBoxOutput.Lines = new string[] {
        "환영합니다! 프로젝트 아이디어를 추천받고 싶다면 \'project idea\' 입력하고 스케줄을 추천받고 싶다면 \'schedule for projec" +
            "t name\'을 입력해주세요."};
            this.textBoxOutput.Location = new System.Drawing.Point(257, 70);
            this.textBoxOutput.MaxLength = 32767;
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.PasswordChar = '\0';
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.SelectedText = "";
            this.textBoxOutput.SelectionLength = 0;
            this.textBoxOutput.SelectionStart = 0;
            this.textBoxOutput.ShortcutsEnabled = true;
            this.textBoxOutput.Size = new System.Drawing.Size(337, 281);
            this.textBoxOutput.TabIndex = 6;
            this.textBoxOutput.Text = "환영합니다! 프로젝트 아이디어를 추천받고 싶다면 \'project idea\' 입력하고 스케줄을 추천받고 싶다면 \'schedule for projec" +
    "t name\'을 입력해주세요.";
            this.textBoxOutput.UseSelectable = true;
            this.textBoxOutput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxOutput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxOutput.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(56, 309);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(115, 42);
            this.metroTile6.TabIndex = 5;
            this.metroTile6.Text = "metroTile6";
            this.metroTile6.UseSelectable = true;
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(56, 230);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(115, 42);
            this.metroTile7.TabIndex = 4;
            this.metroTile7.Text = "metroTile7";
            this.metroTile7.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(56, 149);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(115, 42);
            this.metroTile5.TabIndex = 3;
            this.metroTile5.Text = "metroTile5";
            this.metroTile5.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(56, 70);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(115, 42);
            this.metroTile4.TabIndex = 2;
            this.metroTile4.Text = "metroTile4";
            this.metroTile4.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.Controls.Add(this.metroButton7);
            this.metroTabPage2.Controls.Add(this.metroButton6);
            this.metroTabPage2.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage2.Controls.Add(this.label7);
            this.metroTabPage2.Controls.Add(this.label6);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.Memlsv);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1259, 757);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "현재 상황";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("굴림체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(286, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "WEDNESDAY";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(756, 647);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(75, 23);
            this.metroButton7.TabIndex = 22;
            this.metroButton7.Text = "Next";
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(630, 647);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(75, 23);
            this.metroButton6.TabIndex = 21;
            this.metroButton6.Text = "Previous";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 498);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(736, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "SATURDAY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(628, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "FRIDAY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(505, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "THURSDAY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(392, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "WEDNESDAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(286, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "TUESDAY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(178, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "MONDAY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(72, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "SUNDAY";
            // 
            // Memlsv
            // 
            this.Memlsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.Memlsv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Memlsv.FullRowSelect = true;
            this.Memlsv.Location = new System.Drawing.Point(988, 71);
            this.Memlsv.Name = "Memlsv";
            this.Memlsv.OwnerDraw = true;
            this.Memlsv.Size = new System.Drawing.Size(252, 389);
            this.Memlsv.TabIndex = 12;
            this.Memlsv.UseCompatibleStateImageBehavior = false;
            this.Memlsv.UseSelectable = true;
            this.Memlsv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "이름";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Team";
            this.columnHeader7.Width = 188;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(988, 36);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(69, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "인원 관리";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(43, 36);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "현재 날짜";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(988, 599);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(988, 517);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(170, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "현재 달성 목표 갯수 : N개";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.button1);
            this.metroTabPage3.Controls.Add(this.lbl);
            this.metroTabPage3.Controls.Add(this.txb_whis);
            this.metroTabPage3.Controls.Add(this.txbmsg);
            this.metroTabPage3.Controls.Add(this.listBox1);
            this.metroTabPage3.Controls.Add(this.Whispher);
            this.metroTabPage3.Controls.Add(this.SendToEvery);
            this.metroTabPage3.Controls.Add(this.textBoxLog);
            this.metroTabPage3.Controls.Add(this.metroLabel8);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1259, 757);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "채팅";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(348, 340);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(83, 12);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "귓속말 상대 id";
            // 
            // txb_whis
            // 
            this.txb_whis.Location = new System.Drawing.Point(437, 337);
            this.txb_whis.Name = "txb_whis";
            this.txb_whis.Size = new System.Drawing.Size(120, 21);
            this.txb_whis.TabIndex = 16;
            // 
            // txbmsg
            // 
            this.txbmsg.Location = new System.Drawing.Point(48, 387);
            this.txbmsg.Name = "txbmsg";
            this.txbmsg.Size = new System.Drawing.Size(286, 21);
            this.txbmsg.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(437, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 172);
            this.listBox1.TabIndex = 14;
            // 
            // Whispher
            // 
            this.Whispher.Location = new System.Drawing.Point(437, 429);
            this.Whispher.Name = "Whispher";
            this.Whispher.Size = new System.Drawing.Size(75, 23);
            this.Whispher.TabIndex = 10;
            this.Whispher.Text = "귓속말";
            this.Whispher.UseSelectable = true;
            this.Whispher.Click += new System.EventHandler(this.Whispher_Click);
            // 
            // SendToEvery
            // 
            this.SendToEvery.Location = new System.Drawing.Point(437, 384);
            this.SendToEvery.Name = "SendToEvery";
            this.SendToEvery.Size = new System.Drawing.Size(75, 23);
            this.SendToEvery.TabIndex = 9;
            this.SendToEvery.Text = "전체 전송";
            this.SendToEvery.UseSelectable = true;
            this.SendToEvery.Click += new System.EventHandler(this.SendToEvery_Click);
            // 
            // textBoxLog
            // 
            // 
            // 
            // 
            this.textBoxLog.CustomButton.Image = null;
            this.textBoxLog.CustomButton.Location = new System.Drawing.Point(6, 1);
            this.textBoxLog.CustomButton.Name = "";
            this.textBoxLog.CustomButton.Size = new System.Drawing.Size(279, 279);
            this.textBoxLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxLog.CustomButton.TabIndex = 1;
            this.textBoxLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxLog.CustomButton.UseSelectable = true;
            this.textBoxLog.CustomButton.Visible = false;
            this.textBoxLog.Lines = new string[0];
            this.textBoxLog.Location = new System.Drawing.Point(48, 77);
            this.textBoxLog.MaxLength = 32767;
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.PasswordChar = '\0';
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.SelectedText = "";
            this.textBoxLog.SelectionLength = 0;
            this.textBoxLog.SelectionStart = 0;
            this.textBoxLog.ShortcutsEnabled = true;
            this.textBoxLog.Size = new System.Drawing.Size(286, 281);
            this.textBoxLog.TabIndex = 8;
            this.textBoxLog.UseSelectable = true;
            this.textBoxLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(48, 41);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Team 채팅";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(75, 563);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "목표 현황";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(75, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "팀 목록";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Goallsv
            // 
            this.Goallsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8});
            this.Goallsv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Goallsv.FullRowSelect = true;
            this.Goallsv.Location = new System.Drawing.Point(75, 590);
            this.Goallsv.Name = "Goallsv";
            this.Goallsv.OwnerDraw = true;
            this.Goallsv.Size = new System.Drawing.Size(270, 350);
            this.Goallsv.TabIndex = 8;
            this.Goallsv.UseCompatibleStateImageBehavior = false;
            this.Goallsv.UseSelectable = true;
            this.Goallsv.View = System.Windows.Forms.View.Details;
            this.Goallsv.Click += new System.EventHandler(this.Goallsv_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Team";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "목표";
            this.columnHeader5.Width = 140;
            // 
            // Teamlsv
            // 
            this.Teamlsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Teamlsv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Teamlsv.FullRowSelect = true;
            this.Teamlsv.Location = new System.Drawing.Point(75, 179);
            this.Teamlsv.Name = "Teamlsv";
            this.Teamlsv.OwnerDraw = true;
            this.Teamlsv.Size = new System.Drawing.Size(270, 350);
            this.Teamlsv.TabIndex = 7;
            this.Teamlsv.UseCompatibleStateImageBehavior = false;
            this.Teamlsv.UseSelectable = true;
            this.Teamlsv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Team";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "프로젝트";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "인원";
            this.columnHeader3.Width = 65;
            // 
            // label
            // 
            this.label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label.Location = new System.Drawing.Point(851, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(320, 45);
            this.label.TabIndex = 6;
            this.label.Text = "명언 위치";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Delete
            // 
            this.btn_Delete.ActiveControl = null;
            this.btn_Delete.Location = new System.Drawing.Point(305, 48);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 45);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "팀 제거";
            this.btn_Delete.UseSelectable = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Manage
            // 
            this.btn_Manage.ActiveControl = null;
            this.btn_Manage.Location = new System.Drawing.Point(191, 48);
            this.btn_Manage.Name = "btn_Manage";
            this.btn_Manage.Size = new System.Drawing.Size(108, 44);
            this.btn_Manage.TabIndex = 3;
            this.btn_Manage.Text = "팀 관리";
            this.btn_Manage.UseSelectable = true;
            this.btn_Manage.Click += new System.EventHandler(this.btn_Manage_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.ActiveControl = null;
            this.btn_Create.Location = new System.Drawing.Point(75, 48);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(110, 44);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "팀 생성";
            this.btn_Create.UseSelectable = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadLogButton_Click);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "달성";
            this.columnHeader8.Width = 45;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(534, 48);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(118, 45);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "달성 여부 변경";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 1050);
            this.Controls.Add(this.metroPanel1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "           ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btn_Delete;
        private MetroFramework.Controls.MetroTile btn_Manage;
        private MetroFramework.Controls.MetroTile btn_Create;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox textBoxOutput;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroListView Goallsv;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroListView Teamlsv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroLabel label;
        private MetroFramework.Controls.MetroButton buttonSend;
        private MetroFramework.Controls.MetroTextBox textBoxInput;
        private MetroFramework.Controls.MetroListView Memlsv;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton Whispher;
        private MetroFramework.Controls.MetroButton SendToEvery;
        private MetroFramework.Controls.MetroTextBox textBoxLog;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton6;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTile btnDeleteGoal;
        private System.Windows.Forms.TextBox txbmsg;
        private System.Windows.Forms.TextBox txb_whis;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

