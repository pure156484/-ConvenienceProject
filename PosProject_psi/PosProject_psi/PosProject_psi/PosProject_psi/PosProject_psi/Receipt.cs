using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_psi
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            MemberGridView.ColumnCount = 4;
            MemberGridView.Columns[0].Name = "NO";
            MemberGridView.Columns[1].Name = "거래시간";
            MemberGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberGridView.Columns[2].Name = "거래형태";
            MemberGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberGridView.Columns[3].Name = "금액";
            MemberGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
