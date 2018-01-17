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
    public partial class CardPay : Form
    {
        SqlDataAdapter adapter;
        DataSet ds;
        SqlConnection sqlcon = null;
        TextBox cursor;
        public CardPay()
        {
            InitializeComponent();
        }

        private void txtCardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                cursor.Text += sender.ToString().Substring(sender.ToString().Length - 1);
            }
            catch (NullReferenceException)
            {
                txtCardNum.Text += sender.ToString().Substring(sender.ToString().Length - 1);
            }
        }

        private void txtCardNum_Click(object sender, EventArgs e)
        {
            cursor = txtCardNum;
        }

        private void txtYear_Click(object sender, EventArgs e)
        {
            cursor = txtYear;
        }

        private void txtMonth_Click(object sender, EventArgs e)
        {
            cursor = txtMonth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCardNum.Text == "" || txtYear.Text == "" || txtMonth.Text == "")
            {
                MessageBox.Show("카드 정보를 모두 입력해주세요");
                return;
            }
            else if (txtYear.Text.Length != 4)
            {
                MessageBox.Show("년도는 4자를 입력해야 합니다. Ex)2018");
                return;
            }
            else if (txtMonth.Text.Length != 2)
            {
                MessageBox.Show("월은 2자를 입력해야 합니다. Ex)01");
                return;
            }
            else if (int.Parse(txtYear.Text) < int.Parse(DateTime.Now.Year.ToString()))
            {
                MessageBox.Show("카드 유효기간은 현재날짜보다 적을수 없습니다");
                return;
            }
            else if (!(int.Parse(txtMonth.Text) < 13 && int.Parse(txtMonth.Text) >= int.Parse(DateTime.Now.Month.ToString())))
            {
                MessageBox.Show("카드 유효기간은 현재날짜보다 적거나 1~12월 사이여야 합니다");
            }

            string cardNumSix = txtCardNum.Text.Substring(0, 6);

            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("CardSearch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cardNum", cardNumSix);
            con.Open();

            adapter = DbMan.DbAdap(adapter);
            adapter.SelectCommand = cmd;
            ds = DbMan.DbDs(ds);
            adapter.Fill(ds);
            DataTable pro = ds.Tables[0];
            DataRowCollection rows = pro.Rows;

            groupBox1.Visible = true;

            if (txtCardNum.Text.Length != 16)
            {
                MessageBox.Show("카드번호는 16자리 입니다.");
                return;
            }

            foreach (DataRow er in rows)
            {
                txtCardCom.Text = er["card_name"].ToString();
                txtCardSilp.Text = er["card_slip"].ToString();
                txtCardBrand.Text = er["card_brand"].ToString();
                txtCardC_C.Text = er["card_c_c"].ToString();
                txtCardP_C.Text = er["card_p_c"].ToString();
            }
            if (txtCardCom.Text == "")
            {
                MessageBox.Show("잘못된 카드정보입니다.");
                return;
            }
            switch (txtCardCom.Text)
            {
                case "신한카드":
                    lblCardType.Text = txtCardCom.Text;
                    lblDiscountPer.Text = "3% 할인!";
                    txtDiscount.Text = (int.Parse(txtMoney.Text) * 0.03).ToString();
                    break;
                case "BC카드":
                    lblCardType.Text = txtCardCom.Text;
                    lblDiscountPer.Text = "2% 할인!";
                    txtDiscount.Text = (int.Parse(txtMoney.Text) * 0.02).ToString();
                    break;
                case "비씨카드":
                    lblCardType.Text = txtCardCom.Text;
                    lblDiscountPer.Text = "5% 할인!";
                    txtDiscount.Text = (int.Parse(txtMoney.Text) * 0.05).ToString();
                    break;
                case "NH농협카드":
                    lblCardType.Text = txtCardCom.Text;
                    lblDiscountPer.Text = "2% 할인!";
                    txtDiscount.Text = (int.Parse(txtMoney.Text) * 0.02).ToString();
                    break;
                case "KB카드":
                    lblCardType.Text = txtCardCom.Text;
                    lblDiscountPer.Text = "1% 할인!";
                    txtDiscount.Text = (int.Parse(txtMoney.Text) * 0.01).ToString();
                    break;
                case "롯데카드":
                    lblCardType.Text = txtCardCom.Text;
                    lblDiscountPer.Text = "3% 할인!";
                    txtDiscount.Text = (int.Parse(txtMoney.Text) * 0.03).ToString();
                    break;
                case "삼성카드":
                    lblCardType.Text = txtCardCom.Text;
                    lblDiscountPer.Text = "1% 할인!";
                    txtDiscount.Text = (int.Parse(txtMoney.Text) * 0.01).ToString();
                    break;

                default:
                    lblCardType.Text = txtCardCom.Text;
                    lblDiscountPer.Text = "할인 없음";
                    break;
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
                txtCardNum.Text = "";
                txtYear.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cursor.Text = cursor.Text.Substring(0,cursor.Text.Length-1);
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
    }
}
