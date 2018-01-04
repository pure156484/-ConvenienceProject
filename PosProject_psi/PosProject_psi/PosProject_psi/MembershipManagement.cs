using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonProject
{
    public partial class MembershipManagement : Form
    {
        public MembershipManagement()
        {
            InitializeComponent();
        }

        private void MembershipManagement_Load(object sender, EventArgs e)
        {
            MemberGridView.ColumnCount = 5;
            MemberGridView.Columns[0].Name = "NO";
            MemberGridView.Columns[1].Name = "회원명";
            MemberGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberGridView.Columns[2].Name = "전화번호";
            MemberGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberGridView.Columns[3].Name = "생년월일";
            MemberGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberGridView.Columns[4].Name = "포인트 현황";
            MemberGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MemberAdd ma = new MemberAdd();
            ma.Show();
        }
    }
}