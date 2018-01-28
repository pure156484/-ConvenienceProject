using PosProject_psi;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonProject
{
    public partial class MemberAdd : Form
    {
        SqlConnection sqlcon;
        SqlDataAdapter adapter;

        public MemberAdd()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 회원 등록 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (CheckName() && CheckPhone())
            {
                string name = this.txtName.Text;
                string phone = cboPhone1.SelectedItem.ToString() + txtPhone2.Text + txtPhone3.Text;

                #region 싱글톤 이전 버전
                /*
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
                */
                #endregion

                var con = DbMan.Dbcon(sqlcon);
                var cmd = new SqlCommand("MemberAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_name", name);
                cmd.Parameters.AddWithValue("@user_phone", phone);
                cmd.Parameters.AddWithValue("@user_date", birth.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@user_gender", this.cboGender.Text);
                con.Open();
                int i = cmd.ExecuteNonQuery(); // select을 제외한 나머지는 ExecuteNonQuery 사용한다.
                if (i == 1)
                {
                    MessageBox.Show("저장이 잘 되었습니다!");
                    if (MessageBox.Show("회원가입 문자메시지를 발송하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SmsSend(name, phone);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("저장 실패");
                    return;
                }
            }
        }

        /// <summary>
        /// 회원 등록 완료 시 SMS 전송 이벤트
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        private void SmsSend(string name, string phone)
        {
            SMSClass sms = new SMSClass();
            string Message = name + "님 GD편의점에 가입을 축하드립니다.";

            sms.SetUser("hwjeong0612", "1q2w3e4r!");

            sms.Add(phone, "05054287777", Message, "", "", "", 0);

            if (!sms.Connect())
            {
                //Console.WriteLine("메세지 전송오류\n" + phone);
                MessageBox.Show("메세지 전송오류\n" + phone);
            }

            int resval = sms.Send();
            if (resval == -1)
            {
                //Console.WriteLine("전송중 오류발생\n" + phone);
                MessageBox.Show("전송중 오류발생\n" + phone);
            }

            MessageBox.Show("전송이 완료되었습니다.");

            sms.Disconnect();
        }

        /// <summary>
        /// 휴대전화번호 유효성 검사
        /// </summary>
        /// <returns></returns>
        private bool CheckPhone()
        {
            #region 싱글톤 이전 버전
            /*
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
            */
            #endregion

            var con = DbMan.Dbcon(sqlcon);
            var cmd = new SqlCommand("MemberAddPhoneSelect", con);
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

        /// <summary>
        /// 이름 유효성 검사
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 회원 등록 로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberAdd_Load(object sender, EventArgs e)
        {
            birth.Value = new DateTime(1753, 01, 01);
        }
    }
}