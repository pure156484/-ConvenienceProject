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

        }

        private void category_grid_Click(object sender, EventArgs e)
        {
            
        }

        private void Category_Load(object sender, EventArgs e)
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
    }
}
