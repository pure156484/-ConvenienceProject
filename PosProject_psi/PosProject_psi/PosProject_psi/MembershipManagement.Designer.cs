namespace CommonProject
{
    partial class MembershipManagement
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Modi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MemberGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_Add.Location = new System.Drawing.Point(12, 387);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 53);
            this.btn_Add.TabIndex = 27;
            this.btn_Add.Text = "회원 등록";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_Search.Location = new System.Drawing.Point(112, 25);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(71, 26);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "확인";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_Del.FlatAppearance.BorderSize = 0;
            this.btn_Del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_Del.Location = new System.Drawing.Point(286, 387);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(121, 53);
            this.btn_Del.TabIndex = 29;
            this.btn_Del.Text = "회원 삭제";
            this.btn_Del.UseVisualStyleBackColor = false;
            // 
            // btn_Modi
            // 
            this.btn_Modi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_Modi.FlatAppearance.BorderSize = 0;
            this.btn_Modi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_Modi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modi.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Modi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_Modi.Location = new System.Drawing.Point(149, 387);
            this.btn_Modi.Name = "btn_Modi";
            this.btn_Modi.Size = new System.Drawing.Size(121, 53);
            this.btn_Modi.TabIndex = 28;
            this.btn_Modi.Text = "회원 수정";
            this.btn_Modi.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.groupBox1.Location = new System.Drawing.Point(579, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 65);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "전화번호로 검색";
            // 
            // MemberGridView
            // 
            this.MemberGridView.AllowUserToAddRows = false;
            this.MemberGridView.AllowUserToDeleteRows = false;
            this.MemberGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.MemberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberGridView.Location = new System.Drawing.Point(12, 17);
            this.MemberGridView.Name = "MemberGridView";
            this.MemberGridView.ReadOnly = true;
            this.MemberGridView.RowTemplate.Height = 23;
            this.MemberGridView.Size = new System.Drawing.Size(756, 352);
            this.MemberGridView.TabIndex = 25;
            // 
            // MembershipManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(780, 456);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Modi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MemberGridView);
            this.Name = "MembershipManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원 관리";
            this.Load += new System.EventHandler(this.MembershipManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Modi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView MemberGridView;
    }
}