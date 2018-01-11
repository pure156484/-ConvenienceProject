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

namespace PosProject_psi
{
    public partial class EventsAdd : Form
    {
        public EventsAdd()
        {
            InitializeComponent();
        }

        // 행사 등록
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string event_name = this.txtEName.Text;
            string event_summary = this.txtEInfo.Text;
            string event_start = EventPeriod1.Value.ToShortDateString();
            string event_end = EventPeriod2.Value.ToShortDateString();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("EventsAdd", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@event_name", event_name);
                    cmd.Parameters.AddWithValue("@event_start", event_start);
                    cmd.Parameters.AddWithValue("@event_end", event_end);
                    cmd.Parameters.AddWithValue("@event_summary", event_summary);
                    con.Open();
                    componentInit();

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("등록 되었습니다.");
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
