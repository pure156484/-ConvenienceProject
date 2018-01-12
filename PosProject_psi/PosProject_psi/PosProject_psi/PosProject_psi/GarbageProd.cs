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
    public partial class GarbageProd : Form
    {
        List<Garbage> list = new List<Garbage>();
        DataSet ds;
        DataGridView myView;
        DataTable GarbageTable;

        public GarbageProd()
        {
            InitializeComponent();
        }

        private void GarbageProd_Load(object sender, EventArgs e)
        {
            using(var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("GarbageLoad", con);

                ds = new DataSet();
                adapter.Fill(ds);
                GarbageeView(ds);
            }
        }

        private void GarbageeView(DataSet ds)
        {
            itemGrid.Rows.Clear();

            myView = new DataGridView();

            itemGrid.ColumnCount = 5;
            itemGrid.Columns[0].Name = "폐기번호";
            itemGrid.Columns[1].Name = "상품명";
            itemGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemGrid.Columns[2].Name = "상품바코드";
            itemGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemGrid.Columns[3].Name = "폐기날짜";
            itemGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemGrid.Columns[4].Name = "폐기수량";

            GarbageTable = ds.Tables[0];
            DataRowCollection rows = GarbageTable.Rows;
            foreach (DataRow dr in rows)
            {
                string[] row =
                {
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString().Substring(0, 10), dr[4].ToString()
                };
                itemGrid.Rows.Add(row);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.Month + "월 " + DateTime.Now.Day + "일 " + DateTime.Now.ToLongTimeString();
        }
    }
}
