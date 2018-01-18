namespace PosProject_psi
{
    partial class SalesStatus
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
            this.TimesChart = new System.Windows.Forms.Button();
            this.MonthsChart = new System.Windows.Forms.Button();
            this.DaysChart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.MemberGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.YearsChart = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimesChart
            // 
            this.TimesChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.TimesChart.FlatAppearance.BorderSize = 0;
            this.TimesChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.TimesChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimesChart.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimesChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.TimesChart.Location = new System.Drawing.Point(6, 19);
            this.TimesChart.Name = "TimesChart";
            this.TimesChart.Size = new System.Drawing.Size(121, 53);
            this.TimesChart.TabIndex = 32;
            this.TimesChart.Text = "시간별";
            this.TimesChart.UseVisualStyleBackColor = false;
            this.TimesChart.Click += new System.EventHandler(this.TimesChart_Click);
            // 
            // MonthsChart
            // 
            this.MonthsChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.MonthsChart.FlatAppearance.BorderSize = 0;
            this.MonthsChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.MonthsChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthsChart.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MonthsChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.MonthsChart.Location = new System.Drawing.Point(260, 19);
            this.MonthsChart.Name = "MonthsChart";
            this.MonthsChart.Size = new System.Drawing.Size(121, 53);
            this.MonthsChart.TabIndex = 34;
            this.MonthsChart.Text = "월별";
            this.MonthsChart.UseVisualStyleBackColor = false;
            this.MonthsChart.Click += new System.EventHandler(this.MonthsChart_Click);
            // 
            // DaysChart
            // 
            this.DaysChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.DaysChart.FlatAppearance.BorderSize = 0;
            this.DaysChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.DaysChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DaysChart.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DaysChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.DaysChart.Location = new System.Drawing.Point(133, 19);
            this.DaysChart.Name = "DaysChart";
            this.DaysChart.Size = new System.Drawing.Size(121, 53);
            this.DaysChart.TabIndex = 33;
            this.DaysChart.Text = "일별";
            this.DaysChart.UseVisualStyleBackColor = false;
            this.DaysChart.Click += new System.EventHandler(this.DaysChart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btn_Confirm);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.groupBox1.Location = new System.Drawing.Point(533, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 80);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "날짜로 조회";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_Confirm.FlatAppearance.BorderSize = 0;
            this.btn_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_Confirm.Location = new System.Drawing.Point(83, 48);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(71, 26);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "확인";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            // 
            // MemberGridView
            // 
            this.MemberGridView.AllowUserToAddRows = false;
            this.MemberGridView.AllowUserToDeleteRows = false;
            this.MemberGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.MemberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberGridView.Location = new System.Drawing.Point(12, 15);
            this.MemberGridView.Name = "MemberGridView";
            this.MemberGridView.ReadOnly = true;
            this.MemberGridView.RowTemplate.Height = 23;
            this.MemberGridView.Size = new System.Drawing.Size(756, 352);
            this.MemberGridView.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.YearsChart);
            this.groupBox2.Controls.Add(this.MonthsChart);
            this.groupBox2.Controls.Add(this.TimesChart);
            this.groupBox2.Controls.Add(this.DaysChart);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 80);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "차트 조회";
            // 
            // YearsChart
            // 
            this.YearsChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.YearsChart.FlatAppearance.BorderSize = 0;
            this.YearsChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.YearsChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearsChart.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.YearsChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.YearsChart.Location = new System.Drawing.Point(387, 19);
            this.YearsChart.Name = "YearsChart";
            this.YearsChart.Size = new System.Drawing.Size(121, 53);
            this.YearsChart.TabIndex = 35;
            this.YearsChart.Text = "연도별";
            this.YearsChart.UseVisualStyleBackColor = false;
            this.YearsChart.Click += new System.EventHandler(this.YearsChart_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // SalesStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(780, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MemberGridView);
            this.Controls.Add(this.groupBox2);
            this.Name = "SalesStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "매출 현황";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TimesChart;
        private System.Windows.Forms.Button MonthsChart;
        private System.Windows.Forms.Button DaysChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DataGridView MemberGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button YearsChart;
    }
}