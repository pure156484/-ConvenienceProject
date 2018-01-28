namespace PosProject_psi
{
    partial class ChartAge
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
            this.ageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ageChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ageChart.Legends.Add(legend1);
            this.ageChart.Location = new System.Drawing.Point(12, 48);
            this.ageChart.Name = "ageChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "사람";
            this.ageChart.Series.Add(series1);
            this.ageChart.Size = new System.Drawing.Size(1036, 434);
            this.ageChart.TabIndex = 5;
            this.ageChart.Text = "chart1";
            // 
            // ChartAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1060, 531);
            this.Controls.Add(this.ageChart);
            this.Name = "ChartAge";
            this.Text = "연령대 차트";
            this.Load += new System.EventHandler(this.ChartAge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ageChart;
    }
}