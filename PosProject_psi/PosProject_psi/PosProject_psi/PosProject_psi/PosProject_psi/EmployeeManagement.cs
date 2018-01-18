using PosProject_psi;
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
    public partial class EmployeeManagement : Form
    {
        List<Employee> list = new List<Employee>();
        DataSet ds;
        DataGridView myView;
        DataTable employeeTable;

        public EmployeeManagement()
        {
            InitializeComponent();
        }

        // 직원 정보 그리드뷰에 띄우기
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            ResetGridView();
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
                EmployeeView(ds);
            }
        }

        // 그리드뷰 초기화후 띄우기
        private void EmployeeView(DataSet ds)
        {
            EmployeeGridView.Rows.Clear();

            myView = new DataGridView();

            EmployeeGridView.ColumnCount = 9;
            EmployeeGridView.Columns[0].HeaderText = "NO";
            EmployeeGridView.Columns[1].HeaderText = "직원명";
            EmployeeGridView.Columns[2].HeaderText = "전화번호";
            EmployeeGridView.Columns[3].HeaderText = "직책";
            EmployeeGridView.Columns[4].HeaderText = "주소";
            EmployeeGridView.Columns[5].HeaderText = "시급";
            EmployeeGridView.Columns[6].HeaderText = "노동시간";
            EmployeeGridView.Columns[7].HeaderText = "월급";
            EmployeeGridView.Columns[8].HeaderText = "주민번호";

            employeeTable = ds.Tables[0];
            DataRowCollection rows = employeeTable.Rows;
            foreach (DataRow dr in rows)
            {
                string[] row =
                {
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString()
                };
                EmployeeGridView.Rows.Add(row);
            }
        }

        // 직원 등록 버튼
        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            new EmployeeAdd().Show();
        }

        // 직원 수정 버튼
        private void btn_Modi_Click(object sender, EventArgs e)
        {
            new EmployeeModi().Show();
        }

        // 직원 삭제 버튼
        private void btn_Del_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("DelEmployee", con))
                {
                    cmd.Parameters.AddWithValue("@employee_num", this.EmployeeGridView.CurrentRow.Cells[0].Value.ToString());
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

        // 직원 검색 버튼
        private void btn_Confirm_Click(object sender, EventArgs e)

        {
            bool flag = false;
            for (int i = 0; i < EmployeeGridView.RowCount; i++)
            {
                if (EmployeeGridView.Rows[i].Cells[2].Value.ToString() == txtSearch.Text)
                {
                    EmployeeGridView.CurrentCell = EmployeeGridView.Rows[i].Cells[0];
                    flag = true;

                }
            }

            if (!flag)
            {
                MessageBox.Show("없는 전화번호입니다.");
            }
        }
    }
}