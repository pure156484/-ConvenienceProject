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
            if (checkTextBox() && CheckPK())
            {
                string event_name = this.txtEName.Text;
                string event_summary = this.txtEInfo.Text;
                string event_start = EventPeriod1.Value.ToShortDateString();
                string event_end = EventPeriod2.Value.ToShortDateString();
                string event_add = this.txtPlus.Text;
                string event_discount = this.txtSale.Text;
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
                {
                    if (radioButton1.Checked)
                    {
                        using (var cmd = new SqlCommand("EventsAdd", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@event_name", event_name);
                            cmd.Parameters.AddWithValue("@event_start", event_start);
                            cmd.Parameters.AddWithValue("@event_end", event_end);
                            cmd.Parameters.AddWithValue("@event_summary", event_summary);
                            cmd.Parameters.AddWithValue("@event_add", event_add);
                            cmd.Parameters.AddWithValue("@event_discount", event_discount);
                            con.Open();
                            componentInit();

                            int i = cmd.ExecuteNonQuery();
                            if (i == 1)
                            {
                                MessageBox.Show("등록 되었습니다.");
                                Events ev = (Events)Owner;
                                ev.ResetGridView();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("등록 실패");
                                return;
                            }
                        } 
                    }
                    else
                    {
                        using (var cmd = new SqlCommand("EventsAdd2", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@event_name", event_name);
                            cmd.Parameters.AddWithValue("@event_start", event_start);
                            cmd.Parameters.AddWithValue("@event_end", event_end);
                            cmd.Parameters.AddWithValue("@event_summary", event_summary);
                            cmd.Parameters.AddWithValue("@event_add", event_add);
                            cmd.Parameters.AddWithValue("@event_discount", event_discount);
                            con.Open();
                            componentInit();

                            int i = cmd.ExecuteNonQuery();
                            if (i == 1)
                            {
                                MessageBox.Show("등록 되었습니다.");
                                Events ev = (Events)Owner;
                                ev.ResetGridView();
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
        }

        // 중복 검사
        private bool CheckPK()
        {
            string event_name = this.txtEName.Text.Trim();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("EvencheckPk", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@event_name", event_name);

                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        MessageBox.Show("이미 등록된 행사입니다.");
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
            this.txtEName.Text = txtEInfo.Text = txtPlus.Text = txtSale.Text = "";
            radioButton1.Checked = radioButton2.Checked = false;
            txtPlus.ReadOnly = txtSale.ReadOnly = true;
            EventPeriod1.Value = EventPeriod2.Value = DateTime.Now;
            this.txtEName.Focus();
        }

        // 공백 확인
        private bool checkTextBox()
        {
            if (this.txtEInfo.Text == "" || this.txtEName.Text == "" || this.txtPlus.Text == "" && this.txtSale.Text == "")
            {
                componentInit();
                MessageBox.Show("등록할 값을 입력해주세요.");
                return false;
            }
            else
            {
                return true;
            }
        }

        // 증정, 할인 라디오 버튼
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtPlus.ReadOnly = false;
                txtSale.ReadOnly = true;
                txtSale.Text = "";
            }
            else if(radioButton2.Checked)
            {
                txtSale.ReadOnly = false;
                txtPlus.ReadOnly = true;
                txtPlus.Text = "";
            }
        }
    }
}
