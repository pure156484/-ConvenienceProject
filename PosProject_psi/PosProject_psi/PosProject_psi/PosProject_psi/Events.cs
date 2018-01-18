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
    public partial class Events : Form
    {
        List<Event> list = new List<Event>();
        DataSet ds;
        DataGridView myView;
        DataTable EventsTable;
        public Events()
        {
            InitializeComponent();
        }

        // 행사 정보 그리드뷰에 띄우기
        private void Events_Load(object sender, EventArgs e)
        {
            ResetGridView();
        }

        // 그리드뷰 초기화
        public void ResetGridView()
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("EventsLoad", con);

                ds = new DataSet();
                adapter.Fill(ds);
                EventsView(ds);
            }
        }

        // 그리드뷰 초기화후 띄우기
        private void EventsView(DataSet ds)
        {
            EventsGridView.Rows.Clear();

            myView = new DataGridView();

            EventsGridView.ColumnCount = 5;
            EventsGridView.Columns[0].Name = "NO";
            EventsGridView.Columns[1].Name = "행사명";
            EventsGridView.Columns[2].Name = "행사시작";
            EventsGridView.Columns[3].Name = "행사끝";
            EventsGridView.Columns[4].Name = "행사정보";

            EventsTable = ds.Tables[0];
            DataRowCollection rows = EventsTable.Rows;
            foreach (DataRow dr in rows)
            {
                string[] row =
                {
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString()
                };
                EventsGridView.Rows.Add(row);
            }
        }

        // 행사 등록 버튼
        private void btn_Add_Click(object sender, EventArgs e)
        {
            EventsAdd ea = new EventsAdd();
            ea.Owner = this;
            ea.Show();
        }

        // 클릭시 텍스트 박스에 띄우기
        private void EventsGridView_Click(object sender, EventArgs e)
        {
            EventsInfo.Text = "";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("viewEventInfo", con))
                {
                    cmd.Parameters.AddWithValue("@event_num", EventsGridView.CurrentRow.Cells[0].Value.ToString());
                    cmd.CommandType = CommandType.StoredProcedure;

                    var sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        EventsInfo.Text += "<행사명>\r\n";
                        EventsInfo.Text += sdr[1] + "\r\n\r\n";
                        EventsInfo.Text += "<행사기간>\r\n";
                        EventsInfo.Text += sdr[2] + " ~ " + sdr[3] + "\r\n\r\n";
                        EventsInfo.Text += "<행사정보>\r\n";
                        EventsInfo.Text += sdr[4] + "\r\n\r\n";
                        EventsInfo.Text += "<행사증정>\r\n";
                        EventsInfo.Text += sdr[5] + "\r\n\r\n";
                        EventsInfo.Text += "<행사할인>\r\n";
                        EventsInfo.Text += sdr[6] + "\r\n\r\n";
                    }
                }
            }
        }

        // 행사 수정 버튼
        private void btn_Modi_Click(object sender, EventArgs e)
        {
            EventsModi em = new EventsModi();
            em.Owner = this;
            em.Show();
        }

        // 행사 삭제 버튼
        private void btn_Del_Click(object sender, EventArgs e)
        {
            EventsInfo.Text = "";

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("DelEvents", con))
                {
                    cmd.Parameters.AddWithValue("@event_num", this.EventsGridView.CurrentRow.Cells[0].Value.ToString());
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("삭제 되었습니다.");
                        ResetGridView();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("삭제하실 내용을 선택해주세요.");
                        return;
                    }
                }
            }
        }

        // 행사 검색 버튼
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < EventsGridView.RowCount; i++)
            {
                if (EventsGridView.Rows[i].Cells[1].Value.ToString() == txtSearch.Text)
                {
                    EventsGridView.CurrentCell = EventsGridView.Rows[i].Cells[0];
                    flag = true;

                }
            }
            if (!flag)
            {
                this.EventsInfo.Text = null;
                MessageBox.Show("행사가 존재하지 않습니다.");
            }

            EventsInfo.Text = "";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("viewEventInfo", con))
                {
                    cmd.Parameters.AddWithValue("@event_num", EventsGridView.CurrentRow.Cells[0].Value.ToString());
                    cmd.CommandType = CommandType.StoredProcedure;

                    var sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        EventsInfo.Text += "<행사명>\r\n";
                        EventsInfo.Text += sdr[1] + "\r\n\r\n";
                        EventsInfo.Text += "<행사기간>\r\n";
                        EventsInfo.Text += sdr[2] + " ~ " + sdr[3] + "\r\n\r\n";
                        EventsInfo.Text += "<행사정보>\r\n";
                        EventsInfo.Text += sdr[4] + "\r\n\r\n";
                    }
                }
            }
        }
    }
}
