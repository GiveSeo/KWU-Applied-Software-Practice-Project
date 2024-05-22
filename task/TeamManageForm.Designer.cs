namespace task
{
    partial class TeamManageForm
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
            this.txbTeamId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lsvGoal = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbTeamId
            // 
            this.txbTeamId.Location = new System.Drawing.Point(163, 95);
            this.txbTeamId.Name = "txbTeamId";
            this.txbTeamId.Size = new System.Drawing.Size(140, 21);
            this.txbTeamId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(39, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Team Id : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(39, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Goal Here : ";
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(163, 134);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(140, 21);
            this.txtGoal.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(123, 365);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(108, 26);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(140, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Goal List";
            // 
            // lsvGoal
            // 
            this.lsvGoal.HideSelection = false;
            this.lsvGoal.Location = new System.Drawing.Point(42, 187);
            this.lsvGoal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvGoal.Name = "lsvGoal";
            this.lsvGoal.Size = new System.Drawing.Size(288, 155);
            this.lsvGoal.TabIndex = 8;
            this.lsvGoal.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(309, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TeamManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 409);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvGoal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTeamId);
            this.Name = "TeamManageForm";
            this.Text = "TeamManageForm";
            this.Load += new System.EventHandler(this.TeamManageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbTeamId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lsvGoal;
        private System.Windows.Forms.Button btnAdd;
    }
}