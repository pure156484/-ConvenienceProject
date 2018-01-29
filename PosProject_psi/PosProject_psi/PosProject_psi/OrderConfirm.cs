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
    public partial class OrderConfirm : Form
    {
        private ListBox basketList;
        SqlConnection sqlcon;
        SqlDataAdapter adapter;
        DataSet ds;

        public OrderConfirm()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            lblDate.Text = DateTime.Now.ToString();
            lblDate.Text = DateTime.Now.ToString();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public OrderConfirm(ListBox basketList)
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            lblDate.Text = DateTime.Now.ToString();
            lblDate.Text = DateTime.Now.ToString();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.basketList = basketList;
            OrderList();
        }

        // 로드 이벤트
        private void OrderConfirm_Load(object sender, EventArgs e)
        {
            itemListGrid.AllowUserToAddRows = false;
            itemListGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }
        
        // 로드시 장바구니 내역 그리드뷰 띄우기
        private void OrderList()
        {
            foreach (var item in basketList.Items)
            {
                var con = DbMan.Dbcon(sqlcon);
                var cmd = new SqlCommand("OrderConfirm", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", item.ToString().Substring(5, item.ToString().IndexOf("상품명 :", 0) - 5).Trim());
                con.Open();

                adapter = DbMan.DbAdap(adapter);
                adapter.SelectCommand = cmd;
                ds = DbMan.DbDs(ds);
                adapter.Fill(ds);
                DataTable pro = ds.Tables[0];
                DataRowCollection rows = pro.Rows;

                foreach (DataRow ed in rows)
                {
                    itemListGrid.Rows.Add(ed[0].ToString(), ed[1].ToString(), ed[2].ToString(), ed[3].ToString());
                }
                con.Close();
            }
        }

        // 취소버튼
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 주문 클릭
        private void btnOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < itemListGrid.RowCount; i++)
            {
                if(itemListGrid.Rows[i].Cells[4].Value == null)
                {
                    MessageBox.Show("수량을 선택해 주세요!");
                    return;
                }
                var con = DbMan.Dbcon(sqlcon);
                var cmd = new SqlCommand("OrdersInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date",DateTime.Parse(lblDate.Text));
                cmd.Parameters.AddWithValue("@barcode", itemListGrid.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@count", int.Parse(itemListGrid.Rows[i].Cells[4].Value.ToString()));
                cmd.Parameters.AddWithValue("@price", int.Parse(itemListGrid.Rows[i].Cells[3].Value.ToString())/** int.Parse(itemListGrid.Rows[i].Cells[4].Value.ToString())*/);
                cmd.Parameters.AddWithValue("@empNum", 1);
                //cmd.Parameters.AddWithValue("@dispodate", DateTime.Parse(DateTime.Now.Year + "-" + DateTime.no));
                con.Open();

                var exr = cmd.ExecuteNonQuery();
            }
            MessageBox.Show("주문이 완료되었습니다!");
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }
    }
}
