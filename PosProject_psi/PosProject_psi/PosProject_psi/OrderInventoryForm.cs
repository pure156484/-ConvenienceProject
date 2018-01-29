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

        //로드 이벤트 그리드뷰 디자인 등등
        private void OrderInventoryForm_Load(object sender, EventArgs e)
        {
            basketList.Items.Clear();

            ProdStockView.AllowUserToAddRows = false;
            ProdStockView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ProdStockView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProdStockView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProdStockView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProdStockView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProdStockView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProdStockView.Columns[1].ReadOnly = true;
            ProdStockView.Columns[2].ReadOnly = true;
            ProdStockView.Columns[3].ReadOnly = true;
            ProdStockView.Columns[4].ReadOnly = true;

            itemListGrid.AllowUserToAddRows = false;
            itemListGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            itemListGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemListGrid.Columns[1].ReadOnly = true;
            itemListGrid.Columns[2].ReadOnly = true;
            itemListGrid.Columns[3].ReadOnly = true;
            itemListGrid.Columns[4].ReadOnly = true;
            itemListGrid.Columns[5].ReadOnly = true;
            itemListGrid.Columns[6].ReadOnly = true;

            OrderListGrid.AllowUserToAddRows = false;
            OrderListGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            OrderListGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderListGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderListGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderListGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderListGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderListGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderListGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderListGrid.Columns[1].ReadOnly = true;
            OrderListGrid.Columns[2].ReadOnly = true;
            OrderListGrid.Columns[3].ReadOnly = true;
            OrderListGrid.Columns[4].ReadOnly = true;
            OrderListGrid.Columns[5].ReadOnly = true;
            OrderListGrid.Columns[6].ReadOnly = true;
            OrderListGrid.Columns[7].ReadOnly = true;

            itemListGridView();
            itemStock();
            OrderListView();
        }

        // 주문목록 그리드뷰
        private void OrderListView()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("OrderTotal", con);
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
                OrderListGrid.Rows.Add(false, ed[0].ToString(), ed[1].ToString(), ed[2].ToString(), ed[3].ToString(), ed[4].ToString(), ed[5].ToString(), ed[6].ToString());
            }
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
            if (stockCbo.Text == "검색항목")
            {
                MessageBox.Show("검색 항목을 선택해 주세요!");
                return;
            }
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
            if (ItemListcbo.Text == "검색항목")
            {
                MessageBox.Show("검색 항목을 선택해 주세요!");
                return;
            }
            itemListGrid.Rows.Clear();
            switch (ItemListcbo.Text)
            {
                case "상품명":
                    SearchProdName();
                    break;
                case "바코드":
                    SearchBarcode();
                    break;
                default:
                    MessageBox.Show("검색 항목을 선택해 주세요!");
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
        
        // 상품목록 장바구니에 담기
        private void btnProdBasket_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < itemListGrid.Rows.Count; i++)
            {
                if (itemListGrid.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    BaseketListDistinct("바코드 : " + itemListGrid.Rows[i].Cells[1].Value.ToString().PadLeft(0) + " 상품명 : " + itemListGrid.Rows[i].Cells[2].Value.ToString());
                    basketList.Items.Add("바코드 : " + itemListGrid.Rows[i].Cells[1].Value.ToString().PadLeft(0) + " 상품명 : " + itemListGrid.Rows[i].Cells[2].Value.ToString());
                }
            }

            for (int i = 0; i < itemListGrid.Rows.Count; i++)
            {
                itemListGrid.Rows[i].Cells[0].Value = false;
            }
        }

        // 리스트 박스 중복삭제
        private void BaseketListDistinct(string bacode)
        {
            for (int i = 0; i < basketList.Items.Count; i++)
            {
                if(basketList.Items[i].ToString() == bacode)
                {
                    basketList.Items.RemoveAt(i);
                }
                
            }
        }

        // 재고목록 장바구니에 담기
        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ProdStockView.Rows.Count; i++)
            {
                if (ProdStockView.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    BaseketListDistinct("바코드 : " + ProdStockView.Rows[i].Cells[1].Value.ToString().PadLeft(0) + " 상품명 : " + ProdStockView.Rows[i].Cells[2].Value.ToString());
                    basketList.Items.Add("바코드 : " + ProdStockView.Rows[i].Cells[1].Value.ToString().PadLeft(0) + " 상품명 : " + ProdStockView.Rows[i].Cells[2].Value.ToString());
                }
            }
            for (int i = 0; i < ProdStockView.Rows.Count; i++)
            {
                ProdStockView.Rows[i].Cells[0].Value = false;
            }
        }

        // 발주버튼 클릭
        private void button4_Click(object sender, EventArgs e)
        {
            bool flag = false;

            for (int i = 0; i < itemListGrid.Rows.Count; i++)
            {
                if (itemListGrid.Rows[i].Cells[0].Value.ToString() != "False")
                {
                    flag = true;
                }
            }
            for (int i = 0; i < ProdStockView.Rows.Count; i++)
            {
                if (ProdStockView.Rows[i].Cells[0].Value.ToString() != "False")
                {
                    flag = true;
                }
            }

            // 장바구니에 상품이 없을경우
            if (basketList.Items.Count == 0)
            {
                if (MessageBox.Show("선택하신 품목을 바로 발주 하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!flag)
                    {
                        MessageBox.Show("선택된 항목이 없습니다");
                        return;
                    }
                    button6_Click(null, null);
                    btnProdBasket_Click(null, null);
                    button4_Click(null, null);
                }
            } 

            // 장바구니에 상품이 있을경우
            else
            {
                OrderConfirm oc = new OrderConfirm(basketList);
                oc.Show();
                oc.btnOrder.Click += BtnOrder_Click;
            }
        }

        // 발주최종 버튼
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            OrderInventoryForm_Load(null, null);
        }

        // 취소버튼
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 발주목록 검색
        private void btnSeacrch_Click(object sender, EventArgs e)
        {
            if (cboType.Text == "검색항목")
            {
                MessageBox.Show("검색 항목을 선택해 주세요!");
                return;
            }
            OrderListGrid.Rows.Clear();
            switch (cboType.Text)
            {
                case "상품명":
                    OrderProdName();
                    break;
                case "바코드":
                    OrderBarcode();
                    break;
                default:
                    MessageBox.Show("검색 항목을 선택해 주세요!");
                    break;
            }
        }

        // 발주목록 상품명 검색
        private void OrderProdName()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("OrderSearch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prodName", "%" + txtSearch.Text + "%");
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;

            foreach (DataRow ed in rows)
            {
                OrderListGrid.Rows.Add(false, ed[0].ToString(), ed[1].ToString(), ed[2].ToString(), ed[3].ToString(), ed[4].ToString(), ed[5].ToString(), ed[6].ToString());
            }
        }

        // 발주목록 바코드 검색
        private void OrderBarcode()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("OrderBarcodeSearch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@barcode", "%" + txtSearch.Text + "%");
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;

            foreach (DataRow ed in rows)
            {
                OrderListGrid.Rows.Add(false, ed[0].ToString(), ed[1].ToString(), ed[2].ToString(), ed[3].ToString(), ed[4].ToString(), ed[5].ToString(), ed[6].ToString());
            }
        }

        // 입고완료 버튼 클릭
        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            bool flag = false;

            for (int i = 0; i < OrderListGrid.RowCount; i++)
            {
                if(OrderListGrid.Rows[i].Cells[0].Value.ToString() != "False")
                {
                    flag = true;
                    OrderDelete(OrderListGrid.Rows[i]);
                    ProdCountUpdate(OrderListGrid.Rows[i]);
                }
            }
            if (!flag)
            {
                MessageBox.Show("입고 완료할 상품을 선택해 주세요!");
                return;
            }
            MessageBox.Show("입고가 완료 되었습니다!");
            OrderListGrid.Rows.Clear();
            OrderInventoryForm_Load(null,null);
        }

        // 수량 업데이트
        private void ProdCountUpdate(DataGridViewRow row)
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("ProdCountUpdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@barcode", row.Cells[2].Value.ToString());
            cmd.Parameters.AddWithValue("@count", int.Parse(row.Cells[4].Value.ToString()));
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
        }

        // 발주테이블 로우 삭제
        private void OrderDelete(DataGridViewRow row)
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("DeleteOrder", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(row.Cells[1].Value.ToString()));
            cmd.Parameters.AddWithValue("@barcode", row.Cells[2].Value.ToString());
            cmd.Parameters.AddWithValue("@count",int.Parse(row.Cells[4].Value.ToString()));
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
        }

        // 업데이트 버튼 클릭
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < ProdStockView.RowCount; i++)
                {
                    var con = DbMan.Dbcon(sqlcon);
                    var cmd = new SqlCommand("UpdateStock", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@barcode", ProdStockView.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@count", int.Parse(ProdStockView.Rows[i].Cells[5].Value.ToString()));
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                MessageBox.Show("재고가 수정되었습니다.");
            }
            catch (Exception)
            { 
                MessageBox.Show("수량은 숫자로 입력해 주세요~!");
                return;
            }

        }

        // 수량에 한글입력 불가기능
        private void ProdStockView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        // 장바구니 비우기
        private void btnDrop_Click(object sender, EventArgs e)
        {
            basketList.Items.Clear();
        }

        // 장바구니 항목취소
        private void btnDelete_Click(object sender, EventArgs e)
        {
            basketList.Items.RemoveAt(basketList.SelectedIndex);            
        }
    }
}
