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
    public partial class PointManagement : Form
    {
        
        DataSet ds;
        public PointManagement()
        {
            InitializeComponent();
        }

        private void btn_phone_Click(object sender, EventArgs e)
        {
            string point = this.point_main_phone.Text.Trim();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                using (var cmd = new SqlCommand("PointDiscount", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_phone", point);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    ds = new DataSet();
                    adapter.Fill(ds);

                    DataRowCollection dataRow = ds.Tables[0].Rows;
                    foreach (DataRow row in dataRow)
                    {
                        this.point_name.Text = row.ItemArray[1].ToString();
                        this.point_phone.Text = row.ItemArray[2].ToString();
                        this.point_day.Text = row.ItemArray[3].ToString();
                        this.point_count.Text = row.ItemArray[4].ToString();
                        //  this.point_name(row.ItemArray[0].ToString());
                    }
                  //  this.product_event.Items.Add("없음");

                    con.Close();
                }
            }
        }
        
        private void btn_all_Click(object sender, EventArgs e)
        {
            point_use_point.Text = "";
            point_use_point.Text = point_count.Text;
        }
        private int val;
        public int Val
        {
            get { return val; }
            set { val = value; }
        }

        private void btn_use_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Val = int.Parse(this.point_use_point.Text);
            int a;
            a = int.Parse(this.point_use_point.Text);

            main.Show();
        }

        private void PointManagement_Load(object sender, EventArgs e)
        {
            this.point_pay.Text = Val.ToString();
        }
    }
}
