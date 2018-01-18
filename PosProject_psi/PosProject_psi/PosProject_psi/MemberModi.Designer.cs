namespace PosProject_psi
{
    partial class MemberModi
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
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone3 = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.cboPhone1 = new System.Windows.Forms.ComboBox();
            this.btnUserNameSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.txtModiUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.cboGender.Location = new System.Drawing.Point(109, 162);
            this.cboGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(106, 20);
            this.cboGender.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(21, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "성별";
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(109, 123);
            this.birth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(176, 21);
            this.birth.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 70;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 69;
            this.label4.Text = "-";
            // 
            // txtPhone3
            // 
            this.txtPhone3.Location = new System.Drawing.Point(245, 33);
            this.txtPhone3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone3.Mask = "0000";
            this.txtPhone3.Name = "txtPhone3";
            this.txtPhone3.Size = new System.Drawing.Size(43, 21);
            this.txtPhone3.TabIndex = 68;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(185, 33);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone2.Mask = "0000";
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(43, 21);
            this.txtPhone2.TabIndex = 67;
            // 
            // cboPhone1
            // 
            this.cboPhone1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhone1.FormattingEnabled = true;
            this.cboPhone1.Items.AddRange(new object[] {
            "010",
            "011",
            "016",
            "017",
            "018",
            "019"});
            this.cboPhone1.Location = new System.Drawing.Point(109, 33);
            this.cboPhone1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPhone1.Name = "cboPhone1";
            this.cboPhone1.Size = new System.Drawing.Size(60, 20);
            this.cboPhone1.TabIndex = 66;
            // 
            // btnUserNameSearch
            // 
            this.btnUserNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btnUserNameSearch.FlatAppearance.BorderSize = 0;
            this.btnUserNameSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btnUserNameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserNameSearch.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUserNameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btnUserNameSearch.Location = new System.Drawing.Point(297, 33);
            this.btnUserNameSearch.Name = "btnUserNameSearch";
            this.btnUserNameSearch.Size = new System.Drawing.Size(62, 21);
            this.btnUserNameSearch.TabIndex = 65;
            this.btnUserNameSearch.Text = "검색";
            this.btnUserNameSearch.UseVisualStyleBackColor = false;
            this.btnUserNameSearch.Click += new System.EventHandler(this.btnUserNameSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "생년월일";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_Confirm.FlatAppearance.BorderSize = 0;
            this.btn_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_Confirm.Location = new System.Drawing.Point(109, 202);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(89, 26);
            this.btn_Confirm.TabIndex = 63;
            this.btn_Confirm.Text = "수정하기";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // txtModiUserName
            // 
            this.txtModiUserName.Location = new System.Drawing.Point(109, 79);
            this.txtModiUserName.Name = "txtModiUserName";
            this.txtModiUserName.Size = new System.Drawing.Size(100, 21);
            this.txtModiUserName.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "회원명";
            // 
            // MemberModi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(377, 261);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone3);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.cboPhone1);
            this.Controls.Add(this.btnUserNameSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.txtModiUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MemberModi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원 수정";
            this.Load += new System.EventHandler(this.MemberModi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtPhone3;
        private System.Windows.Forms.MaskedTextBox txtPhone2;
        private System.Windows.Forms.ComboBox cboPhone1;
        private System.Windows.Forms.Button btnUserNameSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.TextBox txtModiUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}