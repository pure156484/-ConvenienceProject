using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class GarbageProd : Form
    {
        DataSet ds;
        DataGridView myView;
        DataTable memberTable;
        SqlConnection sqlcon;
        SqlDataAdapter adapter;
        string product_disposal = "";

        public GarbageProd()
        {
            InitializeComponent();
        }

        private void GarbageProd_Load(object sender, EventArgs e)
        {
            garbageView_Before_Load();
            garbageView_After_Load();
        }

        /// <summary>
        /// 폐기 테이블
        /// </summary>
        private void garbageView_After_Load()
        {
            garbageView_After.Rows.Clear();

            myView = new DataGridView();

            garbageView_After.ColumnCount = 7;
            garbageView_After.Columns[0].Visible = false;
            garbageView_After.Columns[1].HeaderText = "상품명";
            garbageView_After.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            garbageView_After.Columns[2].HeaderText = "바코드";
            garbageView_After.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            garbageView_After.Columns[3].HeaderText = "폐기날짜";
            garbageView_After.Columns[4].HeaderText = "폐기수량";
            garbageView_After.Columns[5].HeaderText = "유효기간";
            garbageView_After.Columns[6].Visible = false;

            memberTable = ds.Tables[1];
            DataRowCollection rows = memberTable.Rows;
            foreach (DataRow dr_After in rows)
            {
                string[] row =
                {
                    dr_After[0].ToString(), dr_After[1].ToString(), dr_After[2].ToString(), dr_After[3].ToString().Substring(0,10), dr_After[4].ToString(), dr_After[5].ToString().Substring(0,10),dr_After[6].ToString()
                };
                garbageView_After.Rows.Add(row);
                
            }
        }

        /// <summary>
        /// 폐기 대상 임시 테이블
        /// </summary>
        private void garbageView_Before_Load()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("GarbageAlertLoad", con);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            garbageView_Before_Setting(ds);
        }

        /// <summary>
        /// 폐기 대상 임시 테이블 설정
        /// </summary>
        /// <param name="ds"></param>
        private void garbageView_Before_Setting(DataSet ds)
        {
            garbageView_Before.Rows.Clear();

            myView = new DataGridView();

            garbageView_Before.ColumnCount = 7;
            garbageView_Before.Columns[0].Visible = false;
            garbageView_Before.Columns[1].HeaderText = "상품명";
            garbageView_Before.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            garbageView_Before.Columns[2].HeaderText = "바코드";
            garbageView_Before.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            garbageView_Before.Columns[3].HeaderText = "수량";
            garbageView_Before.Columns[4].HeaderText = "유효일자";
            garbageView_Before.Columns[5].HeaderText = "남은기간";
            garbageView_Before.Columns[6].Visible = false;

            memberTable = ds.Tables[0];
            DataRowCollection rows = memberTable.Rows;
            foreach (DataRow dr_Before in rows)
            {
                string[] row =
                {
                    dr_Before[0].ToString(), dr_Before[1].ToString(), dr_Before[2].ToString(), dr_Before[3].ToString(), dr_Before[4].ToString().Substring(0,10), dr_Before[5].ToString() + "일", dr_Before[6].ToString()
                };
                garbageView_Before.Rows.Add(row);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.Month + "월 " + DateTime.Now.Day + "일 " + DateTime.Now.ToLongTimeString();
        }

        private void garbageView_Before_Click(object sender, EventArgs e)
        {
            try
            {
                product_Info.Text = null;

                product_disposal = this.garbageView_Before.CurrentRow.Cells[0].Value.ToString();
                string product_name = this.garbageView_Before.CurrentRow.Cells[1].Value.ToString();
                string product_barcode = this.garbageView_Before.CurrentRow.Cells[2].Value.ToString();
                string product_count = this.garbageView_Before.CurrentRow.Cells[3].Value.ToString();
                string prdouct_sell_date = this.garbageView_Before.CurrentRow.Cells[4].Value.ToString();
                string prdouct_day = this.garbageView_Before.CurrentRow.Cells[5].Value.ToString();

                product_Info.Text += "<상품명> \r\n";
                product_Info.Text += product_name + "\r\n\r\n";
                product_Info.Text += "<바코드> \r\n";
                product_Info.Text += product_barcode + "\r\n\r\n";
                product_Info.Text += "<수량> \r\n";
                product_Info.Text += product_count + "\r\n\r\n";
                product_Info.Text += "<유효기간> \r\n";
                product_Info.Text += prdouct_sell_date + "\r\n\r\n";
                product_Info.Text += "<남은기간> \r\n";
                product_Info.Text += prdouct_day + "\r\n\r\n";
            }
            catch (Exception)
            {
                MessageBox.Show("선택 된 항목이 없습니다.");
            }
        }

        private void garbageView_After_Click(object sender, EventArgs e)
        {
            try
            {
                picProduct.Image = null;
                product_Info.Text = null;

                product_disposal = this.garbageView_After.CurrentRow.Cells[0].Value.ToString();
                string product_name = this.garbageView_After.CurrentRow.Cells[1].Value.ToString();
                string product_barcode = this.garbageView_After.CurrentRow.Cells[2].Value.ToString();
                string product_disposal_date = this.garbageView_After.CurrentRow.Cells[3].Value.ToString();
                string prdouct_sell_count = this.garbageView_After.CurrentRow.Cells[4].Value.ToString();
                string prdouct_sell_date = this.garbageView_After.CurrentRow.Cells[5].Value.ToString();

                product_Info.Text += "<상품명> \r\n";
                product_Info.Text += product_name + "\r\n\r\n";
                product_Info.Text += "<바코드> \r\n";
                product_Info.Text += product_barcode + "\r\n\r\n";
                product_Info.Text += "<폐기날짜> \r\n";
                product_Info.Text += product_disposal_date + "\r\n\r\n";
                product_Info.Text += "<폐기수량> \r\n";
                product_Info.Text += prdouct_sell_count + "\r\n\r\n";
                product_Info.Text += "<유효기간> \r\n";
                product_Info.Text += prdouct_sell_date + "\r\n\r\n";
            }
            catch (Exception)
            {
                MessageBox.Show("선택 된 항목이 없습니다.");
            }
        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this.garbageView_Before.CurrentRow.Cells[1].Value.ToString() + " 상품의 유효기간 " + this.garbageView_Before.CurrentRow.Cells[4].Value.ToString() + " 제품을 폐기 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (product_disposal != null)
                {
                    var con = DbMan.Dbcon(sqlcon);
                    var cmd = new SqlCommand("Garbage_Delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@order_num", product_disposal);
                    con.Open();

                    int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다.
                    if (i == 1)
                    {
                        return;
                    }
                    else
                    {
                        garbageView_Before_Load();
                        garbageView_After_Load();
                        MessageBox.Show("폐기 처리되었습니다.");
                        return;
                    } 
                }
            }
            else
            {
                MessageBox.Show("선택 된 폐기 항목이 없습니다.");
            }
        }
    }
}
