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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.txtModiUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserNameSearch = new System.Windows.Forms.Button();
            this.txtBirth = new System.Windows.Forms.MaskedTextBox();
            this.txtMobile = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(46, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 47;
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
            this.btn_Confirm.Location = new System.Drawing.Point(138, 191);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(84, 23);
            this.btn_Confirm.TabIndex = 46;
            this.btn_Confirm.Text = "수정하기";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // txtModiUserName
            // 
            this.txtModiUserName.Location = new System.Drawing.Point(137, 79);
            this.txtModiUserName.Name = "txtModiUserName";
            this.txtModiUserName.Size = new System.Drawing.Size(100, 21);
            this.txtModiUserName.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(46, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(46, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "회원명";
            // 
            // btnUserNameSearch
            // 
            this.btnUserNameSearch.Location = new System.Drawing.Point(252, 38);
            this.btnUserNameSearch.Name = "btnUserNameSearch";
            this.btnUserNameSearch.Size = new System.Drawing.Size(75, 23);
            this.btnUserNameSearch.TabIndex = 49;
            this.btnUserNameSearch.Text = "검색";
            this.btnUserNameSearch.UseVisualStyleBackColor = true;
            this.btnUserNameSearch.Click += new System.EventHandler(this.btnUserNameSearch_Click);
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(137, 130);
            this.txtBirth.Mask = "0000-00-00";
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(100, 21);
            this.txtBirth.TabIndex = 50;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(138, 39);
            this.txtMobile.Mask = "000-9000-0000";
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(100, 21);
            this.txtMobile.TabIndex = 53;
            // 
            // MemberModi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(353, 242);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtBirth);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.TextBox txtModiUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserNameSearch;
        private System.Windows.Forms.MaskedTextBox txtBirth;
        private System.Windows.Forms.MaskedTextBox txtMobile;
    }
}