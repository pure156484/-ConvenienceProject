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
        List<EventsList> list = new List<EventsList>();
        DataSet ds;

        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            ResetGridView();

            // 그리드뷰 디자인
            for (int i = 1; i < EventsGridView.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    EventsGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(214, 236, 250);
                }
                else
                {
                    EventsGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }

            EventsGridView.ColumnCount = 7;
            EventsGridView.Columns[0].Name = "NO";
            EventsGridView.Columns[1].Name = "행사명";
            EventsGridView.Columns[2].Name = "행사시작";
            EventsGridView.Columns[3].Name = "행사끝";
            EventsGridView.Columns[4].Name = "행사정보";
            EventsGridView.Columns[5].Name = "행사증정";
            EventsGridView.Columns[6].Name = "행사할인";
        }

        // 그리드뷰 초기화
        private void ResetGridView()
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("EmployeeLoad", con);

                ds = new DataSet();
                adapter.Fill(ds);
                //EmployeeView(ds);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            new EventsAdd().Show();
        }
    }
}
