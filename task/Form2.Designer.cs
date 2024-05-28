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
            this.metroLabel4.Location = new System.Drawing.Point(63, 158);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(238, 57);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "if you don\'t have an account\r\nEnter your ID and password\r\nand Press the \'Sign Now" +
    "\' button below!";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(112, 112);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Welcome to our App!";
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(142, 253);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 0;
            this.signup_btn.Text = "SIGN UP";
            this.signup_btn.UseSelectable = true;
            this.signup_btn.Click += new System.EventHandler(this.metroButton2_Click);
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
    }
}