namespace PosProject_psi
{
    partial class ChartGender
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
            this.genderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).BeginInit();
            this.SuspendLayout();
            // 
            // genderChart
            // 
            chartArea1.Name = "ChartArea1";
            this.genderChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.genderChart.Legends.Add(legend1);
            this.genderChart.Location = new System.Drawing.Point(12, 48);
            this.genderChart.Name = "genderChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "사람";
            this.genderChart.Series.Add(series1);
            this.genderChart.Size = new System.Drawing.Size(1036, 434);
            this.genderChart.TabIndex = 6;
            this.genderChart.Text = "chart1";
            // 
            // ChartGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 531);
            this.Controls.Add(this.genderChart);
            this.Name = "ChartGender";
            this.Text = "성별 차트";
            this.Load += new System.EventHandler(this.ChartGender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart genderChart;
    }
}