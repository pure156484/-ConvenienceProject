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
    public partial class Category : Form
    {
        DataSet ds;
        private SqlConnection con = null;
        public Category()
        {
            InitializeComponent();
        }

        private void btn_enroll_Click(object sender, EventArgs e)
        {
            string num = category_num.Text.Trim();
            string name = category_name.Text.Trim();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("CategoryModi", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@category_num", num);
                    cmd.Parameters.AddWithValue("@category_name", name);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("저장 되었습니다.");
                        Cate_Reset();
                        ComponentInit();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("저장 실패");
                        return;
                    }
                }
            }
        }

        // 자동 새로고침
        private void Cate_Reset()
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("CategoryLoad", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    con.Close();

                    ds = new DataSet();
                    adapter.Fill(ds);
                    this.category_grid.DataSource = ds.Tables[0];

                    category_grid.Columns[0].HeaderText = "카테고리 번호";
                    category_grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    category_grid.Columns[1].HeaderText = "카테고리 이름";
                    category_grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
        private void Category_Load(object sender, EventArgs e)
        {
            Cate_Reset();
        }

        private void category_grid_Click(object sender, EventArgs e)
        {
            category_num.Text = category_grid.CurrentRow.Cells[0].Value.ToString();
            category_name.Text = category_grid.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = category_name.Text.Trim();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("CategoryAdd", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@category_name", name);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("저장 되었습니다.");
                        Cate_Reset();
                        ComponentInit();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("저장 실패");
                        return;
                    }
                }
            }
            
        }

        // 카테고리 삭제
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string num = category_num.Text.Trim();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("categoryDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    
                    cmd.Parameters.AddWithValue("@category_num", num);

                    adapter.DeleteCommand = cmd;

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("삭제 되었습니다.");
                        Cate_Reset();
                        ComponentInit();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패");

                        return;
                    }

                }
            }
        }
        private void ComponentInit()
        {
            category_name.Text = category_num.Text = "";
        }
    }
}
