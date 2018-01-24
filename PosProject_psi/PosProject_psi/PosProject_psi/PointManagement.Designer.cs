namespace PosProject_psi
{
    partial class PointManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_phone = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone3 = new System.Windows.Forms.MaskedTextBox();
            this.cboPhone1 = new System.Windows.Forms.ComboBox();
            this.txtPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.point_name = new System.Windows.Forms.Label();
            this.point_phone = new System.Windows.Forms.Label();
            this.point_day = new System.Windows.Forms.Label();
            this.btn_use = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.point_count = new System.Windows.Forms.Label();
            this.point_use_point = new System.Windows.Forms.TextBox();
            this.btn_all = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.point_pay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_phone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhone3);
            this.groupBox1.Controls.Add(this.cboPhone1);
            this.groupBox1.Controls.Add(this.txtPhone2);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.groupBox1.Location = new System.Drawing.Point(34, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 65);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원 전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "-";
            // 
            // btn_phone
            // 
            this.btn_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_phone.FlatAppearance.BorderSize = 0;
            this.btn_phone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_phone.Location = new System.Drawing.Point(273, 22);
            this.btn_phone.Name = "btn_phone";
            this.btn_phone.Size = new System.Drawing.Size(71, 26);
            this.btn_phone.TabIndex = 1;
            this.btn_phone.Text = "확인";
            this.btn_phone.UseVisualStyleBackColor = false;
            this.btn_phone.Click += new System.EventHandler(this.btn_phone_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "-";
            // 
            // txtPhone3
            // 
            this.txtPhone3.Location = new System.Drawing.Point(156, 28);
            this.txtPhone3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone3.Mask = "0000";
            this.txtPhone3.Name = "txtPhone3";
            this.txtPhone3.Size = new System.Drawing.Size(43, 26);
            this.txtPhone3.TabIndex = 64;
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
            this.cboPhone1.Location = new System.Drawing.Point(11, 28);
            this.cboPhone1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPhone1.Name = "cboPhone1";
            this.cboPhone1.Size = new System.Drawing.Size(60, 24);
            this.cboPhone1.TabIndex = 62;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(93, 28);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone2.Mask = "0000";
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(43, 26);
            this.txtPhone2.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(30, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "성함";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(30, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(30, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "생년월일";
            // 
            // point_name
            // 
            this.point_name.AutoSize = true;
            this.point_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.point_name.Location = new System.Drawing.Point(156, 114);
            this.point_name.Name = "point_name";
            this.point_name.Size = new System.Drawing.Size(0, 16);
            this.point_name.TabIndex = 31;
            // 
            // point_phone
            // 
            this.point_phone.AutoSize = true;
            this.point_phone.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.point_phone.Location = new System.Drawing.Point(156, 173);
            this.point_phone.Name = "point_phone";
            this.point_phone.Size = new System.Drawing.Size(0, 16);
            this.point_phone.TabIndex = 32;
            // 
            // point_day
            // 
            this.point_day.AutoSize = true;
            this.point_day.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point_day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.point_day.Location = new System.Drawing.Point(156, 232);
            this.point_day.Name = "point_day";
            this.point_day.Size = new System.Drawing.Size(0, 16);
            this.point_day.TabIndex = 33;
            // 
            // btn_use
            // 
            this.btn_use.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_use.FlatAppearance.BorderSize = 0;
            this.btn_use.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_use.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_use.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_use.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_use.Location = new System.Drawing.Point(34, 412);
            this.btn_use.Name = "btn_use";
            this.btn_use.Size = new System.Drawing.Size(164, 53);
            this.btn_use.TabIndex = 34;
            this.btn_use.Text = "포인트 사용";
            this.btn_use.UseVisualStyleBackColor = false;
            this.btn_use.Click += new System.EventHandler(this.btn_use_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_save.Location = new System.Drawing.Point(219, 412);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(164, 53);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "포인트 적립";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // point_count
            // 
            this.point_count.AutoSize = true;
            this.point_count.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.point_count.Location = new System.Drawing.Point(156, 291);
            this.point_count.Name = "point_count";
            this.point_count.Size = new System.Drawing.Size(0, 16);
            this.point_count.TabIndex = 37;
            // 
            // point_use_point
            // 
            this.point_use_point.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point_use_point.Location = new System.Drawing.Point(164, 349);
            this.point_use_point.Name = "point_use_point";
            this.point_use_point.Size = new System.Drawing.Size(112, 35);
            this.point_use_point.TabIndex = 38;
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_all.FlatAppearance.BorderSize = 0;
            this.btn_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.Font = new System.Drawing.Font("굴림", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_all.Location = new System.Drawing.Point(290, 349);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(94, 34);
            this.btn_all.TabIndex = 39;
            this.btn_all.Text = "모두 사용";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(30, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "기존포인트";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(30, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "반영포인트";
            // 
            // point_pay
            // 
            this.point_pay.AutoSize = true;
            this.point_pay.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point_pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.point_pay.Location = new System.Drawing.Point(303, 271);
            this.point_pay.Name = "point_pay";
            this.point_pay.Size = new System.Drawing.Size(0, 21);
            this.point_pay.TabIndex = 44;
            // 
            // PointManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(404, 496);
            this.Controls.Add(this.point_pay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.point_use_point);
            this.Controls.Add(this.point_count);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_use);
            this.Controls.Add(this.point_day);
            this.Controls.Add(this.point_phone);
            this.Controls.Add(this.point_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PointManagement";
            this.Text = "PointManagement";
            this.Load += new System.EventHandler(this.PointManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label point_name;
        private System.Windows.Forms.Label point_phone;
        private System.Windows.Forms.Label point_day;
        private System.Windows.Forms.Button btn_use;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label point_count;
        private System.Windows.Forms.TextBox point_use_point;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label point_pay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPhone3;
        private System.Windows.Forms.ComboBox cboPhone1;
        private System.Windows.Forms.MaskedTextBox txtPhone2;
    }
}