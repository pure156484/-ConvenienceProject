using SoHotLib;
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
    public partial class LoginAlterPass : Form
    {
        public LoginAlterPass()
        {
            InitializeComponent();
        }

        private void btn_Alter_Click(object sender, EventArgs e)
        {
            string LoginPhone = txt_phone.Text.Trim();
            string LoginPk = txt_pk_1.Text + "-" + txt_pk_2.Text;
            string LoginPass = txt_pass.Text.Trim();

            string NewPass = txt_NewPass.Text.Trim();
            string NewPassCheck = txt_NewPassCheck.Text.Trim();

            if (NewPass == NewPassCheck)
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("LoginPassAlter", con))
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@employee_phone", LoginPhone);
                        cmd.Parameters.AddWithValue("@employee_pk", LoginPk);
                        cmd.Parameters.AddWithValue("@employee_pass", LoginPass);

                        cmd.Parameters.AddWithValue("@employee_NewPass", NewPassCheck);

                        var sdr = cmd.ExecuteReader();

                        if (sdr.HasRows)
                        {
                            sdr.Close();
                            con.Close();
                            MessageBox.Show("저장 되었습니다.");
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("입력하신 정보가 틀렸습니다. 다시 확인해주세요.");
                            return;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("새 비밀번호가 올바르지 않습니다.");
                return;
            }
            
        }
    }
}
