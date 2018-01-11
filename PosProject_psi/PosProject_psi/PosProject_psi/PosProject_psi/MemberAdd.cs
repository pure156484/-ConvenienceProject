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
            string name = this.txtName.Text;
            string mobile = this.txtMobile.Text.Trim().Replace(" ", "");
            string date = this.txtBirth.Text;

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("MemberAdd", con))
                {
                    // 실행할 쿼리문이 저장프로시저에 있다.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 저장프로시저 실행에 필요한 파라메터를 지정
                    cmd.Parameters.AddWithValue("@user_name", name);
                    cmd.Parameters.AddWithValue("@user_phone", mobile);
                    cmd.Parameters.AddWithValue("@user_date", date);
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
}