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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string nam;
        public string Nam
        {
            get { return nam; }
            set { nam = value; }
        }

        // 로그인
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string LoginPhone = txt_phone.Text.Trim();
            string LoginPass = txt_pass.Text.Trim();
            string LoginName = label1.Text;
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("LoginCheck", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.Parameters.AddWithValue("@login_name", LoginName);
                    cmd.Parameters.AddWithValue("@login_phone", LoginPhone);
                    cmd.Parameters.AddWithValue("@login_pass", LoginPass);
                    var sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        // MessageBox.Show(sdr["employee_name"].ToString());

                        MainForm mf = new MainForm();
                        mf.Owner = this;
                        Nam = sdr["employee_name"].ToString();

                        //  MessageBox.Show(Name);
                        //MainForm mf = new MainForm();
                        //mf.Name = sendName.ToString();

                        //  MessageBox.Show(Name);
                    }

                    if (sdr.HasRows)
                    {
                        new MainForm(nam).Show();
                        sdr.Close();
                        con.Close();

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("비밀번호 또는 아이디를 다시 확인해주세요.");
                        return;
                    }
                }
            }
           // new MainForm().Show();


        }
        // 비밀번호 찾기
        private void button1_Click(object sender, EventArgs e)
        {
            new LoginFind().Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Alter_Click(object sender, EventArgs e)
        {
            new LoginAlterPass().Show();
        }
    }
}
