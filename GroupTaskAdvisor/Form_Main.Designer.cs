namespace GroupTaskAdvisor
{
    partial class Form_Main
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
            this.buttonMakegroup = new System.Windows.Forms.Button();
            this.buttonMember = new System.Windows.Forms.Button();
            this.buttonSetgroup = new System.Windows.Forms.Button();
            this.listViewGroup = new System.Windows.Forms.ListView();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonMakegroup
            // 
            this.buttonMakegroup.Location = new System.Drawing.Point(12, 12);
            this.buttonMakegroup.Name = "buttonMakegroup";
            this.buttonMakegroup.Size = new System.Drawing.Size(95, 40);
            this.buttonMakegroup.TabIndex = 6;
            this.buttonMakegroup.Text = "그룹 생성";
            this.buttonMakegroup.UseVisualStyleBackColor = true;
            // 
            // buttonMember
            // 
            this.buttonMember.Location = new System.Drawing.Point(214, 12);
            this.buttonMember.Name = "buttonMember";
            this.buttonMember.Size = new System.Drawing.Size(95, 40);
            this.buttonMember.TabIndex = 7;
            this.buttonMember.Text = "그룹 현황";
            this.buttonMember.UseVisualStyleBackColor = true;
            // 
            // buttonSetgroup
            // 
            this.buttonSetgroup.Location = new System.Drawing.Point(113, 12);
            this.buttonSetgroup.Name = "buttonSetgroup";
            this.buttonSetgroup.Size = new System.Drawing.Size(95, 40);
            this.buttonSetgroup.TabIndex = 8;
            this.buttonSetgroup.Text = "그룹 편집";
            this.buttonSetgroup.UseVisualStyleBackColor = true;
            // 
            // listViewGroup
            // 
            this.listViewGroup.HideSelection = false;
            this.listViewGroup.Location = new System.Drawing.Point(12, 58);
            this.listViewGroup.Name = "listViewGroup";
            this.listViewGroup.Size = new System.Drawing.Size(196, 358);
            this.listViewGroup.TabIndex = 9;
            this.listViewGroup.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxChat
            // 
            this.textBoxChat.Location = new System.Drawing.Point(553, 12);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(235, 391);
            this.textBoxChat.TabIndex = 10;
            this.textBoxChat.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(553, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 25);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "↩";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "시계";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "달력";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "목표 리스트";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(217, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(330, 162);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxChat);
            this.Controls.Add(this.listViewGroup);
            this.Controls.Add(this.buttonSetgroup);
            this.Controls.Add(this.buttonMember);
            this.Controls.Add(this.buttonMakegroup);
            this.Name = "Form_Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMakegroup;
        private System.Windows.Forms.Button buttonMember;
        private System.Windows.Forms.Button buttonSetgroup;
        private System.Windows.Forms.ListView listViewGroup;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
    }
}

