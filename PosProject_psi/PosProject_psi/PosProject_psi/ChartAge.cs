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
    public partial class ChartAge : Form
    {
        DataSet ds;
        DataTable memberTable;
        SqlConnection sqlcon;
        SqlDataAdapter adapter;

        public ChartAge()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 연령대별 차트 로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChartAge_Load(object sender, EventArgs e)
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("NewChartAge", con);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            ChartAge_Add(ds);
        }

        /// <summary>
        /// 데이터 차트 삽입
        /// </summary>
        /// <param name="ds"></param>
        private void ChartAge_Add(DataSet ds)
        {
            ageChart.DataSource = null;
            AgeChartChart_Setting();
            ageChart.DataSource = ds.Tables[0];
            ageChart.Series[0].XValueMember = "name";
            ageChart.Series[0].YValueMembers = "age";
            ageChart.DataBind();
        }

        /// <summary>
        /// 차트 디자인 설정
        /// </summary>
        private void AgeChartChart_Setting()
        {
            // 차트 격자 설정
            ageChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ageChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            ageChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            ageChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }
    }
}
