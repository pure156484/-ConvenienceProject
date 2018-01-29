using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class OrderInventoryForm : Form
    {
        SqlConnection sqlcon;
        SqlDataAdapter adapter;
        DataSet ds;
        public OrderInventoryForm()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            lblDate.Text = DateTime.Now.ToString();
            lbldate2.Text = DateTime.Now.ToString();
        }

        private void OrderInventoryForm_Load(object sender, EventArgs e)
        {
            ProdStockView.AllowUserToAddRows = false;
            ProdStockView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ProdStockView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProdStockView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProdStockView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProdStockView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProdStockView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            itemListGrid.AllowUserToAddRows = false;
            itemListGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            itemListGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //itemListGrid.Columns[0].Name = "바 코 드";
            //itemListGrid.Columns[1].Name = "상 품 명";
            //itemListGrid.Columns[2].Name = "품 종";
            //itemListGrid.Columns[3].Name = "단 가";
            //itemListGrid.Columns[4].Name = "판 매 가";
            //itemListGrid.Columns[5].Name = "순 수 익";

            itemListGridView();
            itemStock();
        }

        // 재고상품 그리드뷰
        private void itemStock()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("StockProd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;
            foreach (DataRow ed in rows)
            {
                ProdStockView.Rows.Add(false, ed[0].ToString(), ed[1].ToString(), ed[2].ToString(), ed[3].ToString(), ed[4].ToString());
            }
        }

        // 상품리스트 그리드뷰 띄우기
        private void itemListGridView()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("ProductTotal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;

            foreach (DataRow ed in rows)
            {
                itemListGrid.Rows.Add(false, ed[0].ToString(), ed[1].ToString(), ed[2].ToString(), ed[3].ToString(), ed[4].ToString(), (int.Parse(ed[4].ToString()) - int.Parse(ed[3].ToString())));
            }
        }

        // 현재시각
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate2.Text = DateTime.Now.ToString();
            lblDate.Text = DateTime.Now.ToString();
        }

        // 재고조회 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            ProdStockView.Rows.Clear();
            switch (stockCbo.Text)
            {
                case "상품명":
                    SearchStockProdName();
                    break;
                case "바코드":
                    SearchStockBarcode();
                    break;
            }
        }

        // 재고조회(바코드)
        private void SearchStockBarcode()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("SearchStockProdBacode", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bacode", "%" + StockInfoTxt.Text + "%");
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;

            foreach (DataRow ed in rows)
            {
                ProdStockView.Rows.Add(false, ed[0].ToString(), ed[1].ToString(), ed[2].ToString(), ed[3].ToString(), ed[4].ToString());
            }
        }

        // 재고조회(상품명)
        private void SearchStockProdName()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("SearchStockProdName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prodName", "%" + StockInfoTxt.Text + "%");
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;

            foreach (DataRow ed in rows)
            {
                ProdStockView.Rows.Add(false, ed[0].ToString(), ed[1].ToString(), ed[2].ToString(), ed[3].ToString(), ed[4].ToString());
            }

        }

        // 상품정보조회 버튼 클릭
        private void button2_Click(object sender, EventArgs e)
        {
            itemListGrid.Rows.Clear();
            switch (ItemListcbo.Text)
            {
                case "상품명":
                    SearchProdName();
                    break;
                case "바코드":
                    SearchBarcode();
                    break;
            }
        }

        // 상품조회(바코드)
        private void SearchBarcode()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("SearchProdBacode", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prodName", "%" + prodInfoTxt.Text + "%");
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;

            foreach (DataRow ed in rows)
            {
                itemListGrid.Rows.Add(false, ed[0].ToString(), ed[1].ToString(), ed[2].ToString(), ed[3].ToString(), ed[4].ToString(), (int.Parse(ed[4].ToString()) - int.Parse(ed[3].ToString())));
            }
        }

        // 상품조회(상품명)
        private void SearchProdName()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("SearchProdName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prodName", "%" + prodInfoTxt.Text + "%");
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;

            foreach (DataRow ed in rows)
            {
                itemListGrid.Rows.Add(false, ed[0].ToString(), ed[1].ToString(), ed[2].ToString(), ed[3].ToString(), ed[4].ToString(), (int.Parse(ed[4].ToString()) - int.Parse(ed[3].ToString())));
            }
        }
    }
}
