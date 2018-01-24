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
using CommonProject;
using System.Security.Cryptography;

namespace PosProject_psi
{
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }

        // 직원 등록
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (checkTextBox() && CheckPK())
            {
                string employee_name = this.txtName.Text;
                string employee_phone = this.txtMobile.Text.Trim().Replace(" ", "");
                string employee_position = this.txtPosition.Text;
                string employee_address = this.txtAddr.Text;
                string employee_salary = this.txtSalary.Text;
                string employee_hours = this.txtHours.Text;
                string employee_total_salary = this.txtTSalary.Text;
                string employee_pk = this.txtBirth.Text;
                string employee_pass = this.txtPass.Text;
                
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("EmployeeAdd", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@employee_name", employee_name);
                        cmd.Parameters.AddWithValue("@employee_phone", employee_phone);
                        cmd.Parameters.AddWithValue("@employee_position", employee_position);
                        cmd.Parameters.AddWithValue("@employee_address", employee_address);
                        cmd.Parameters.AddWithValue("@employee_salary", employee_salary);
                        cmd.Parameters.AddWithValue("@employee_hours", employee_hours);
                        cmd.Parameters.AddWithValue("@employee_total_salary", employee_total_salary);
                        cmd.Parameters.AddWithValue("@employee_pk", employee_pk);
                        //using (MD5 md5Hash = MD5.Create())
                        //{
                        //    string hash = GetMd5Hash(md5Hash, employee_pass);
                        //    // MessageBox.Show(hash + " : 비밀번호"); // 암호화 잘됨
                        //    cmd.Parameters.AddWithValue("@employee_pass", hash);
                        //}
                        cmd.Parameters.AddWithValue("@employee_pass", employee_pass);

                        con.Open();
                        componentInit();

                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("등록 되었습니다.");
                            EmployeeManagement emg = (EmployeeManagement)Owner;
                            emg.ResetGridView();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("등록 실패");
                            return;
                        }
                    }
                } 
            }
        }

        // 중복 검사
        private bool CheckPK()
        {
            string employee_phone = this.txtMobile.Text.Trim().Replace(" ", "");
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("EmpcheckPK", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@employee_phone", employee_phone);

                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        MessageBox.Show("이미 등록된 전화번호입니다.");
                        componentInit();
                        sdr.Close();
                        con.Close();
                        return false;
                    }
                    else
                    {
                        sdr.Close();
                        return true;
                    }
                }
            }
        }

        // 입력후 초기화
        private void componentInit()
        {
            this.txtName.Text = txtMobile.Text = txtPosition.Text = txtAddr.Text = txtSalary.Text = txtHours.Text = txtTSalary.Text = txtBirth.Text = "";
            this.txtName.Focus();
        }

        // 공백 확인
        private bool checkTextBox()
        {
            if (this.txtName.Text == "" || this.txtMobile.Text == "" || this.txtMobile.Text == "" || this.txtAddr.Text == "" || this.txtSalary.Text == "" || this.txtHours.Text == "" || this.txtTSalary.Text == "" || this.txtBirth.Text == "")
            {
                MessageBox.Show("등록할 값을 입력해주세요.");
                return false;
            }
            else
            {
                return true;
            }
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
