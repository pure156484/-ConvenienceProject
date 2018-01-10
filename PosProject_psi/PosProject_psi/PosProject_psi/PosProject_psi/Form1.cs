using CommonProject;
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
    public partial class MainForm : Form
    {
        SqlConnection sqlcon = null;
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
            itemGrid.Columns[5].Name = "비 고";
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
            itemGrid.CurrentRow.Cells[3].Value = price * int.Parse(itemGrid.CurrentRow.Cells[4].Value.ToString());
            price = int.Parse(itemGrid.CurrentRow.Cells[3].Value.ToString()) / int.Parse(prodCount);
            //txtPrice.Text = itemGrid.CurrentRow.Cells[3].Value.ToString();
            GiveMoney();
            prodCount = "";
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
        }

        private void InputInfo()
        {
            if(cursor == txtMoney)
            {
                txtReturnMoney.Text = (int.Parse(txtMoney.Text) - int.Parse(txtPrice.Text)).ToString();
            }
            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("ProdRegist", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@prodNum", txtBacode.Text);
            var er = cmd.ExecuteReader();
            while (er.Read())
            {
                itemGrid.Rows.Add(noCount, er.GetString(0), er.GetString(1), er.GetInt32(2), 1);
                price = er.GetInt32(2);
                bacode = er.GetString(1);
            }
            for (int i = 0; i < itemGrid.Rows.Count-1; i++)
            {
                if(itemGrid.Rows[i].Cells[2].Value.ToString() == bacode)
                {
                    itemGrid.Rows[i].Cells[4].Value = int.Parse(itemGrid.Rows[i].Cells[4].Value.ToString()) + 1;
                    itemGrid.Rows.Remove(itemGrid.Rows[itemGrid.Rows.Count - 1]);
                    noCount--;
                }
            }
            txtBacode.Text = "";
            noCount++;
            con.Close();
            GiveMoney();
            if (txtPrice.Text == "0")
            {
                MessageBox.Show("일치하는 상품이 없습니다.");
                noCount--;
            }
            prodCount = "";
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
            cursor = null;
        }

        private void txtBacode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btnGain_Click(object sender, EventArgs e)
        {
            new SalesStatus().Show();
        }
    }
}
