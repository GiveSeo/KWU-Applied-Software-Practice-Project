namespace Client
{
    partial class Login_form
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
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.pw_textbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.signup_btn = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(85, 76);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(228, 21);
            this.id_textbox.TabIndex = 0;
            this.id_textbox.WordWrap = false;
            // 
            // pw_textbox
            // 
            this.pw_textbox.Location = new System.Drawing.Point(85, 130);
            this.pw_textbox.Name = "pw_textbox";
            this.pw_textbox.Size = new System.Drawing.Size(228, 21);
            this.pw_textbox.TabIndex = 1;
            this.pw_textbox.WordWrap = false;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(134, 176);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(12, 12);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 3;
            this.signup_btn.Text = "회원가입";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(28, 79);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(53, 12);
            this.id_label.TabIndex = 4;
            this.id_label.Text = "아이디 : ";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Location = new System.Drawing.Point(16, 133);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(65, 12);
            this.pw_label.TabIndex = 5;
            this.pw_label.Text = "비밀번호 : ";
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pw_textbox);
            this.Controls.Add(this.id_textbox);
            this.IsMdiContainer = true;
            this.Name = "Login_form";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox pw_textbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label pw_label;
    }
}

