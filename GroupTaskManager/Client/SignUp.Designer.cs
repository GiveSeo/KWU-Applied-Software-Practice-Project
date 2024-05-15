namespace Client
{
    partial class SignUp_form
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.pw_textbox = new System.Windows.Forms.TextBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(88, 24);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(220, 21);
            this.name_textbox.TabIndex = 0;
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(88, 79);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(220, 21);
            this.id_textbox.TabIndex = 1;
            // 
            // pw_textbox
            // 
            this.pw_textbox.Location = new System.Drawing.Point(88, 133);
            this.pw_textbox.Name = "pw_textbox";
            this.pw_textbox.Size = new System.Drawing.Size(220, 21);
            this.pw_textbox.TabIndex = 2;
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(133, 176);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 3;
            this.signup_btn.Text = "회원가입";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(38, 27);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(41, 12);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "이름 : ";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(26, 82);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(53, 12);
            this.id_label.TabIndex = 5;
            this.id_label.Text = "아이디 : ";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Location = new System.Drawing.Point(17, 136);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(65, 12);
            this.pw_label.TabIndex = 6;
            this.pw_label.Text = "비밀번호 : ";
            // 
            // SignUp_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.pw_textbox);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.name_textbox);
            this.Name = "SignUp_form";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox pw_textbox;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label pw_label;
    }
}