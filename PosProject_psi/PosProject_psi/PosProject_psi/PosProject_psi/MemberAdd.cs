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

namespace CommonProject
{
    public partial class MemberAdd : Form
    {
        public MemberAdd()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (CheckName() && CheckPhone())
            {
                string name = this.txtName.Text;

                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("MemberAdd", con))
                    {
                        // 실행할 쿼리문이 저장프로시저에 있다.
                        cmd.CommandType = CommandType.StoredProcedure;

                        // 저장프로시저 실행에 필요한 파라메터를 지정
                        cmd.Parameters.AddWithValue("@user_name", name);
                        cmd.Parameters.AddWithValue("@user_phone", cboPhone1.SelectedItem.ToString() + txtPhone2.Text + txtPhone3.Text);
                        cmd.Parameters.AddWithValue("@user_date", birth.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@user_gender", this.cboGender.Text);
                        con.Open();

                        int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다.
                        if (i == 1)
                        {
                            MessageBox.Show("저장이 잘 되었습니다!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("저장 실패");
                            return;
                        }
                    }
                }
            }
        }

        private bool CheckPhone()
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("[MemberAddPhoneSelect]", con))
                {
                    // 실행할 쿼리문이 저장프로시저에 있다.
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_phone", cboPhone1.SelectedItem.ToString() + txtPhone2.Text + txtPhone3.Text);
                    con.Open();

                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        MessageBox.Show("중복되는 휴대폰번호가 있습니다.");
                        sdr.Close();
                        con.Close();
                        return false;
                    }
                    else
                    {
                        sdr.Close();
                        con.Close();
                        return true;
                    }
                }
            }
        }

        private bool CheckName()
        {
            if (this.txtName.Text == "")
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

        private void MemberAdd_Load(object sender, EventArgs e)
        {
            birth.Value = new DateTime(1753, 01, 01);
        }
    }
}