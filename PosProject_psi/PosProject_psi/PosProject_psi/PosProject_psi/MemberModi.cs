using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class MemberModi : Form
    {
        string users_pk;

        public MemberModi()
        {
            InitializeComponent();
        }

        private void btnUserNameSearch_Click(object sender, EventArgs e)
        {
            if(CheckPhoneSearch())
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("MemberModiPhoneSearch", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@user_phone", cboPhone1.SelectedItem.ToString() + txtPhone2.Text + txtPhone3.Text);
                        con.Open();
                        var sdr = cmd.ExecuteReader();

                        if (!sdr.HasRows)
                        {
                            MessageBox.Show("휴대전화 번호를 다시 한 번 입력해주세요.");
                            return;
                        }
                        else
                        {
                            txtModiUserName.ReadOnly = false;
                            //txtBirth.ReadOnly = false;

                            while (sdr.Read())
                            {
                                users_pk = sdr["user_num"].ToString();
                                this.txtModiUserName.Visible = true;
                                this.txtModiUserName.Text = sdr["user_name"].ToString();
                                this.birth.Visible = true;
                                this.birth.Text = sdr["user_date"].ToString().Substring(0, 10);
                                this.cboGender.Visible = true;
                                this.cboGender.Text = sdr["user_gender"].ToString();
                            }
                            sdr.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("회원이 존재 하지 않습니다.");
            }
        }

        private bool CheckPhoneSearch()
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

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (CheckPhone())
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {

                    using (var cmd = new SqlCommand("MemberModiAdd", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@user_num", users_pk);
                        cmd.Parameters.AddWithValue("@user_name", this.txtModiUserName.Text);
                        cmd.Parameters.AddWithValue("@user_phone", cboPhone1.SelectedItem.ToString() + txtPhone2.Text + txtPhone3.Text);
                        cmd.Parameters.AddWithValue("@user_date", birth.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@user_gender", this.cboGender.Text);

                        con.Open();

                        int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다.
                        if (i == 1)
                        {
                            MessageBox.Show("정상적으로 수정 되었습니다.");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("수정 실패하였습니다.");
                            return;
                        }
                    }
                } 
            }
        }

        private bool CheckPhone()
        {
            if (this.txtModiUserName.Text == "")
            {
                MessageBox.Show("이름이 입력 되지 않았습니다.");
                return false;
            }
            else if (this.cboPhone1.Text == "")
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
            else if (this.birth.Text == "")
            {
                MessageBox.Show("생일이 입력 되지 않았습니다.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void MemberModi_Load(object sender, EventArgs e)
        {
            this.birth.Visible = false;
            this.txtModiUserName.Visible = false;
            this.cboGender.Visible = false;
        }
    }
}
