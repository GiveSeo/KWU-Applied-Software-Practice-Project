﻿namespace task
{
    partial class TeamCreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamId = new System.Windows.Forms.TextBox();
            this.lsvMemId = new System.Windows.Forms.ListView();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team ID";
            // 
            // txtTeamId
            // 
            this.txtTeamId.Location = new System.Drawing.Point(141, 59);
            this.txtTeamId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTeamId.Name = "txtTeamId";
            this.txtTeamId.Size = new System.Drawing.Size(190, 21);
            this.txtTeamId.TabIndex = 1;
            // 
            // lsvMemId
            // 
            this.lsvMemId.HideSelection = false;
            this.lsvMemId.Location = new System.Drawing.Point(43, 174);
            this.lsvMemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvMemId.Name = "lsvMemId";
            this.lsvMemId.Size = new System.Drawing.Size(288, 155);
            this.lsvMemId.TabIndex = 2;
            this.lsvMemId.UseCompatibleStateImageBehavior = false;
            // 
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(141, 117);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(150, 21);
            this.txtMemId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "enter here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(109, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Group Member List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(40, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter the member ID you want to add";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(124, 352);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(108, 26);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 113);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeamCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemId);
            this.Controls.Add(this.lsvMemId);
            this.Controls.Add(this.txtTeamId);
            this.Controls.Add(this.label1);
            this.Name = "TeamCreateForm";
            this.Text = "팀 생성";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamId;
        private System.Windows.Forms.ListView lsvMemId;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button button2;
    }
}