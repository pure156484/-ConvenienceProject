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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            empGridView.ColumnCount = 6;
            empGridView.Columns[0].Name = "사 번";
            empGridView.Columns[1].Name = "이 름";
            empGridView.Columns[2].Name = "연 락 처";
            empGridView.Columns[3].Name = "직 책";
            empGridView.Columns[4].Name = "주 소";
            empGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            empGridView.Columns[5].Name = "누 적 근 무 시 간";
            empGridView.Columns[5].Name = "누 적 수 당";
            

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            lblDate.Text = DateTime.Now.Month + "월 " + DateTime.Now.Day + "일 " + DateTime.Now.ToLongTimeString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtAddr.ReadOnly = false;
            txtCeoName.ReadOnly = false;
            txtCeoNum.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtShopName.ReadOnly = false;
            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            txtAddr.BackColor = Color.White;
            txtCeoName.BackColor = Color.White;
            txtCeoNum.BackColor = Color.White;
            txtPhone.BackColor = Color.White;
            txtShopName.BackColor = Color.White;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
