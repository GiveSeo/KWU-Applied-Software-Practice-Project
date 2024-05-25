namespace Client
{
    partial class Temp
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
            this.team_listbox = new System.Windows.Forms.ListBox();
            this.teamadd_btn = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // team_listbox
            // 
            this.team_listbox.FormattingEnabled = true;
            this.team_listbox.ItemHeight = 12;
            this.team_listbox.Location = new System.Drawing.Point(12, 12);
            this.team_listbox.Name = "team_listbox";
            this.team_listbox.Size = new System.Drawing.Size(260, 424);
            this.team_listbox.TabIndex = 0;
            // 
            // teamadd_btn
            // 
            this.teamadd_btn.Location = new System.Drawing.Point(305, 216);
            this.teamadd_btn.Name = "teamadd_btn";
            this.teamadd_btn.Size = new System.Drawing.Size(75, 23);
            this.teamadd_btn.TabIndex = 1;
            this.teamadd_btn.Text = "팀 만들기";
            this.teamadd_btn.UseVisualStyleBackColor = true;
            this.teamadd_btn.Click += new System.EventHandler(this.teamadd_btn_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(303, 21);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(81, 12);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "현재 사용자 : ";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(713, 16);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "로그아웃";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.teamadd_btn);
            this.Controls.Add(this.team_listbox);
            this.Name = "Temp";
            this.Text = "Temp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Temp_FormClosed);
            this.Load += new System.EventHandler(this.Temp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox team_listbox;
        private System.Windows.Forms.Button teamadd_btn;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button btn_logout;
    }
}