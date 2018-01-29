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
    public partial class LoginFind : Form
    {
        public LoginFind()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string LoginPhone = txt_phone.Text.Trim();
            string LoginPass = txt_pk_1.Text + "-" + txt_pk_2.Text;
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("LoginPassCheck", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@employee_phone", LoginPhone);
                    cmd.Parameters.AddWithValue("@employee_pk", LoginPass);

                    string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    char[] charArray = chars.ToCharArray();
                    int numPasswd = 10;
                    string newPasswd = string.Empty;
                    int seed = Environment.TickCount;
                    Random rd = new Random(seed);
                    int tempNum = 0;

                    for (int j = 0; j < numPasswd; j++)
                    {
                        tempNum = rd.Next(0, charArray.Length - 1);
                        newPasswd += charArray[tempNum];
                    }

                    cmd.Parameters.AddWithValue("@employee_pass", newPasswd);


                    var sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        string phone = "01083237245";

                        SMSClass sms = new SMSClass();
                        string Message = "임시 비밀번호 입니다. 새 비밀번호로 바꿔주세요.\n" + newPasswd;

                        sms.SetUser("banana52", "wjdxhd58");

                        sms.Add(phone, "01083237245", Message, "", "", "", 0);

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


                        sdr.Close();
                        con.Close();

                        this.Hide();
                        MessageBox.Show(newPasswd);
                    }
                    else
                    {
                        MessageBox.Show("핸드폰 번호 또는 주민번호를 다시 확인해주세요.");
                        return;
                    }
                }
            }
        }
    }
}
