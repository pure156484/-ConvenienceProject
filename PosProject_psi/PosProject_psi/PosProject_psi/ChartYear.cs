using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class ChartYear : Form
    {
        DataSet ds;
        DataTable memberTable;
        SqlConnection sqlcon;
        SqlDataAdapter adapter;

        public ChartYear()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 연도별 날짜 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            int yearStart = int.Parse(dtpStart.Value.ToString("yyyy"));
            int yearEnd = int.Parse(dtpEnd.Value.ToString("yyyy")) + 1;
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("NewChartYear", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@start", yearStart);
            cmd.Parameters.AddWithValue("@end", yearEnd);
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            ChartMonth_Add(ds);
        }

        /// <summary>
        /// 데이터 차트 삽입
        /// </summary>
        /// <param name="ds"></param>
        private void ChartMonth_Add(DataSet ds)
        {
            yearChart.DataSource = null;
            ChartMonth_Setting();
            yearChart.DataSource = ds.Tables[0];
            yearChart.Series[0].XValueMember = "sell_date";
            yearChart.Series[0].YValueMembers = "sell_givmoney";
            yearChart.DataBind();
        }

        /// <summary>
        /// 차트 디자인 설정
        /// </summary>
        private void ChartMonth_Setting()
        {
            // 차트 x축 범위 지정
            //monthChart.ChartAreas[0].AxisX.Minimum = 1;
            //monthChart.ChartAreas[0].AxisX.Maximum = 12;

            // 차트 범위 증가값 지정
            //monthChart.ChartAreas[0].AxisX.Interval = 1;

            // 차트 격자 설정
            yearChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            yearChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            yearChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            yearChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }
    }
}
