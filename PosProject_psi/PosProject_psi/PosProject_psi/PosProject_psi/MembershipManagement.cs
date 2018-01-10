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
    public partial class MembershipManagement : Form
    {
        List<Users> list = new List<Users>();

        public MembershipManagement()
        {
            InitializeComponent();
        }

        private void MembershipManagement_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString))
            {
                con.Open();
                MemberGridView.DataSource = null;

                using (var cmd = new SqlCommand("MemberLoad", con))
                {
                    var sdr = cmd.ExecuteReader();
                    if (!sdr.HasRows)
                    {
                        return;
                    }
                    else
                    {
                        while (sdr.Read())
                        {
                            list.Add(new Users()
                            {
                                UserNum = int.Parse(sdr["user_num"].ToString()),
                                UserName = sdr["user_name"].ToString(),
                                UserPhone = sdr["user_phone"].ToString(),
                                UserDate = sdr["user_date"].ToString().Substring(0, 10)
                            });
                        }
                        
                        this.MemberGridView.DataSource = list;
                        
                        sdr.Close();
                        MemberGridView.Columns[0].HeaderText = "NO";
                        MemberGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        MemberGridView.Columns[1].HeaderText = "회원명";
                        MemberGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        MemberGridView.Columns[2].HeaderText = "전화번호";
                        MemberGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        MemberGridView.Columns[3].HeaderText = "생년월일";
                        MemberGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            new MemberAdd().Show();
            this.Hide();
            MembershipManagement msm = new MembershipManagement();
            this.Close();
        }

        private void btn_Modi_Click(object sender, EventArgs e)
        {
            new MemberModi().Show();
            this.Hide();
            MembershipManagement msm = new MembershipManagement();
            this.Close();
        }
    }
}