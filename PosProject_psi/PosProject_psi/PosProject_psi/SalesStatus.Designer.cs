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
            this.salesTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSalesSave = new System.Windows.Forms.Button();
            this.rboAll = new System.Windows.Forms.RadioButton();
            this.SStatusGridView_Date = new System.Windows.Forms.DataGridView();
            this.rboMoney = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.YearsChart = new System.Windows.Forms.Button();
            this.MonthsChart = new System.Windows.Forms.Button();
            this.DaysChart = new System.Windows.Forms.Button();
            this.rboCard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDaySearch = new System.Windows.Forms.DateTimePicker();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAgeGenderSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.oldChart = new System.Windows.Forms.Button();
            this.genderChart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgeGender = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.SStatusGridView_GenderAge = new System.Windows.Forms.DataGridView();
            this.salesTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SStatusGridView_Date)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SStatusGridView_GenderAge)).BeginInit();
            this.SuspendLayout();
            // 
            // salesTab
            // 
            this.salesTab.Controls.Add(this.tabPage1);
            this.salesTab.Controls.Add(this.tabPage2);
            this.salesTab.Location = new System.Drawing.Point(0, 0);
            this.salesTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salesTab.Name = "salesTab";
            this.salesTab.SelectedIndex = 0;
            this.salesTab.Size = new System.Drawing.Size(893, 616);
            this.salesTab.TabIndex = 45;
            this.salesTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.salesTab_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.rboAll);
            this.tabPage1.Controls.Add(this.SStatusGridView_Date);
            this.tabPage1.Controls.Add(this.rboMoney);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.rboCard);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(885, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "날짜";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSalesSave);
            this.groupBox5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.groupBox5.Location = new System.Drawing.Point(410, 479);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(162, 100);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "파일 저장";
            // 
            // btnSalesSave
            // 
            this.btnSalesSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btnSalesSave.FlatAppearance.BorderSize = 0;
            this.btnSalesSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btnSalesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesSave.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSalesSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btnSalesSave.Location = new System.Drawing.Point(9, 24);
            this.btnSalesSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalesSave.Name = "btnSalesSave";
            this.btnSalesSave.Size = new System.Drawing.Size(138, 66);
            this.btnSalesSave.TabIndex = 36;
            this.btnSalesSave.Text = "엑셀";
            this.btnSalesSave.UseVisualStyleBackColor = false;
            this.btnSalesSave.Click += new System.EventHandler(this.btnSalesSave_Click);
            // 
            // rboAll
            // 
            this.rboAll.AutoSize = true;
            this.rboAll.Checked = true;
            this.rboAll.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.rboAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.rboAll.Location = new System.Drawing.Point(210, 2);
            this.rboAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rboAll.Name = "rboAll";
            this.rboAll.Size = new System.Drawing.Size(114, 24);
            this.rboAll.TabIndex = 44;
            this.rboAll.TabStop = true;
            this.rboAll.Text = "전체보기";
            this.rboAll.UseVisualStyleBackColor = true;
            this.rboAll.Click += new System.EventHandler(this.rboAll_Click);
            // 
            // SStatusGridView_Date
            // 
            this.SStatusGridView_Date.AllowUserToAddRows = false;
            this.SStatusGridView_Date.AllowUserToDeleteRows = false;
            this.SStatusGridView_Date.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.SStatusGridView_Date.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SStatusGridView_Date.Location = new System.Drawing.Point(7, 35);
            this.SStatusGridView_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SStatusGridView_Date.Name = "SStatusGridView_Date";
            this.SStatusGridView_Date.ReadOnly = true;
            this.SStatusGridView_Date.RowTemplate.Height = 23;
            this.SStatusGridView_Date.Size = new System.Drawing.Size(864, 440);
            this.SStatusGridView_Date.TabIndex = 30;
            // 
            // rboMoney
            // 
            this.rboMoney.AutoSize = true;
            this.rboMoney.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.rboMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.rboMoney.Location = new System.Drawing.Point(382, 2);
            this.rboMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rboMoney.Name = "rboMoney";
            this.rboMoney.Size = new System.Drawing.Size(114, 24);
            this.rboMoney.TabIndex = 42;
            this.rboMoney.Text = "현금결제";
            this.rboMoney.UseVisualStyleBackColor = true;
            this.rboMoney.Click += new System.EventHandler(this.rboMoney_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.YearsChart);
            this.groupBox2.Controls.Add(this.MonthsChart);
            this.groupBox2.Controls.Add(this.DaysChart);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.groupBox2.Location = new System.Drawing.Point(7, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(397, 100);
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
            this.YearsChart.Location = new System.Drawing.Point(261, 24);
            this.YearsChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YearsChart.Name = "YearsChart";
            this.YearsChart.Size = new System.Drawing.Size(121, 66);
            this.YearsChart.TabIndex = 35;
            this.YearsChart.Text = "연도별";
            this.YearsChart.UseVisualStyleBackColor = false;
            this.YearsChart.Click += new System.EventHandler(this.YearsChart_Click);
            // 
            // MonthsChart
            // 
            this.MonthsChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.MonthsChart.FlatAppearance.BorderSize = 0;
            this.MonthsChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.MonthsChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthsChart.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MonthsChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.MonthsChart.Location = new System.Drawing.Point(134, 24);
            this.MonthsChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MonthsChart.Name = "MonthsChart";
            this.MonthsChart.Size = new System.Drawing.Size(121, 66);
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
            this.DaysChart.Location = new System.Drawing.Point(7, 24);
            this.DaysChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DaysChart.Name = "DaysChart";
            this.DaysChart.Size = new System.Drawing.Size(121, 66);
            this.DaysChart.TabIndex = 33;
            this.DaysChart.Text = "일별";
            this.DaysChart.UseVisualStyleBackColor = false;
            this.DaysChart.Click += new System.EventHandler(this.DaysChart_Click);
            // 
            // rboCard
            // 
            this.rboCard.AutoSize = true;
            this.rboCard.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.rboCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.rboCard.Location = new System.Drawing.Point(565, 2);
            this.rboCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rboCard.Name = "rboCard";
            this.rboCard.Size = new System.Drawing.Size(114, 24);
            this.rboCard.TabIndex = 43;
            this.rboCard.Text = "카드결제";
            this.rboCard.UseVisualStyleBackColor = true;
            this.rboCard.Click += new System.EventHandler(this.rboCard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDaySearch);
            this.groupBox1.Controls.Add(this.btn_Confirm);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.groupBox1.Location = new System.Drawing.Point(602, 479);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(269, 100);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "날짜로 검색";
            // 
            // dtpDaySearch
            // 
            this.dtpDaySearch.Location = new System.Drawing.Point(7, 24);
            this.dtpDaySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDaySearch.Name = "dtpDaySearch";
            this.dtpDaySearch.Size = new System.Drawing.Size(254, 30);
            this.dtpDaySearch.TabIndex = 2;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btn_Confirm.FlatAppearance.BorderSize = 0;
            this.btn_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btn_Confirm.Location = new System.Drawing.Point(95, 60);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(81, 32);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "확인";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.SStatusGridView_GenderAge);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(885, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "성별/연령대";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAgeGenderSave);
            this.groupBox6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.groupBox6.Location = new System.Drawing.Point(312, 479);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(162, 100);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "파일 저장";
            // 
            // btnAgeGenderSave
            // 
            this.btnAgeGenderSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btnAgeGenderSave.FlatAppearance.BorderSize = 0;
            this.btnAgeGenderSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btnAgeGenderSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgeGenderSave.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAgeGenderSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btnAgeGenderSave.Location = new System.Drawing.Point(11, 24);
            this.btnAgeGenderSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgeGenderSave.Name = "btnAgeGenderSave";
            this.btnAgeGenderSave.Size = new System.Drawing.Size(138, 66);
            this.btnAgeGenderSave.TabIndex = 36;
            this.btnAgeGenderSave.Text = "엑셀";
            this.btnAgeGenderSave.UseVisualStyleBackColor = false;
            this.btnAgeGenderSave.Click += new System.EventHandler(this.btnAgeGenderSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.oldChart);
            this.groupBox4.Controls.Add(this.genderChart);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.groupBox4.Location = new System.Drawing.Point(7, 479);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(299, 100);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "차트 조회";
            // 
            // oldChart
            // 
            this.oldChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.oldChart.FlatAppearance.BorderSize = 0;
            this.oldChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.oldChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oldChart.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.oldChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.oldChart.Location = new System.Drawing.Point(152, 24);
            this.oldChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oldChart.Name = "oldChart";
            this.oldChart.Size = new System.Drawing.Size(138, 66);
            this.oldChart.TabIndex = 34;
            this.oldChart.Text = "연령대별";
            this.oldChart.UseVisualStyleBackColor = false;
            // 
            // genderChart
            // 
            this.genderChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.genderChart.FlatAppearance.BorderSize = 0;
            this.genderChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.genderChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderChart.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.genderChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.genderChart.Location = new System.Drawing.Point(7, 24);
            this.genderChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderChart.Name = "genderChart";
            this.genderChart.Size = new System.Drawing.Size(138, 66);
            this.genderChart.TabIndex = 33;
            this.genderChart.Text = "성별";
            this.genderChart.UseVisualStyleBackColor = false;
            this.genderChart.Click += new System.EventHandler(this.genderChart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgeGender);
            this.groupBox3.Controls.Add(this.cboGender);
            this.groupBox3.Controls.Add(this.cboAge);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.groupBox3.Location = new System.Drawing.Point(566, 479);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(305, 100);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "성별/연령대로 검색";
            // 
            // btnAgeGender
            // 
            this.btnAgeGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(142)))));
            this.btnAgeGender.FlatAppearance.BorderSize = 0;
            this.btnAgeGender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(180)))));
            this.btnAgeGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgeGender.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgeGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(107)))));
            this.btnAgeGender.Location = new System.Drawing.Point(214, 45);
            this.btnAgeGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgeGender.Name = "btnAgeGender";
            this.btnAgeGender.Size = new System.Drawing.Size(81, 32);
            this.btnAgeGender.TabIndex = 34;
            this.btnAgeGender.Text = "확인";
            this.btnAgeGender.UseVisualStyleBackColor = false;
            this.btnAgeGender.Click += new System.EventHandler(this.btnAgeGender_Click);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "남",
            "여"});
            this.cboGender.Location = new System.Drawing.Point(15, 46);
            this.cboGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(92, 28);
            this.cboGender.TabIndex = 32;
            // 
            // cboAge
            // 
            this.cboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Items.AddRange(new object[] {
            "50대 이상",
            "30~49세",
            "20대",
            "14~19세",
            "~13세"});
            this.cboAge.Location = new System.Drawing.Point(114, 46);
            this.cboAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(92, 28);
            this.cboAge.TabIndex = 33;
            // 
            // SStatusGridView_GenderAge
            // 
            this.SStatusGridView_GenderAge.AllowUserToAddRows = false;
            this.SStatusGridView_GenderAge.AllowUserToDeleteRows = false;
            this.SStatusGridView_GenderAge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.SStatusGridView_GenderAge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SStatusGridView_GenderAge.Location = new System.Drawing.Point(7, 8);
            this.SStatusGridView_GenderAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SStatusGridView_GenderAge.Name = "SStatusGridView_GenderAge";
            this.SStatusGridView_GenderAge.ReadOnly = true;
            this.SStatusGridView_GenderAge.RowTemplate.Height = 23;
            this.SStatusGridView_GenderAge.Size = new System.Drawing.Size(864, 469);
            this.SStatusGridView_GenderAge.TabIndex = 31;
            // 
            // SalesStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(891, 614);
            this.Controls.Add(this.salesTab);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalesStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "매출 현황";
            this.salesTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SStatusGridView_Date)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SStatusGridView_GenderAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl salesTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DateTimePicker dtpDaySearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DaysChart;
        private System.Windows.Forms.Button YearsChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MonthsChart;
        public System.Windows.Forms.DataGridView SStatusGridView_Date;
        private System.Windows.Forms.RadioButton rboCard;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rboAll;
        private System.Windows.Forms.RadioButton rboMoney;
        public System.Windows.Forms.DataGridView SStatusGridView_GenderAge;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgeGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button oldChart;
        private System.Windows.Forms.Button genderChart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSalesSave;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAgeGenderSave;
    }
}