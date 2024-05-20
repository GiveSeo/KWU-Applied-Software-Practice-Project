namespace ServerApp
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
            this.Teamlv = new System.Windows.Forms.ListView();
            this.Team = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Teamlv
            // 
            this.Teamlv.HideSelection = false;
            this.Teamlv.Location = new System.Drawing.Point(12, 41);
            this.Teamlv.Name = "Teamlv";
            this.Teamlv.Size = new System.Drawing.Size(276, 349);
            this.Teamlv.TabIndex = 0;
            this.Teamlv.UseCompatibleStateImageBehavior = false;
            // 
            // Team
            // 
            this.Team.AutoSize = true;
            this.Team.Location = new System.Drawing.Point(27, 9);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(38, 12);
            this.Team.TabIndex = 2;
            this.Team.Text = "Team";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 349);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.Teamlv);
            this.Name = "Form1";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Teamlv;
        private System.Windows.Forms.Label Team;
        private System.Windows.Forms.TextBox textBox1;
    }
}

