namespace task
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pw_textbox = new MetroFramework.Controls.MetroTextBox();
            this.id_textbox = new MetroFramework.Controls.MetroTextBox();
            this.login_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.signup_btn = new MetroFramework.Controls.MetroButton();
            this.id_signup = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.password_signup = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.name_signup = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pw_textbox);
            this.panel1.Controls.Add(this.id_textbox);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 370);
            this.panel1.TabIndex = 1;
            // 
            // pw_textbox
            // 
            // 
            // 
            // 
            this.pw_textbox.CustomButton.Image = null;
            this.pw_textbox.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.pw_textbox.CustomButton.Name = "";
            this.pw_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pw_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pw_textbox.CustomButton.TabIndex = 1;
            this.pw_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pw_textbox.CustomButton.UseSelectable = true;
            this.pw_textbox.CustomButton.Visible = false;
            this.pw_textbox.Lines = new string[0];
            this.pw_textbox.Location = new System.Drawing.Point(41, 192);
            this.pw_textbox.MaxLength = 32767;
            this.pw_textbox.Name = "pw_textbox";
            this.pw_textbox.PasswordChar = '\0';
            this.pw_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pw_textbox.SelectedText = "";
            this.pw_textbox.SelectionLength = 0;
            this.pw_textbox.SelectionStart = 0;
            this.pw_textbox.ShortcutsEnabled = true;
            this.pw_textbox.Size = new System.Drawing.Size(293, 23);
            this.pw_textbox.TabIndex = 4;
            this.pw_textbox.UseSelectable = true;
            this.pw_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pw_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // id_textbox
            // 
            // 
            // 
            // 
            this.id_textbox.CustomButton.Image = null;
            this.id_textbox.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.id_textbox.CustomButton.Name = "";
            this.id_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.id_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_textbox.CustomButton.TabIndex = 1;
            this.id_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_textbox.CustomButton.UseSelectable = true;
            this.id_textbox.CustomButton.Visible = false;
            this.id_textbox.Lines = new string[0];
            this.id_textbox.Location = new System.Drawing.Point(41, 112);
            this.id_textbox.MaxLength = 32767;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.PasswordChar = '\0';
            this.id_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_textbox.SelectedText = "";
            this.id_textbox.SelectionLength = 0;
            this.id_textbox.SelectionStart = 0;
            this.id_textbox.ShortcutsEnabled = true;
            this.id_textbox.Size = new System.Drawing.Size(293, 23);
            this.id_textbox.TabIndex = 3;
            this.id_textbox.UseSelectable = true;
            this.id_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(144, 253);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "SIGN IN";
            this.login_btn.UseSelectable = true;
            this.login_btn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroLabel7);
            this.panel2.Controls.Add(this.name_signup);
            this.panel2.Controls.Add(this.metroLabel6);
            this.panel2.Controls.Add(this.password_signup);
            this.panel2.Controls.Add(this.metroLabel5);
            this.panel2.Controls.Add(this.id_signup);
            this.panel2.Controls.Add(this.metroLabel4);
            this.panel2.Controls.Add(this.metroLabel3);
            this.panel2.Controls.Add(this.signup_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(407, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 370);
            this.panel2.TabIndex = 2;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(38, 253);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(278, 57);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "if you don\'t have an account\r\nEnter your ID, password\r\nand Name Press the \'Sign N" +
    "ow\' button below!";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(109, 225);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Welcome to our App!";
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(142, 327);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 0;
            this.signup_btn.Text = "SIGN UP";
            this.signup_btn.UseSelectable = true;
            this.signup_btn.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // id_signup
            // 
            // 
            // 
            // 
            this.id_signup.CustomButton.Image = null;
            this.id_signup.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.id_signup.CustomButton.Name = "";
            this.id_signup.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.id_signup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_signup.CustomButton.TabIndex = 1;
            this.id_signup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_signup.CustomButton.UseSelectable = true;
            this.id_signup.CustomButton.Visible = false;
            this.id_signup.Lines = new string[0];
            this.id_signup.Location = new System.Drawing.Point(38, 59);
            this.id_signup.MaxLength = 32767;
            this.id_signup.Name = "id_signup";
            this.id_signup.PasswordChar = '\0';
            this.id_signup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_signup.SelectedText = "";
            this.id_signup.SelectionLength = 0;
            this.id_signup.SelectionStart = 0;
            this.id_signup.ShortcutsEnabled = true;
            this.id_signup.Size = new System.Drawing.Size(293, 23);
            this.id_signup.TabIndex = 5;
            this.id_signup.UseSelectable = true;
            this.id_signup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_signup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(38, 26);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(21, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "ID";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(38, 92);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Password";
            // 
            // password_signup
            // 
            // 
            // 
            // 
            this.password_signup.CustomButton.Image = null;
            this.password_signup.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.password_signup.CustomButton.Name = "";
            this.password_signup.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password_signup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password_signup.CustomButton.TabIndex = 1;
            this.password_signup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password_signup.CustomButton.UseSelectable = true;
            this.password_signup.CustomButton.Visible = false;
            this.password_signup.Lines = new string[0];
            this.password_signup.Location = new System.Drawing.Point(38, 125);
            this.password_signup.MaxLength = 32767;
            this.password_signup.Name = "password_signup";
            this.password_signup.PasswordChar = '\0';
            this.password_signup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_signup.SelectedText = "";
            this.password_signup.SelectionLength = 0;
            this.password_signup.SelectionStart = 0;
            this.password_signup.ShortcutsEnabled = true;
            this.password_signup.Size = new System.Drawing.Size(293, 23);
            this.password_signup.TabIndex = 7;
            this.password_signup.UseSelectable = true;
            this.password_signup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password_signup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(40, 157);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(45, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Name";
            // 
            // name_signup
            // 
            // 
            // 
            // 
            this.name_signup.CustomButton.Image = null;
            this.name_signup.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.name_signup.CustomButton.Name = "";
            this.name_signup.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name_signup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_signup.CustomButton.TabIndex = 1;
            this.name_signup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_signup.CustomButton.UseSelectable = true;
            this.name_signup.CustomButton.Visible = false;
            this.name_signup.Lines = new string[0];
            this.name_signup.Location = new System.Drawing.Point(40, 190);
            this.name_signup.MaxLength = 32767;
            this.name_signup.Name = "name_signup";
            this.name_signup.PasswordChar = '\0';
            this.name_signup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_signup.SelectedText = "";
            this.name_signup.SelectionLength = 0;
            this.name_signup.SelectionStart = 0;
            this.name_signup.ShortcutsEnabled = true;
            this.name_signup.Size = new System.Drawing.Size(293, 23);
            this.name_signup.TabIndex = 9;
            this.name_signup.UseSelectable = true;
            this.name_signup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_signup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.Text = "Login Page";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton login_btn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton signup_btn;
        private MetroFramework.Controls.MetroTextBox pw_textbox;
        private MetroFramework.Controls.MetroTextBox id_textbox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox name_signup;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox password_signup;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox id_signup;
    }
}