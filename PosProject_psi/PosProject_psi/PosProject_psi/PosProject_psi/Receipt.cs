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
            ReceiptGridView.ColumnCount = 4;
            ReceiptGridView.Columns[0].Name = "NO";
            ReceiptGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReceiptGridView.Columns[1].Name = "거래시간";
            ReceiptGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReceiptGridView.Columns[2].Name = "거래형태";
            ReceiptGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReceiptGridView.Columns[3].Name = "금액";
            ReceiptGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
