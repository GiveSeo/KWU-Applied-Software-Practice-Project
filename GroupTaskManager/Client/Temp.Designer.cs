﻿namespace Client
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
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Whisper = new System.Windows.Forms.TextBox();
            this.label_Whisper = new System.Windows.Forms.Label();
            this.LoadLogButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label_Team = new System.Windows.Forms.Label();
            this.textBox_Team = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(12, 12);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.Size = new System.Drawing.Size(526, 265);
            this.ChatTextBox.TabIndex = 0;
            this.ChatTextBox.WordWrap = false;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 283);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(526, 25);
            this.MessageTextBox.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(544, 258);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(144, 50);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(544, 15);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(45, 15);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "label1";
            // 
            // textBox_Whisper
            // 
            this.textBox_Whisper.Location = new System.Drawing.Point(544, 134);
            this.textBox_Whisper.Name = "textBox_Whisper";
            this.textBox_Whisper.Size = new System.Drawing.Size(144, 25);
            this.textBox_Whisper.TabIndex = 5;
            this.textBox_Whisper.TextChanged += new System.EventHandler(this.textBox_Whisper_TextChanged);
            // 
            // label_Whisper
            // 
            this.label_Whisper.AutoSize = true;
            this.label_Whisper.Location = new System.Drawing.Point(544, 116);
            this.label_Whisper.Name = "label_Whisper";
            this.label_Whisper.Size = new System.Drawing.Size(52, 15);
            this.label_Whisper.TabIndex = 6;
            this.label_Whisper.Text = "귓속말";
            // 
            // LoadLogButton
            // 
            this.LoadLogButton.Location = new System.Drawing.Point(547, 204);
            this.LoadLogButton.Name = "LoadLogButton";
            this.LoadLogButton.Size = new System.Drawing.Size(141, 48);
            this.LoadLogButton.TabIndex = 7;
            this.LoadLogButton.Text = "ChatLog";
            this.LoadLogButton.UseVisualStyleBackColor = true;
            this.LoadLogButton.Click += new System.EventHandler(this.LoadLogButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label_Team
            // 
            this.label_Team.AutoSize = true;
            this.label_Team.Location = new System.Drawing.Point(544, 51);
            this.label_Team.Name = "label_Team";
            this.label_Team.Size = new System.Drawing.Size(52, 15);
            this.label_Team.TabIndex = 8;
            this.label_Team.Text = "팀에게";
            // 
            // textBox_Team
            // 
            this.textBox_Team.Location = new System.Drawing.Point(544, 69);
            this.textBox_Team.Name = "textBox_Team";
            this.textBox_Team.Size = new System.Drawing.Size(144, 25);
            this.textBox_Team.TabIndex = 9;
            this.textBox_Team.TextChanged += new System.EventHandler(this.textBox_Team_TextChanged);
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 320);
            this.Controls.Add(this.textBox_Team);
            this.Controls.Add(this.label_Team);
            this.Controls.Add(this.LoadLogButton);
            this.Controls.Add(this.label_Whisper);
            this.Controls.Add(this.textBox_Whisper);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ChatTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Temp";
            this.Text = "Temp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Temp_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Whisper;
        private System.Windows.Forms.Label label_Whisper;
        private System.Windows.Forms.Button LoadLogButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label_Team;
        private System.Windows.Forms.TextBox textBox_Team;
    }
}