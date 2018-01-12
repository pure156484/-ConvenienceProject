using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class MailSend : Form
    {
        string emp_name;
        string emp_phone;
        string emp_positon;
        string fileName;
        string emp_email;

        public MailSend()
        {
            InitializeComponent();
        }

        private void MailSend_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("MailEmployeeSelect", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    var sdr = cmd.ExecuteReader();

                    if (!sdr.HasRows)
                    {
                        MessageBox.Show("등록 된 직원이 없습니다.");
                        return;
                    }
                    else
                    {
                        while (sdr.Read())
                        {
                            cboEmployee.Items.Add(sdr["employee_name"].ToString() + " (" + sdr["employee_position"].ToString() + ")");
                            emp_name = sdr["employee_name"].ToString();
                            emp_phone = sdr["employee_phone"].ToString();
                            emp_positon = sdr["employee_position"].ToString();
                            emp_email = sdr["employee_email"].ToString();
                        }
                        sdr.Close();
                    }

                }
            }
        }

        private void btnFileAdd_Click(object sender, EventArgs e)
        {
            if (ofdFlie.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new
                StreamReader(ofdFlie.FileName);
                fileName = ofdFlie.FileName;
                txtFileName.Text = fileName;
                sr.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string[] Employee_name_split = cboEmployee.SelectedItem.ToString().Split('(');

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("MailEmployeeSend", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@employees_name", Employee_name_split[0]);

                    con.Open();
                    var sdr = cmd.ExecuteReader();

                    if (!sdr.HasRows)
                    {
                        MessageBox.Show("등록 된 직원이 없습니다.");
                        return;
                    }
                    else
                    {
                        while (sdr.Read())
                        {
                            cboEmployee.Items.Add(sdr["employee_name"].ToString());
                            emp_name = sdr["employee_name"].ToString();
                            emp_phone = sdr["employee_phone"].ToString();
                            emp_positon = sdr["employee_position"].ToString();
                            Mail();
                        }
                        sdr.Close();
                    }
                }
            }
        }

        private void Mail()
        {
            try
            {
                MailAddress fromAddr = new MailAddress("iotgd2017069@gmail.com", "구디편의점", Encoding.UTF8);

                MailAddress toAddr = new MailAddress("iotgd2017069@gmail.com");

                SmtpClient client = new SmtpClient("smtp.naver.com", 587);
                //client.Host = "smtp.naver.com";
                //client.Port = 465;

                MailMessage msg = new MailMessage(fromAddr, toAddr);

                string sp = "";
                sp += "======= 요청 직원 정보 =======\n";
                sp += "이름: " + emp_name + "\n";
                sp += "전화번호: " + emp_phone + "\n";
                sp += "직책: " + emp_positon + "\n";
                sp += "==========================\n\n";
                sp += txtContents.Text;

                msg.Subject = txtTitle.Text;
                msg.SubjectEncoding = Encoding.UTF8;
                msg.Body = sp;
                msg.BodyEncoding = Encoding.UTF8;

                if (fileName == null)
                {

                }
                else
                {
                    Attachment attachment;
                    attachment = new Attachment(fileName);
                    msg.Attachments.Add(attachment);
                }

                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.Credentials = new NetworkCredential("abc@abc.com", "abc");
                client.Credentials = new NetworkCredential("smtp.gmail.com", "iotgd0829!");

                client.Send(msg);
                MessageBox.Show("메일 전송하였습니다.");
            }
            catch (Exception)
            {
                MessageBox.Show("메일을 전송 할 수 없습니다.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            2
        }
    }
}
