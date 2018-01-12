using CommonProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainForm : Form
    {
        
        SqlDataAdapter adapter;
        DataSet ds;
        SqlDataAdapter picAdapter;
        DataSet picDs;
        SqlConnection sqlcon = null;
        SqlConnection picSqlcon = null;
        int eventNum;
        int noCount = 1;
        string prodCount;
        int price;
        TextBox cursor;
        string bacode;

        public MainForm()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            lblDate.Text = DateTime.Now.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            itemGrid.ColumnCount = 6;
            itemGrid.Columns[0].Name = "NO";
            itemGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemGrid.Columns[1].Name = "상 품 명";
            itemGrid.Columns[2].Name = "상 품 코 드";
            itemGrid.Columns[3].Name = "가 격";
            itemGrid.Columns[4].Name = "수 량";
            itemGrid.Columns[5].Name = "행 사";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Close();
            new GarbageProd().Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Setting().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new MembershipManagement().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new EmployeeManagement().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Receipt().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Events().Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            new ProductManagement().Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new OrderInventoryForm().Show();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            new Events().Show();
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            new OrderInventoryForm().Show();
        }

        private void txtBacode_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter)
            {
                InputInfo();
            }
        }

        private void itemGrid_Click(object sender, EventArgs e) // 숫자 클릭시
        {
            try
            {
                cursor.Text += sender.ToString().Substring(sender.ToString().Length - 1);
            }
            catch (NullReferenceException)
            {
                prodCount += sender.ToString().Substring(sender.ToString().Length - 1);
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //수량 클릭시
        {
            itemGrid.CurrentRow.Cells[4].Value = prodCount;
            try
            {
                itemGrid.CurrentRow.Cells[3].Value = (price * int.Parse(itemGrid.CurrentRow.Cells[4].Value.ToString())).ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("수량을 입력해 주세요");
                itemGrid.CurrentRow.Cells[4].Value = 1;
                txtBacode.Text = "";
                prodCount = "";
                return;
            }

            BonusEvent();

            //price = int.Parse(itemGrid.CurrentRow.Cells[3].Value.ToString()) / int.Parse(prodCount);
            //txtPrice.Text = itemGrid.CurrentRow.Cells[3].Value.ToString();
            GiveMoney();
            prodCount = "";
        }

        private void BonusEvent()
        {
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("EventBonus", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eventNum", eventNum);
            con.Open();
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;
            
            foreach (DataRow er in rows)
            {
                if (er[0].ToString() == "")
                {
                    return;
                }
                else
                {
                    int bonus = int.Parse(itemGrid.CurrentRow.Cells[4].Value.ToString()) / (int.Parse(er[0].ToString()) + 1);
                    if (bonus >= 1)
                    {
                        itemGrid.CurrentRow.Cells[3].Value = int.Parse(itemGrid.CurrentRow.Cells[3].Value.ToString()) - (price * bonus);
                    }
                }
            }
        }

        private void GiveMoney()
        {
            int givmoney = 0;
            for (int i = 0; i < itemGrid.Rows.Count; i++)
            {
                givmoney += int.Parse(itemGrid.Rows[i].Cells[3].Value.ToString());
            }
            txtPrice.Text = givmoney.ToString();
        }
        private void txtBacode_Click(object sender, EventArgs e)
        {
            cursor = txtBacode;
        }

        private void txtMoney_Click(object sender, EventArgs e)
        {
            txtMoney.Text = "";
            cursor = txtMoney;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            InputInfo();
            
            if (cursor == txtReturnMoney)
            {
                if (int.Parse(txtReturnMoney.Text) >= 0)
                {
                    SellProdInsert();
                    ProdMinus();
                    AutoClosingMessageBox.Show("정상처리되었습니다.", "GD편의점", 2000);
                    itemGrid.Rows.Clear();
                    txtBacode.Clear();
                    txtMoney.Clear();
                    txtPrice.Clear();
                    txtProdInfo.Clear();
                    txtReturnMoney.Clear();
                    pictureBox1.Image = null;
                }
            }
        }

        private void InputInfo()
        {
            txtProdInfo.Text = "";
            if (cursor == txtMoney) 
            {
                txtReturnMoney.Text = (int.Parse(txtMoney.Text) - int.Parse(txtPrice.Text)).ToString();
            }
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("ProdRegist", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prodNum", txtBacode.Text);
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;

            if (rows.Count.ToString() == "0")
            {
                cmd = new SqlCommand("ProdRegistNoEvent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", txtBacode.Text);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                pro = ds.Tables[0];
                rows = pro.Rows;

                foreach (DataRow er in rows)
                {

                    string[] row =
                    {
                        noCount.ToString(),er[0].ToString(), er[1].ToString(), er[2].ToString(),"1"
                    };
                    itemGrid.Rows.Add(row);
                    price = int.Parse(er[2].ToString());
                    bacode = er[1].ToString();
                    txtProdInfo.Text += "<상품 명>\r\n";
                    txtProdInfo.Text += er[0] + "\r\n\r\n";
                    
                }
            }
            else
            {
                foreach (DataRow er in rows)
                {
                    string[] row =
                    {
                        noCount.ToString(),er[0].ToString(), er[1].ToString(), er[2].ToString(),"1",er[3].ToString()
                    };

                    itemGrid.Rows.Add(row);
                    price = int.Parse(er[2].ToString());
                    bacode = er[1].ToString();
                    txtProdInfo.Text += "<상품 명>\r\n";
                    txtProdInfo.Text += er[0] + "\r\n\r\n";
                    txtProdInfo.Text += "<이벤트 명>\r\n";
                    txtProdInfo.Text += er[3] + "\r\n\r\n";
                    txtProdInfo.Text += "<이벤트 기간>\r\n";
                    txtProdInfo.Text += er[4] + "~\r\n" + er[5] + "\r\n\r\n";
                    txtProdInfo.Text += "<이벤트 내용>\r\n";
                    txtProdInfo.Text += er[6] + "\r\n\r\n";
                    eventNum = int.Parse(er[9].ToString());
                }

            }
            string barcodeNum = txtBacode.Text;
            ProdImage(barcodeNum);
            //DiscountEvent();
            
            for (int i = 0; i < itemGrid.Rows.Count-1; i++)
            {
                if(itemGrid.Rows[i].Cells[2].Value.ToString() == bacode)
                {
                   
                    itemGrid.Rows[i].Cells[4].Value = int.Parse(itemGrid.Rows[i].Cells[4].Value.ToString()) + 1;
                    itemGrid.Rows[i].Cells[3].Value = (price * int.Parse(itemGrid.Rows[i].Cells[4].Value.ToString())).ToString(); //qq
                    itemGrid.Rows.Remove(itemGrid.Rows[itemGrid.Rows.Count - 1]);
                    noCount--;

                }
            }
            //try
            //{
            //    itemGrid.CurrentRow.Cells[3].Value = (price * int.Parse(itemGrid.CurrentRow.Cells[4].Value.ToString())).ToString();
            //}
            //catch (FormatException)
            //{

            //    MessageBox.Show("항목선택 후 수량을 입려해 주세요");
            //    txtBacode.Text = "";
            //    prodCount = "";
            //    return;
            //}
            txtBacode.Text = "";
            noCount++;
            con.Close();
            GiveMoney();

            for (int i = 0; i < itemGrid.Rows.Count; i++)
            {
                itemGrid.Rows[i].Cells[0].Value = i + 1;
            }
            prodCount = "";
            rows.Clear();
            //BonusEvent();
        }

        //private void DiscountEvent()
        //{
        //    var con = DbMan.Dbcon(sqlcon);
        //    var cmd = new SqlCommand("EventDiscount", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@eventNum", eventNum);
        //    con.Open();

        //    adapter = DbMan.DbAdap(adapter);
        //    adapter.SelectCommand = cmd;
        //    ds = DbMan.DbDs(ds);
        //    adapter.Fill(ds);
        //    DataTable pro = ds.Tables[0];
        //    DataRowCollection rows = pro.Rows;

        //}

        private void ProdImage(string barcodeNum)
        {
            pictureBox1.Image = null;
            var con = DbMan.Dbcon(picSqlcon);
            var cmd = new SqlCommand("ReturnImage", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@barcode", barcodeNum);
            con.Open();

            picAdapter = DbMan.DbAdap(picAdapter);
            picAdapter.SelectCommand = cmd;
            picDs = DbMan.DbDs(picDs);
            picAdapter.Fill(picDs);
            DataTable pro = picDs.Tables[0];
            DataRowCollection rows = pro.Rows;
            foreach (DataRow er in rows)
            {
                object pic = er[0];
                if(pic.GetType().ToString() == "System.DBNull")
                {
                    return;
                }
                else
                {
                    pictureBox1.Image = new Bitmap(new MemoryStream((byte[])pic));
                }
            }
            con.Close();
            rows.Clear();
            picDs = null;
            picAdapter = null;
            pro.Clear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            itemGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if(MessageBox.Show("해당 품목을 삭제 하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("해당 항목이 삭제되었습니다.");
                itemGrid.Rows.Remove(itemGrid.CurrentRow);
                itemGrid.Refresh();
                GiveMoney();
                noCount -= 1;
                for (int i = 0; i < itemGrid.Rows.Count; i++)
                {
                    itemGrid.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                cursor.Text = "";
            }
            catch (NullReferenceException)
            {
                txtBacode.Text = "";
            }
        }

        private void itemGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            txtProdInfo.Text = "";
            cursor = null;
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("ProdRegist", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prodNum", itemGrid.CurrentRow.Cells[2].Value.ToString());
            con.Open();
            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;

            if (rows.Count.ToString() == "0")
            {
                cmd = new SqlCommand("ProdRegistNoEvent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", itemGrid.CurrentRow.Cells[2].Value.ToString());
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                pro = ds.Tables[0];
                rows = pro.Rows;

                foreach (DataRow er in rows)
                {
                    txtProdInfo.Text += "<상품 명>\r\n";
                    txtProdInfo.Text += er[0] + "\r\n\r\n";
                }
            }
            else
            {
                foreach (DataRow er in rows)
                {
                    txtProdInfo.Text += "<상품 명>\r\n";
                    txtProdInfo.Text += er[0] + "\r\n\r\n";
                    txtProdInfo.Text += "<이벤트 명>\r\n";
                    txtProdInfo.Text += er[3] + "\r\n\r\n";
                    txtProdInfo.Text += "<이벤트 기간>\r\n";
                    txtProdInfo.Text += er[4] + "~\r\n" + er[5] + "\r\n\r\n";
                    txtProdInfo.Text += "<이벤트 내용>\r\n";
                    txtProdInfo.Text += er[6] + "\r\n\r\n";
                }
            }
            con.Close();
            rows.Clear();
            string barcodeNum = itemGrid.CurrentRow.Cells[2].Value.ToString();
            ProdImage(barcodeNum);
        }

        private void txtBacode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txtMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtReturnMoney.Text = (int.Parse(txtMoney.Text) - int.Parse(txtPrice.Text)).ToString();
                txtReturnMoney.Focus();
            }
            
        }

        private void itemGrid_SelectionChanged(object sender, EventArgs e)
        {
            txtProdInfo.Text = "";
        }

        private void btnGain_Click(object sender, EventArgs e)
        {
            new SalesStatus().Show();
        }
        private void txtReturnMoney_Click(object sender, EventArgs e)
        {
            cursor = txtReturnMoney;
            txtReturnMoney.Text = (int.Parse(txtMoney.Text) - int.Parse(txtPrice.Text)).ToString();
        }

        private void txtReturnMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(txtReturnMoney.Text) >= 0)
                {
                    ProdMinus();
                    SellProdInsert();
                    AutoClosingMessageBox.Show("정상처리되었습니다.", "GD편의점", 2000);
                    itemGrid.Rows.Clear();
                    txtBacode.Clear();
                    txtMoney.Clear();
                    txtPrice.Clear();
                    txtProdInfo.Clear();
                    txtReturnMoney.Clear();
                    pictureBox1.Image = null;
                }
                else
                {
                    AutoClosingMessageBox.Show("미결제 항목이 있습니다", "GD편의점", 2000);
                }
            }
        }

        private void SellProdInsert()
        {
            
            for (int i = 0; i < itemGrid.Rows.Count; i++)
            {
                var con = DbMan.Dbcon(sqlcon);
                var cmd = new SqlCommand("SellLMoneyInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@selldate", DateTime.Now);
                cmd.Parameters.AddWithValue("@barcode", itemGrid.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@count", itemGrid.Rows[i].Cells[4].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void ProdMinus()
        {
            
            for (int i = 0; i < itemGrid.Rows.Count; i++)
            {
                var con = DbMan.Dbcon(sqlcon);
                var cmd = new SqlCommand("SellProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@prodcount", int.Parse(itemGrid.Rows[i].Cells[4].Value.ToString()));
                cmd.Parameters.AddWithValue("@barcode", itemGrid.Rows[i].Cells[2].Value.ToString());
                cmd.ExecuteNonQuery();
            }     
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            CardPay cp = new CardPay();
            if (txtPrice.Text != "0")
            {  
                cp.Show();
                this.Hide();
                cp.txtMoney.Text = this.txtPrice.Text;
                cp.btnOK.Click += BtnOK_Click;
                cp.btnCancel.Click += BtnCancel_Click;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CardPay cp = new CardPay();
            cp.Close();
            this.Show();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            CardPay cp = new CardPay();
            if (cp.txtCardNum.Text =="" || cp.txtYear.Text == "" || cp.txtMonth.Text == "")
            {
                MessageBox.Show("카드 정보를 모두 입력해주세요");
                return;
            }
            else if(cp.txtCardCom.Text =="")
            {
                MessageBox.Show("카드 정보를 조회해 주세요.");
            }
            else
            {
                CardPayDB();
                ProdMinus();
                itemGrid.Rows.Clear();
                txtBacode.Clear();
                txtMoney.Clear();
                txtPrice.Clear();
                txtProdInfo.Clear();
                txtReturnMoney.Clear();
                pictureBox1.Image = null;
                cp.Close();
                this.Show();
            }           
        }

        private void CardPayDB()
        {
            CardPay cp = new CardPay();
            int j = 0;
            for (int i = 0; i < itemGrid.Rows.Count; i++)
            {
                MessageBox.Show(cp.txtYear.Text + "-" + cp.txtMonth.Text + "-01");
                var con = DbMan.Dbcon(sqlcon);
                var cmd = new SqlCommand("SellCardInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@selldate", DateTime.Now);
                cmd.Parameters.AddWithValue("@barcode", itemGrid.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@count", itemGrid.Rows[i].Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("@cardCom", cp.txtCardCom.Text);
                cmd.Parameters.AddWithValue("@cardDate", DateTime.Parse(cp.txtYear.Text + "-" + cp.txtMonth.Text + "-01"));
                //DateTime.Parse(cp.txtYear.Text + "-" + cp.txtMonth.Text + "-01")
                cmd.Parameters.AddWithValue("@cardNum", cp.txtCardNum.Text);
                j = cmd.ExecuteNonQuery();
            }
                AutoClosingMessageBox.Show("정상처리되었습니다.", "GD편의점", 2000);
            
        }
    }
}
