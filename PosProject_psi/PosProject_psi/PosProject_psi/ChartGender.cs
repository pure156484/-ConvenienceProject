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
    public partial class ChartGender : Form
    {
        DataSet ds;
        DataTable memberTable;
        SqlConnection sqlcon;
        SqlDataAdapter adapter;

        public ChartGender()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 성별 차트 로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChartGender_Load(object sender, EventArgs e)
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("NewChartGender", con);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            ChartGender_Add(ds);
        }

        /// <summary>
        /// 데이터 차트 삽입
        /// </summary>
        /// <param name="ds"></param>
        private void ChartGender_Add(DataSet ds)
        {
            genderChart.DataSource = null;
            GenderChart_Setting();
            genderChart.DataSource = ds.Tables[0];
            genderChart.Series[0].XValueMember = "name";
            genderChart.Series[0].YValueMembers = "sum";
            genderChart.DataBind();
        }

        /// <summary>
        /// 차트 디자인 설정
        /// </summary>
        private void GenderChart_Setting()
        {
            // 차트 격자 설정
            genderChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            genderChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            genderChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            genderChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }
    }
}
