using CommonProject;
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
    public partial class EmployeeModi : Form
    {
        public EmployeeModi()
        {
            InitializeComponent();
        }

        // 번호로 직원 검색
        private void btnUserNameSearch_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("EmployeeModiPhoneSearch", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@employee_phone", this.txtMobile.Text);
                        con.Open();
                        var sdr = cmd.ExecuteReader();

                        if (!sdr.HasRows)
                        {
                            componentInit();
                            MessageBox.Show("직원이 존재하지 않습니다.");
                            return;
                        }
                        else
                        {
                            while (sdr.Read())
                            {
                                this.txtName.Text = sdr["employee_name"].ToString();
                                this.txtMobile.Text = sdr["employee_phone"].ToString();
                                this.txtPosition.Text = sdr["employee_position"].ToString();
                                this.txtAddr.Text = sdr["employee_address"].ToString();
                                this.txtSalary.Text = sdr["employee_salary"].ToString();
                                this.txtHours.Text = sdr["employee_hours"].ToString();
                                this.txtTSalary.Text = sdr["employee_total_salary"].ToString();
                               // this.txtBirth.Text = sdr["employee_pk"].ToString();
                            }
                            sdr.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("전화번호를 입력해주세요.");
            }
        }

        // 직원 수정
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {

                    using (var cmd = new SqlCommand("EmployeeModiAdd", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@employee_name", this.txtName.Text);
                        cmd.Parameters.AddWithValue("@employee_phone", this.txtMobile.Text);
                        cmd.Parameters.AddWithValue("@employee_position", this.txtPosition.Text);
                        cmd.Parameters.AddWithValue("@employee_address", this.txtAddr.Text);
                        cmd.Parameters.AddWithValue("@employee_salary", this.txtSalary.Text);
                        cmd.Parameters.AddWithValue("@employee_hours", this.txtHours.Text);
                        cmd.Parameters.AddWithValue("@employee_total_salary", this.txtTSalary.Text);
                        //cmd.Parameters.AddWithValue("@employee_pk", this.txtBirth.Text);

                        con.Open();
                        componentInit();

                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("수정 되었습니다.");
                        EmployeeManagement emg = (EmployeeManagement)Owner;
                        emg.ResetGridView();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("수정하실 직원을 검색해주세요.");
                            return;
                        }
                    }
                } 
            }
        
        // 입력후 초기화
        private void componentInit()
        {
            this.txtName.Text = txtMobile.Text = txtPosition.Text = txtAddr.Text = txtSalary.Text = txtHours.Text = txtTSalary.Text = "";
            this.txtName.Focus();
        }
    }
}
