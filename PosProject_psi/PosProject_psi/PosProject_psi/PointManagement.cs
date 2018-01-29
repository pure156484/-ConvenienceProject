using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class PointManagement : Form
    {

        DataSet ds;
        public PointManagement()
        {
            InitializeComponent();
        }

        private void btn_phone_Click(object sender, EventArgs e)
        {

            if (CheckPhoneTextNull())
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("PointDiscount", con))
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user_phone", cboPhone1.SelectedItem.ToString() + txtPhone2.Text + txtPhone3.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;

                        ds = new DataSet();
                        adapter.Fill(ds);

                        DataRowCollection dataRow = ds.Tables[0].Rows;
                        foreach (DataRow row in dataRow)
                        {
                            this.point_name.Text = row.ItemArray[0].ToString();
                            this.point_phone.Text = row.ItemArray[1].ToString();
                            this.point_day.Text = row.ItemArray[2].ToString().Substring(0, 10);
                            this.point_count.Text = row.ItemArray[3].ToString().Trim();
                        }
                        con.Close();
                    }
                }
            }
        }

        private bool CheckPhoneTextNull()
        {
            if (this.cboPhone1.Text == "")
            {
                MessageBox.Show("전화번호가 입력 되지 않았습니다.");
                return false;
            }
            else if (this.txtPhone2.Text == "")
            {
                MessageBox.Show("전화번호가 입력 되지 않았습니다.");
                return false;
            }
            else if (this.txtPhone3.Text == "")
            {
                MessageBox.Show("전화번호가 입력 되지 않았습니다.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            point_use_point.Text = "";
            point_use_point.Text = point_count.Text;
        }
        private int vals;
        public int Vals
        {
            get { return vals; }
            set { vals = value; }
        }
        private void btn_use_Click(object sender, EventArgs e)
        {
            // System.FormatException: 
            if (point_use_point.Text == "")
            {
                MessageBox.Show("사용할 포인트를 적어 주세요.");
                return;
            }
            try
            {
                int points;
                #region 우석이 코드

                MainForm main = new MainForm();

                int use_point = int.Parse(point_use_point.Text);
                int use_count = int.Parse(point_count.Text);
                //MessageBox.Show(use_point.ToString());
                

                if (use_point <= use_count)
                {
                    points = int.Parse(point_use_point.Text);

                    if (vals > points)
                    {
                        vals = vals - points;
                    }
                    else
                    {
                        MessageBox.Show("계산 금액보다 포인트를 더 사용할 수 없습니다.");
                        return;
                    }
                }
                
                else
                {
                    MessageBox.Show("사용할 수 있는 포인트보다 더 많은 포인트를 적을 순 없습니다.");
                    return;
                }

                this.Hide();

                #endregion
                //  System.NullReferenceException

                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {

                    using (var cmd = new SqlCommand("PointSub", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@user_phone", cboPhone1.SelectedItem.ToString() + txtPhone2.Text + txtPhone3.Text);
                        cmd.Parameters.AddWithValue("@user_point", point_use_point.Text);

                        con.Open();

                        int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다.
                        if (i == 1)
                        {
                            MessageBox.Show("포인트가 사용 하였습니다.");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("포인트 사용 실패 하였습니다.");
                            return;
                        }
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("회원을 확인해주세요.");
            }
        }

        // 현우형 코드
        //private bool CheckPointDb()
        //{
        //    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
        //    {
        //        using (var cmd = new SqlCommand("PointCheck", con))
        //        {
        //            // 실행할 쿼리문이 저장프로시저에 있다.
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@user_phone", cboPhone1.SelectedItem.ToString() + txtPhone2.Text + txtPhone3.Text);
        //            cmd.Parameters.AddWithValue("@user_point", point_use_point.Text);
        //            con.Open();

        //            var sdr = cmd.ExecuteReader();
        //            if (sdr.HasRows)
        //            {
        //                MessageBox.Show("사용 포인트 보다 보유 포인트가 적습니다.");
        //                sdr.Close();
        //                con.Close();
        //                return false;
        //            }
        //            else
        //            {
        //                sdr.Close();
        //                con.Close();
        //                return true;
        //            }
        //        }
        //    }
        //}

        private bool CheckPointTextNull()
        {
            if (this.point_use_point.Text == "" && int.Parse(this.point_use_point.Text) == 0)
            {
                MessageBox.Show("사용 포인트를 입력하지 않았습니다.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void PointManagement_Load(object sender, EventArgs e)
        {
            //this.point_pay.Text = Val.ToString();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckPointTextNull())
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {

                    using (var cmd = new SqlCommand("PointAdd", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@user_phone", cboPhone1.SelectedItem.ToString() + txtPhone2.Text + txtPhone3.Text);
                        cmd.Parameters.AddWithValue("@user_point", point_use_point.Text);

                        con.Open();

                        int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다.
                        if (i == 1)
                        {
                            MessageBox.Show("포인트를 적립 하였습니다.");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("포인트 사용 실패 하였습니다.");
                            return;
                        }
                    }
                }
            }
        }
    }
}
