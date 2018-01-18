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
    public partial class EventsModi : Form
    {
        public EventsModi()
        {
            InitializeComponent();
        }

        // 행사명으로 행사 검색
        private void btnUserNameSearch_Click(object sender, EventArgs e)
        {
            if (txtEName.Text != "")
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("EventsModiNameSearch", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@event_name", this.txtEName.Text);
                        con.Open();
                        var sdr = cmd.ExecuteReader();

                        if (!sdr.HasRows)
                        {
                            MessageBox.Show("행사명을 다시 입력해주세요.");
                            return;
                        }
                        else
                        {
                            while (sdr.Read())
                            {
                                this.txtEName.Text = sdr["event_name"].ToString();
                                this.txtEInfo.Text = sdr["event_summary"].ToString();
                                EventPeriod1.Text = sdr["event_start"].ToString();
                                EventPeriod2.Text = sdr["event_end"].ToString();
                            }
                            sdr.Close();
                        }
                    }
                }
            }
        }

        // 행사 수정
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("EventsModiAdd", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@event_name", this.txtEName.Text);
                    cmd.Parameters.AddWithValue("@event_summary", this.txtEInfo.Text);
                    cmd.Parameters.AddWithValue("@event_start", EventPeriod1.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@event_end", EventPeriod2.Value.ToShortDateString());
                    
                    con.Open();
                    componentInit();

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("수정 되었습니다.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("수정 실패");
                        return;
                    }
                }
            }
        }

        // 입력후 초기화
        private void componentInit()
        {
            this.txtEName.Text = txtEInfo.Text = "";
            EventPeriod1.Value = DateTime.Now;
            EventPeriod2.Value = DateTime.Now;
            this.txtEName.Focus();
        }
    }
}
