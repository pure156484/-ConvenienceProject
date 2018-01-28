namespace PosProject_psi
{
    partial class ChartMonth
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.monthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Confirm);
            this.groupBox1.Controls.Add(this.dtpDay);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "날짜 선택";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(244, 29);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(87, 28);
            this.btn_Confirm.TabIndex = 3;
            this.btn_Confirm.Text = "확인";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(11, 29);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(226, 30);
            this.dtpDay.TabIndex = 2;
            // 
            // monthChart
            // 
            chartArea1.Name = "ChartArea1";
            this.monthChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.monthChart.Legends.Add(legend1);
            this.monthChart.Location = new System.Drawing.Point(12, 85);
            this.monthChart.Name = "monthChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "매출액";
            this.monthChart.Series.Add(series1);
            this.monthChart.Size = new System.Drawing.Size(1036, 434);
            this.monthChart.TabIndex = 4;
            this.monthChart.Text = "chart1";
            // 
            // ChartMonth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthChart);
            this.Name = "ChartMonth";
            this.Text = "월별 차트";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthChart;
    }
}