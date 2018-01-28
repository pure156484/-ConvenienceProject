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
    public partial class ChartDay : Form
    {
        DataSet ds;
        DataTable memberTable;
        SqlConnection sqlcon;
        SqlDataAdapter adapter;

        public ChartDay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 일별 날짜 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string day = dtpDay.Value.ToString("yyyyMM");
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("NewChartDay", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dayValue", day);
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            ChartDay_Add(ds);
        }

        /// <summary>
        /// 데이터 차트 삽입
        /// </summary>
        /// <param name="ds"></param>
        private void ChartDay_Add(DataSet ds)
        {
            dayChart.DataSource = null;
            ChartDay_Setting();
            dayChart.DataSource = ds.Tables[0];
            dayChart.Series[0].XValueMember = "sell_date";
            dayChart.Series[0].YValueMembers = "sell_givmoney";
            dayChart.DataBind();
        }

        /// <summary>
        /// 차트 디자인 설정
        /// </summary>
        private void ChartDay_Setting()
        {
            // 차트 x축 범위 지정
            dayChart.ChartAreas[0].AxisX.Minimum = 1;
            dayChart.ChartAreas[0].AxisX.Maximum = 31;

            // 차트 범위 증가값 지정
            dayChart.ChartAreas[0].AxisX.Interval = 1;

            // 차트 격자 설정
            dayChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            dayChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            dayChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            dayChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }
    }
}
