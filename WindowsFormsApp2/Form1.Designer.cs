namespace WindowsFormsApp2
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
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_member = new System.Windows.Forms.Button();
            this.txt_memberid = new System.Windows.Forms.TextBox();
            this.btn_project = new System.Windows.Forms.Button();
            this.txt_ProjectId1 = new System.Windows.Forms.TextBox();
            this.txt_memberpw = new System.Windows.Forms.TextBox();
            this.txt_adminId1 = new System.Windows.Forms.TextBox();
            this.txt_ProjectId2 = new System.Windows.Forms.TextBox();
            this.txt_adminId2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(91, 44);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(496, 25);
            this.txt_ip.TabIndex = 0;
            this.txt_ip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(641, 46);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(116, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "접속";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_member
            // 
            this.btn_member.Location = new System.Drawing.Point(641, 109);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(116, 23);
            this.btn_member.TabIndex = 3;
            this.btn_member.Text = "member 전송";
            this.btn_member.UseVisualStyleBackColor = true;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // txt_memberid
            // 
            this.txt_memberid.Location = new System.Drawing.Point(91, 107);
            this.txt_memberid.Name = "txt_memberid";
            this.txt_memberid.Size = new System.Drawing.Size(496, 25);
            this.txt_memberid.TabIndex = 2;
            // 
            // btn_project
            // 
            this.btn_project.Location = new System.Drawing.Point(641, 187);
            this.btn_project.Name = "btn_project";
            this.btn_project.Size = new System.Drawing.Size(116, 23);
            this.btn_project.TabIndex = 5;
            this.btn_project.Text = "Project 전송";
            this.btn_project.UseVisualStyleBackColor = true;
            this.btn_project.Click += new System.EventHandler(this.btn_project_Click);
            // 
            // txt_ProjectId1
            // 
            this.txt_ProjectId1.Location = new System.Drawing.Point(170, 185);
            this.txt_ProjectId1.Name = "txt_ProjectId1";
            this.txt_ProjectId1.Size = new System.Drawing.Size(417, 25);
            this.txt_ProjectId1.TabIndex = 4;
            // 
            // txt_memberpw
            // 
            this.txt_memberpw.Location = new System.Drawing.Point(91, 140);
            this.txt_memberpw.Name = "txt_memberpw";
            this.txt_memberpw.Size = new System.Drawing.Size(496, 25);
            this.txt_memberpw.TabIndex = 6;
            // 
            // txt_adminId1
            // 
            this.txt_adminId1.Location = new System.Drawing.Point(171, 233);
            this.txt_adminId1.Name = "txt_adminId1";
            this.txt_adminId1.Size = new System.Drawing.Size(416, 25);
            this.txt_adminId1.TabIndex = 7;
            // 
            // txt_ProjectId2
            // 
            this.txt_ProjectId2.Location = new System.Drawing.Point(170, 283);
            this.txt_ProjectId2.Name = "txt_ProjectId2";
            this.txt_ProjectId2.Size = new System.Drawing.Size(417, 25);
            this.txt_ProjectId2.TabIndex = 8;
            // 
            // txt_adminId2
            // 
            this.txt_adminId2.Location = new System.Drawing.Point(170, 336);
            this.txt_adminId2.Name = "txt_adminId2";
            this.txt_adminId2.Size = new System.Drawing.Size(417, 25);
            this.txt_adminId2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "ip주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "멤버 아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "프로젝트 아이디";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "프로젝트 관리자 아이디";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "프로젝트 아이디";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "프로젝트 관리자 아이디";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_adminId2);
            this.Controls.Add(this.txt_ProjectId2);
            this.Controls.Add(this.txt_adminId1);
            this.Controls.Add(this.txt_memberpw);
            this.Controls.Add(this.btn_project);
            this.Controls.Add(this.txt_ProjectId1);
            this.Controls.Add(this.btn_member);
            this.Controls.Add(this.txt_memberid);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_ip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.TextBox txt_memberid;
        private System.Windows.Forms.Button btn_project;
        private System.Windows.Forms.TextBox txt_ProjectId1;
        private System.Windows.Forms.TextBox txt_memberpw;
        private System.Windows.Forms.TextBox txt_adminId1;
        private System.Windows.Forms.TextBox txt_ProjectId2;
        private System.Windows.Forms.TextBox txt_adminId2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

