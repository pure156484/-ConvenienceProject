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
    public partial class GarbageAlert : Form
    {
        DataSet ds;
        DataGridView myView;
        DataTable memberTable;
        SqlConnection sqlcon;
        SqlDataAdapter adapter;

        public GarbageAlert()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 폐기 알림 로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GarbageAlert_Load(object sender, EventArgs e)
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("GarbageAlertLoad", con);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            GarbageViewSetting(ds);
        }

        /// <summary>
        /// 폐기 예정 그리드뷰 설정
        /// </summary>
        /// <param name="ds"></param>
        private void GarbageViewSetting(DataSet ds)
        {
            GarbageView.Rows.Clear();

            myView = new DataGridView();

            GarbageView.ColumnCount = 7;
            GarbageView.Columns[0].Visible = false;
            GarbageView.Columns[1].HeaderText = "상품명";
            GarbageView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GarbageView.Columns[2].HeaderText = "바코드";
            GarbageView.Columns[3].HeaderText = "수량";
            GarbageView.Columns[4].HeaderText = "유효일자";
            GarbageView.Columns[5].HeaderText = "남은기간";
            GarbageView.Columns[6].Visible = false;

            memberTable = ds.Tables[0];
            DataRowCollection rows = memberTable.Rows;
            foreach (DataRow dr in rows)
            {
                string[] row =
                {
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString().Substring(0,10), dr[5].ToString() + "일", dr[6].ToString()
                };
                GarbageView.Rows.Add(row);
            }
        }

        /// <summary>
        /// 폐기 메뉴 이동 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGarbageProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GarbageProd().Show();
            this.Close();
        }
    }
}
